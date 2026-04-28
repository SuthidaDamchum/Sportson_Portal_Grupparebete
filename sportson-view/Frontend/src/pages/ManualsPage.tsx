import SearchBar from "../components/SearchBar/Searchbar";
import "./ManualsPage.css";
import { useEffect, useState } from "react";
import { getSearchResults } from "../services/SearchService";
import { toYouTubeEmbedUrl } from "../services/YouTubeEmbedService";
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
  
  // States
  const [manualResults, setManualResults] = useState<SearchResult[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [currentPage, setCurrentPage] = useState(1);
  const [selectedCategory, setSelectedCategory] = useState("Alla");
  const [selectedType, setSelectedType] = useState("Alla");
  const [openYoutubeRowId, setOpenYoutubeId] = useState<number | null>(null);

  // Hämta data (Try/Catch sköts inuti getSearchResults)
  useEffect(() => {
    const fetchManuals = async () => {
      setIsLoading(true);
      const results = await getSearchResults();
      setManualResults(results);
      setIsLoading(false);
    };
    void fetchManuals();
  }, []);

  // Filtrering
  const filteredResults = manualResults.filter((result) => {
    const matchesCategory =
      selectedCategory === "Alla" || result.category === selectedCategory;
    const matchesType = selectedType === "Alla" || result.type === selectedType;

    return matchesCategory && matchesType;
  });

  // Nollställ sida vid filterändring
  useEffect(() => {
    setCurrentPage(1);
  }, [selectedCategory, selectedType]);

  // Paginering logik
  const totalPages = Math.max(1, Math.ceil(filteredResults.length / resultsPerPage));
  const pageStart = (currentPage - 1) * resultsPerPage;
  const paginatedResults = filteredResults.slice(pageStart, pageStart + resultsPerPage);

  const goToPreviousPage = () => setCurrentPage((prev) => Math.max(1, prev - 1));
  const goToNextPage = () => setCurrentPage((prev) => Math.min(totalPages, prev + 1));

  const toggleYoutubeRow = (result: SearchResult) => {
    if (result.type !== "Youtube") return;
    setOpenYoutubeId((prev) => (prev === result.id ? null : result.id));
  };

  return (
    <div className="manuals-view">
      <section className="manuals-controls-panel search-zone">
        <SearchBar />
        <section className="manuals-filter-panel">
          {/* Kategori Filter */}
          <div className="manuals-filter-group filter-group">
            <h2 className="manuals-filter-title filter-label">Kategori:</h2>
            <div className="manuals-chip-row">
              {categories.map((category) => (
                <button
                  key={category}
                  type="button"
                  className={`manuals-chip chip ${selectedCategory === category ? "manuals-chip-active active" : ""}`}
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

          {/* Typ Filter */}
          <div className="manuals-filter-group filter-group">
            <h2 className="manuals-filter-title filter-label">Typ:</h2>
            <div className="manuals-chip-row">
              {types.map((type) => (
                <button
                  key={type}
                  type="button"
                  className={`manuals-chip chip type ${selectedType === type ? "manuals-chip-active active" : ""}`}
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
          {/* Header & Pagination info */}
          <div className="result-count">
            <span>{filteredResults.length} resultat</span>
            <div className="result-pagination">
              <button
                type="button"
                className="result-page-btn"
                onClick={goToPreviousPage}
                disabled={currentPage === 1 || isLoading}
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
                disabled={currentPage === totalPages || isLoading}
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

          {/* Laddnings-vy eller Resultat */}
          {isLoading ? (
            <div className="loading-state">Hämtar manualer...</div>
          ) : filteredResults.length === 0 ? (
            <div className="no-results">Inga manualer matchar dina filter.</div>
          ) : (
            paginatedResults.map((result) => {
              const isYoutube = result.type === "Youtube";
              const isExpanded = openYoutubeRowId === result.id;
              const baseEmbedUrl = isYoutube ? toYouTubeEmbedUrl(result.URL) : null;
              const embedUrl = baseEmbedUrl ? `${baseEmbedUrl}?autoplay=1&rel=0&playsinline=1` : null;

              return (
                <article
                  key={result.id}
                  className={`result-row ${isYoutube ? "result-row-clickable" : ""}`}
                  onClick={() => {
                    if (isYoutube) {
                      toggleYoutubeRow(result);
                    } else {
                      window.open(result.URL, "_blank", "noopener,noreferrer");
                    }
                  }}
                >
                  {/* Icon Column */}
                  <div className={`manuals-type-logo ${isYoutube ? "manuals-type-logo-yt" : "manuals-type-logo-pdf"}`}>
                    {isYoutube ? (
                      <>
                        <span className="manuals-yt-mark">
                          <svg viewBox="0 0 10 10"><path d="M3 2.4 8 5 3 7.6V2.4Z" /></svg>
                        </span>
                        <span>Youtube</span>
                      </>
                    ) : (
                      <>
                        <span className="manuals-pdf-mark">
                          <svg viewBox="0 0 20 24"><path fill="#2563eb" d="M3 1h9l5 5v17a1 1 0 0 1-1 1H3a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1Zm8 1.8V7h4.2L11 2.8ZM6.2 18.7h1.2c1.4 0 2.2-.7 2.2-2 0-1.2-.8-1.9-2.2-1.9H6.2v3.9Zm1-3v2h.3c.7 0 1.1-.3 1.1-1s-.4-1-1.1-1h-.3Zm3.2 3h1v-1.4h1.6v-.8h-1.6v-.9h1.7v-.8h-2.7v3.9Zm3.3 0h1c1.3 0 2.1-.7 2.1-2 0-1.2-.8-1.9-2.1-1.9h-1v3.9Zm1-3v2h.1c.7 0 1.1-.3 1.1-1s-.4-1-1.1-1h-.1Z"/></svg>
                        </span>
                        <span>PDF</span>
                      </>
                    )}
                  </div>

                  {/* Title & Desc */}
                  <div>
                    <div className="row-name">{result.title}</div>
                    <div className="row-desc">{result.description}</div>
                  </div>

                  {/* Category */}
                  <div>
                    <span className="row-cat">{result.category}</span>
                  </div>

                  {/* Action Link/Btn */}
                  {result.type === "PDF" ? (
                    <a className="row-action" href={result.URL} target="_blank" rel="noopener noreferrer" onClick={(e) => e.stopPropagation()}>
                      Öppna PDF <span>→</span>
                    </a>
                  ) : (
                    <span className="row-action row-action-btn">
                      {isExpanded ? "Dölj video" : "Se video"} <span>→</span>
                    </span>
                  )}

                  {/* Video Panel */}
                  {isExpanded && embedUrl && (
                    <div className="manuals-video-panel" onClick={(e) => e.stopPropagation()}>
                      <div className="manuals-video-frame-wrap">
                        <iframe
                          className="manuals-video-frame"
                          src={embedUrl}
                          title={`YouTube video: ${result.title}`}
                          allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                          allowFullScreen
                        />
                      </div>
                      <button type="button" className="manuals-video-close" onClick={() => setOpenYoutubeId(null)}>
                        ✕ Stäng
                      </button>
                    </div>
                  )}
                </article>
              );
            })
          )}
        </div>
      </section>
    </div>
  );
};

export default ManualsPage;