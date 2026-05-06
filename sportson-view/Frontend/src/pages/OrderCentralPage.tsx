import { useState } from "react";
import "./OrderCentralPage.css";
import { getOrder } from "../services/OrderCentralService";
import type { Order } from "../types/OrderType";

const OrderCentralPage = () => {
  const [selected, setSelected] = useState("ordernummer");
  const [filterOpen, setFilterOpen] = useState(false);
  const [searchValue, setSearchValue] = useState("");
  const [order, setOrder] = useState<Order | null>(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const tabs = [
    "Hantera Order",
    "Förmånscykel",
    "Webbordrar",
    "Avtalskunder",
    "Click & Collect Leverantörer",
  ];
  const radioOptions = [
    { id: "ordernummer", label: "Ordernummer" },
    { id: "faktura", label: "Fakturanummer" },
    { id: "ramnummer", label: "Ramnummer" },
  ];
  const filterFields = [
    "Butik",
    "Datum från",
    "Datum till",
    "Orderstatus",
    "Kundnamn",
    "Leverantör",
  ];

  const handleSearch = async () => {
    if (!searchValue.trim()) return;
    setLoading(true);
    setError(null);
    setOrder(null);
    try {
      const result = await getOrder(searchValue.trim());
      setOrder(result);
    } catch (err: unknown) {
      setError(err instanceof Error ? err.message : "Något gick fel.");
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="order-page">
      <div className="order-tabs">
        {tabs.map((tab) => (
          <button
            key={tab}
            type="button"
            className={`order-tab ${tab === "Hantera Order" ? "active" : ""}`}
          >
            {tab}
          </button>
        ))}
      </div>

      <div className="order-content">
        <div className="order-search-card">
          <div className="order-search-label">Sök efter en order</div>

          <input
            className="order-search-input"
            type="text"
            placeholder="Ange ordernummer, fakturanummer eller ramnummer…"
            value={searchValue}
            onChange={(e) => setSearchValue(e.target.value)}
            onKeyDown={(e) => e.key === "Enter" && handleSearch()}
          />

          <div className="order-radio-group">
            {radioOptions.map(({ id, label }) => (
              <div
                key={id}
                className={`order-radio ${selected === id ? "active" : ""}`}
                onClick={() => setSelected(id)}
              >
                <div className="order-radio-dot">
                  {selected === id && <div className="order-radio-inner" />}
                </div>
                {label}
              </div>
            ))}
          </div>

          <div
            className="order-filter-toggle"
            onClick={() => setFilterOpen(!filterOpen)}
          >
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

          <button
            className="order-submit-btn"
            onClick={handleSearch}
            disabled={loading}
          >
            {loading
              ? "Hämtar..."
              : `Hämta Order via ${radioOptions.find((o) => o.id === selected)?.label}`}
          </button>
        </div>

        <div className="order-results-card">
          {error && <div className="order-results-error">{error}</div>}

          {!order && !error && !loading && (
            <div className="order-results-empty">
              Orderuppgifter visas här efter sökning
            </div>
          )}

          {loading && (
            <div className="order-results-empty">Hämtar order...</div>
          )}

          {order && (
            <div className="order-results">

              <div className="order-header-row">
                <div className="order-header-left">
                  <h2 className="order-title">Order {order.OrderHead.OrderNo}</h2>
                  <span className="order-status-badge">{order.OrderHead.OrderStatusText}</span>
                  <span className="order-type-badge">{order.OrderHead.OrderType}</span>
                </div>
                <div className="order-header-date">{order.OrderHead.OrderDate}</div>
              </div>

              {order.OrderHead.FailedRulesCheck && (
                <div className="order-rules-warning">
                  <span className="order-warning-icon">⚠</span>
                  <div>
                    {order.OrderHead.FailedRulesMessages.map((msg, i) => (
                      <p key={i}>{msg}</p>
                    ))}
                  </div>
                </div>
              )}

              <div className="order-info-grid">
                <div className="order-info-section">
                  <div className="order-info-title">Kund</div>
                  <div className="order-info-row">
                    <span className="order-info-label">Namn</span>
                    <span className="order-info-value">
                      {order.OrderHead.Customer.FirstName} {order.OrderHead.Customer.LastName}
                    </span>
                  </div>
                  <div className="order-info-row">
                    <span className="order-info-label">Bolag</span>
                    <span className="order-info-value">{order.OrderHead.Customer.Company}</span>
                  </div>
                  <div className="order-info-row">
                    <span className="order-info-label">E-post</span>
                    <span className="order-info-value">{order.OrderHead.Customer.Email}</span>
                  </div>
                  <div className="order-info-row">
                    <span className="order-info-label">Telefon</span>
                    <span className="order-info-value">{order.OrderHead.Customer.Phone}</span>
                  </div>
                </div>

                <div className="order-info-section">
                  <div className="order-info-title">Orderinfo</div>
                  <div className="order-info-row">
                    <span className="order-info-label">Ordernummer</span>
                    <span className="order-info-value">{order.OrderHead.OrderNo}</span>
                  </div>
                  <div className="order-info-row">
                    <span className="order-info-label">Typ</span>
                    <span className="order-info-value order-info-bold">{order.OrderHead.OrderType}</span>
                  </div>
                  <div className="order-info-row">
                    <span className="order-info-label">Butik</span>
                    <span className="order-info-value order-info-bold">{order.OrderHead.NewShop.Name}</span>
                  </div>
                </div>
              </div>

              <table className="order-items-table">
                <thead>
                  <tr>
                    <th colSpan={2}>Produkt</th>
                    <th>Art.nr</th>
                    <th>Storlek</th>
                    <th className="order-th-right">Pris</th>
                  </tr>
                </thead>
                <tbody>
                  {order.Items.map((item, index) => (
                    <tr key={index}>
                      <td className="order-item-img-cell">
                        <img src={item.ImageLink} alt={item.ProductName} />
                      </td>
                      <td>
                        <div className="order-item-name">{item.ProductName}</div>
                        <div className="order-item-sub">{item.Color}</div>
                      </td>
                      <td className="order-item-muted">{item.PartNo}</td>
                      <td className="order-item-muted">{item.Size || "–"}</td>
                      <td className="order-item-price">
                        {item.GrossAmount.toLocaleString("sv-SE")} kr
                      </td>
                    </tr>
                  ))}
                </tbody>
                <tfoot>
                  <tr>
                    <td colSpan={4} className="order-total-label">Totalt brutto</td>
                    <td className="order-total-value">
                      {order.OrderHead.TotalGrossAmount.toLocaleString("sv-SE")} kr
                    </td>
                  </tr>
                </tfoot>
              </table>

            </div>
          )}
        </div>
      </div>
    </div>
  );
};

export default OrderCentralPage;