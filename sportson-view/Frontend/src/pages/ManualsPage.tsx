import SearchBar from "../components/SearchBar/Searchbar";
import "./ManualsPage.css";
import { useEffect, useState } from "react";
import { getSearchResults } from "../services/SearchService";
import type { SearchResult } from "../types/SearchType";

const categories = [
  "Alla",
  "Handböcker",
  "Säljhjälp",
  "Verkstad",
  "Kassa",
  "Kommunikation",
  "Frakt",
];

const types = ["Alla", "Youtube", "PDF"];

const ManualsPage = () => {
  const resultsPerPage = 7;
  const [manualResults, setManualResults] = useState<SearchResult[]>([]);
  const [currentPage, setCurrentPage] = useState(1);
  const [selectedCategory, setSelectedCategory] = useState("Alla");
  const [selectedType, setSelectedType] = useState("Alla");

  useEffect(() => {
    const loadResults = async () => {
      const results = await getSearchResults();
      setManualResults(results);
    };

    void loadResults();
  }, []);

  const filteredResults = manualResults.filter((result) => {
    const matchesCategory =
      selectedCategory === "Alla" || result.category === selectedCategory;
    const matchesType = selectedType === "Alla" || result.type === selectedType;

    return matchesCategory && matchesType;
  });

  useEffect(() => {
    setCurrentPage(1);
  }, [selectedCategory, selectedType]);

  const totalPages = Math.max(
    1,
    Math.ceil(filteredResults.length / resultsPerPage),
  );
  const pageStart = (currentPage - 1) * resultsPerPage;
  const paginatedResults = filteredResults.slice(
    pageStart,
    pageStart + resultsPerPage,
  );

  const goToPreviousPage = () => {
    setCurrentPage((prevPage) => Math.max(1, prevPage - 1));
  };

  const goToNextPage = () => {
    setCurrentPage((prevPage) => Math.min(totalPages, prevPage + 1));
  };

  return (
    <div className="manuals-view">
      <section className="manuals-controls-panel search-zone">
        <SearchBar />
        <section className="manuals-filter-panel">
          <div className="manuals-filter-group manuals-filter-group-category filter-group">
            <h2 className="manuals-filter-title filter-label">Kategori:</h2>
            <div className="manuals-chip-row">
              {categories.map((category) => (
                <button
                  key={category}
                  type="button"
                  className={
                    selectedCategory === category
                      ? "manuals-chip chip manuals-chip-active active"
                      : "manuals-chip chip"
                  }
                  onClick={() => {
                    setSelectedCategory(category);
                    setSelectedType("Alla");
                  }}
                >
                  {category}
                </button>
              ))}
            </div>
          </div>

          <div className="manuals-filter-group manuals-filter-group-type filter-group">
            <h2 className="manuals-filter-title filter-label">Typ:</h2>
            <div className="manuals-chip-row">
              {types.map((type) => (
                <button
                  key={type}
                  type="button"
                  className={
                    selectedType === type
                      ? "manuals-chip chip type manuals-chip-active active"
                      : "manuals-chip chip type"
                  }
                  onClick={() => setSelectedType(type)}
                >
                  {type}
                </button>
              ))}
            </div>
          </div>
        </section>
      </section>

      <section className="content-area">
        <div className="table-wrap">
          <div className="result-count">
            <span>{filteredResults.length} resultat</span>
            <div className="result-pagination">
              <button
                type="button"
                className="result-page-btn"
                onClick={goToPreviousPage}
                disabled={currentPage === 1}
              >
                ←
              </button>

              <span className="result-page-indicator">
                {currentPage}/{totalPages}
              </span>

              <button
                type="button"
                className="result-page-btn"
                onClick={goToNextPage}
                disabled={currentPage === totalPages}
              >
                →
              </button>
            </div>
          </div>

          <div className="col-headers" role="row">
            <div>TYP</div>
            <div>NAMN</div>
            <div>KATEGORI</div>
          </div>

          {paginatedResults.map((result) => (
            <article key={result.id} className="result-row">
              <div
                className={
                  result.type === "Youtube"
                    ? "manuals-type-logo manuals-type-logo-yt"
                    : "manuals-type-logo manuals-type-logo-pdf"
                }
              >
                {result.type === "Youtube" ? (
                  <>
                    <span className="manuals-yt-mark">
                      <svg viewBox="0 0 10 10" focusable="false">
                        <path d="M3 2.4 8 5 3 7.6V2.4Z" />
                      </svg>
                    </span>
                    <span>Youtube</span>
                  </>
                ) : (
                  <>
                    <span className="manuals-pdf-mark">
                      <svg viewBox="0 0 20 24" focusable="false">
                        <path
                          fill="#2563eb"
                          d="M3 1h9l5 5v17a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1Zm8 1.8V7h4.2L11 2.8ZM6.2 18.7h1.2c1.4 0 2.2-.7 2.2-2 0-1.2-.8-1.9-2.2-1.9H6.2v3.9Zm1-3v2h.3c.7 0 1.1-.3 1.1-1s-.4-1-1.1-1h-.3Zm3.2 3h1v-1.4h1.6v-.8h-1.6v-.9h1.7v-.8h-2.7v3.9Zm3.3 0h1c1.3 0 2.1-.7 2.1-2 0-1.2-.8-1.9-2.1-1.9h-1v3.9Zm1-3v2h.1c.7 0 1.1-.3 1.1-1s-.4-1-1.1-1h-.1Z"
                        />
                      </svg>
                    </span>
                    <span>PDF</span>
                  </>
                )}
              </div>

              <div>
                <div className="row-name">{result.title}</div>
                <div className="row-desc">{result.description}</div>
              </div>

              <div>
                <span className="row-cat">{result.category}</span>
              </div>

              <a
                className="row-action"
                href={result.URL}
                target="_blank"
                rel="noopener noreferrer"
              >
                {result.type === "PDF" ? "Öppna PDF" : "Se video"}{" "}
                <span>→</span>
              </a>
            </article>
          ))}
        </div>
      </section>
    </div>
  );
};

export default ManualsPage;
