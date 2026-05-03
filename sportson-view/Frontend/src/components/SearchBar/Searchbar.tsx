import "./SearchBar.css";

interface SearchBarProps {
  onSearch: (term: string) => void;
}

const SearchBar = ({ onSearch }: SearchBarProps) => {
  return (
    <section id="search-section">
      <input
        id="search-input"
        type="search"
        onChange={(e) => onSearch(e.target.value)}
        placeholder="Sök efter PDF-manualer & YouTube guider"
      />
    </section>
  );
};

export default SearchBar;
