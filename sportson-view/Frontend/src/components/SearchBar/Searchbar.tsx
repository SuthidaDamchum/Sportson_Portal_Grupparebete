import "./SearchBar.css";
import { useState } from "react";

const SearchBar = () => {
  const [query, setQuery] = useState("");

  return (
    <section id="search">
      <input
        type="search"
        value={query}
        onChange={(event) => setQuery(event.target.value)}
        placeholder="Sök efter manualer"
      />
    </section>
  );
};

export default SearchBar;
