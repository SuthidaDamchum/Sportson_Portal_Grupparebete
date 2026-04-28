import { useState } from "react";
import "./OrderCentralPage.css";

const OrderCentralPage = () => {
  const [selected, setSelected] = useState("ordernummer");
  const [filterOpen, setFilterOpen] = useState(false);

  const tabs = ["Hantera Order", "Förmånscykel", "Webbordrar", "Avtalskunder", "Click & Collect Leverantörer"];
  const radioOptions = [
    { id: "ordernummer", label: "Ordernummer" },
    { id: "faktura", label: "Fakturanummer (Nutid)" },
    { id: "ramnummer", label: "Ramnummer" },
  ];
  const filterFields = ["Butik", "Datum från", "Datum till", "Orderstatus", "Kundnamn", "Leverantör"];

  return (
    <div className="order-page">
      <div className="order-tabs">
        {tabs.map((tab) => (
          <div key={tab} className={`order-tab ${tab === "Hantera Order" ? "active" : ""}`}>
            {tab}
          </div>
        ))}
      </div>

      <div className="order-content">
        <div className="order-search-card">
          <div className="order-search-label">Sök efter en order</div>

          <input className="order-search-input" type="text" placeholder="Ange ordernummer, fakturanummer eller ramnummer…" />

          <div className="order-radio-group">
            {radioOptions.map(({ id, label }) => (
              <div key={id} className={`order-radio ${selected === id ? "active" : ""}`} onClick={() => setSelected(id)}>
                <div className="order-radio-dot">
                  {selected === id && <div className="order-radio-inner" />}
                </div>
                {label}
              </div>
            ))}
          </div>

          <div className="order-filter-toggle" onClick={() => setFilterOpen(!filterOpen)}>
            {filterOpen ? "－ Stäng filter" : "＋ Öppna filter"}
          </div>

          {filterOpen && (
            <div className="order-filter-grid">
              {filterFields.map((label) => (
                <div key={label}>
                  <div className="order-filter-label">{label}</div>
                  <input className="order-filter-input" type="text" />
                </div>
              ))}
            </div>
          )}

          <button className="order-submit-btn">Hämta Order via ordernummer</button>
    
        </div>

        <div className="order-results-card">
          <div className="order-results-empty">Orderuppgifter visas här efter sökning</div>
        </div>
      </div>
    </div>
  );
};

export default OrderCentralPage;