import SearchBar from "../components/SearchBar/Searchbar";
import "./ManualsPage.css";

const categories = [
  "Alla",
  "Handböcker",
  "Säljhjälp",
  "Verkstad",
  "Kassa",
  "Kommunikation",
  "Frakt",
];

const types = ["Alla", "YouTube", "PDF"];

const ManualsPage = () => {
  return (
    <div className="manuals-view">
      <section className="manuals-controls-panel">
        <SearchBar />
        <section className="manuals-filter-panel" aria-label="Filtrering">
          <div className="manuals-filter-group manuals-filter-group-divider">
            <h2 className="manuals-filter-title">Kategori</h2>
            <div className="manuals-chip-row">
              {categories.map((category, index) => (
                <button
                  key={category}
                  type="button"
                  className={
                    index === 0
                      ? "manuals-chip manuals-chip-active"
                      : "manuals-chip"
                  }
                  aria-pressed={index === 0}
                >
                  {category}
                </button>
              ))}
            </div>
          </div>

          <div className="manuals-filter-group">
            <h2 className="manuals-filter-title">Typ</h2>
            <div className="manuals-chip-row">
              {types.map((type, index) => (
                <button
                  key={type}
                  type="button"
                  className={
                    index === 0
                      ? "manuals-chip manuals-chip-active"
                      : "manuals-chip"
                  }
                  aria-pressed={index === 0}
                >
                  {type}
                </button>
              ))}
            </div>
          </div>
        </section>
      </section>

      <section className="manuals-empty-state" aria-live="polite">
        <div className="manuals-empty-icon" aria-hidden="true" />
        <h3>Sök bland våra manualer och YouTube-guider</h3>
        <p>Skriv in ett sökord ovan för att hitta det du letar efter</p>
      </section>
    </div>
  );
};

export default ManualsPage;
