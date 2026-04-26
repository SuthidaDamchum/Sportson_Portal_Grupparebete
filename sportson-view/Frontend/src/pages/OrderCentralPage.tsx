import { useState } from "react";
import "./OrderCentralPage.css";
import type { Order, OrderItem  } from "../types/OrderType";

const OrderCentralPage = () => {
  // Håller koll på vilken söktyp som är vald (ordernummer, faktura, ramnummer)
  const [selected, setSelected] = useState("ordernummer");


  // Texten användaren skriver i sökfältet
  const [orderNo, setOrderNo] = useState("");

  // Orderdata från API, null = ingen order hämtad än
  const [order, setOrder] = useState<Order[] | null>(null);

  // true när API-anrop pågår
  const [loading, setLoading] = useState(false);

  // Felmeddelande om något går fel
  const [error, setError] = useState("");

  // Flikar längst upp på sidan
  const tabs = [
    "Hantera Order",
    "Förmånscykel",
    "Webbordrar",
    "Avtalskunder",
    "Click & Collect Leverantörer",
  ];

  // Sökalternativ - vilken typ av sökning
  const radioOptions = [
    { id: "ordernummer", label: "Ordernummer" },
    { id: "faktura", label: "Fakturanummer (Nutid)" },
    { id: "ramnummer", label: "Ramnummer" },
  ];

  // Funktion som körs när användaren klickar "Hämta Order"
  const handleSearch = async () => {
    // Avbryt om sökfältet är tomt
    if (!orderNo) return;

    // Visa laddningsindikator
    setLoading(true);

    // Rensa gamla felmeddelanden
    setError("");

    try {
      // Hämta inloggningstoken från localStorage
      const token = localStorage.getItem("token");

      // Anropa backend med ordernumret
      const res = await fetch(`/api/Order/${orderNo}`, {
        headers: { Authorization: `Bearer ${token}` },
      });

      // Konvertera svar till JSON
      const data = await res.json();

      // Spara orderdata i state
      setOrder(data);
    } catch {
      // Visa felmeddelande om något går fel
      setError("Kunde inte hämta order");
    } finally {
      // Dölj laddningsindikator oavsett resultat
      setLoading(false);
    }
  };

  // Plocka ut första ordern från arrayen för enklare åtkomst
  const orderData = order?.[0];
  return (
    <div className="order-page">
      {/* Flikar längst upp */}
      <div className="order-tabs">
        {tabs.map((tab) => (
          <div
            key={tab}
            className={`order-tab ${tab === "Hantera Order" ? "active" : ""}`}
          >
            {tab}
          </div>
        ))}
      </div>

      <div className="order-content">
        {/* Sökkort */}
        <div className="order-search-card">
          <div className="order-search-label">Sök efter en order</div>

          {/* Sökfält - uppdaterar orderNo state när användaren skriver */}
          <input
            className="order-search-input"
            type="text"
            placeholder="Ange ordernummer, fakturanummer eller ramnummer…"
            value={orderNo}
            onChange={(e) => setOrderNo(e.target.value)}
            onKeyDown={(e) => e.key === "Enter" && handleSearch()} // sök när Enter trycks
          />

          {/* Radio-knappar för söktyp */}
          <div className="order-radio-group">
            {radioOptions.map(({ id, label }) => (
              <div
                key={id}
                className={`order-radio ${selected === id ? "active" : ""}`}
                onClick={() => setSelected(id)} // sätt vald söktyp
              >
                {/* Radioknapp-cirkel */}
                <div className="order-radio-dot">
                  {/* Visa fylld cirkel om denna är vald */}
                  {selected === id && <div className="order-radio-inner" />}
                </div>
                {label}
              </div>
            ))}
          </div>

     

          {/* Sökknapp - visar "Hämtar..." när loading är true */}
          <button className="order-submit-btn" onClick={handleSearch}>
            {loading ? "Hämtar..." : "Hämta Order"}
          </button>

          {/* Felmeddelande visas om error inte är tom */}
          {error && (
            <div style={{ color: "red", fontSize: "13px" }}>{error}</div>
          )}
        </div>

        {/* Resultatkort */}
        <div className="order-results-card">
          {/* Visa tom text om ingen order hämtats */}
          {!order && !loading && (
            <div className="order-results-empty">
              Orderuppgifter visas här efter sökning
            </div>
          )}

          {/* Visa orderdata om den finns */}
          {orderData && (
            <div style={{ width: "100%" }}>
              {/* Order header - nummer, status och typ */}
              <div
                style={{
                  display: "flex",
                  alignItems: "center",
                  gap: "12px",
                  marginBottom: "20px",
                }}
              >
                <span
                  style={{
                    fontSize: "20px",
                    fontWeight: 500,
                    color: "#1a252f",
                  }}
                >
                  Order {orderData.OrderHead?.OrderNo}
                </span>
                {/* Statusbadge */}
                <span
                  style={{
                    fontSize: "16px",
                    padding: "3px 10px",
                    borderRadius: "99px",
                    background: "#fffbe6",
                    color: "#b8860b",
                    border: "1px solid #f5c800",
                  }}
                >
                  {orderData.OrderHead?.OrderStatusText}
                </span>
                {/* Typbadge */}
                <span
                  style={{
                    fontSize: "16px",
                    padding: "3px 10px",
                    borderRadius: "99px",
                    background: "#f7f7f7",
                    color: "#888",
                    border: "1px solid #e8edf1",
                  }}
                >
                  {orderData.OrderHead?.OrderType}
                </span>
              </div>

              {/* Varningsruta - visas bara om FailedRulesCheck är true */}
              {orderData.OrderHead?.FailedRulesCheck && (
                <div
                  style={{
                    background: "#fff3e0",
                    border: "1px solid #ffb74d",
                    borderRadius: "8px",
                    padding: "12px 16px",
                    marginBottom: "16px",
                    color: "#e60000",
                    fontSize: "13px",
                  }}
                >
                  {/* replace tar bort HTML-taggar från varningsmeddelandet */}⚠{" "}
                  {orderData.OrderHead?.FailedRulesMessages?.[0]?.replace(
                    /<[^>]+>/g,
                    "",
                  )}
                </div>
              )}

              {/* Kund och orderinfo i två kolumner */}
              <div
                style={{
                  display: "grid",
                  gridTemplateColumns: "1fr 1fr",
                  gap: "14px",
                  marginBottom: "16px",
                }}
              >
                {/* Kundinformation */}
                <div
                  style={{
                    background: "#f7f7f7",
                    borderRadius: "20px",
                    padding: "16px",
                    border: "1px solid #e8edf1",
                  }}
                >
                  <div
                    style={{
                      fontSize: "15px",
                      color: "#1a252f",
                      textTransform: "uppercase",
                      letterSpacing: "0.08em",
                      marginBottom: "12px",
                      fontWeight: 600,
                    }}
                  >
                    Kund
                  </div>
                  {[
                    [
                      "Namn",
                      `${orderData.OrderHead?.Customer?.FirstName} ${orderData.OrderHead?.Customer?.LastName}`,
                    ],
                    ["Bolag", orderData.OrderHead?.Customer?.Company],
                    ["E-post", orderData.OrderHead?.Customer?.Email],
                    ["Telefon", orderData.OrderHead?.Customer?.Phone],
                  ].map(([label, value]) => (
                    // Rad för varje kundfält
                    <div
                      key={label}
                      style={{
                        display: "flex",
                        justifyContent: "space-between",
                        padding: "6px 0",
                        borderBottom: "0.5px solid #e8edf1",
                        fontSize: "15px",
                      }}
                    >
                      <span style={{ color: "#1a252f" }}>{label}</span>
                      <span style={{ color: "#1a252f", fontWeight: 500 }}>
                        {value}
                      </span>
                    </div>
                  ))}
                </div>

                {/* Orderinformation */}
                <div
                  style={{
                    background: "#f7f7f7",
                    borderRadius: "10px",
                    padding: "16px",
                    border: "1px solid #e8edf1",
                  }}
                >
                  <div
                    style={{
                      fontSize: "15px",
                      color: "#0a0a0a",
                      textTransform: "uppercase",
                      letterSpacing: "0.08em",
                      marginBottom: "12px",
                      fontWeight: 600,
                    }}
                  >
                    Orderinfo
                  </div>
                  {[
                    ["Ordernummer", orderData.OrderHead?.OrderNo],
                    ["Datum", orderData.OrderHead?.OrderDate?.split("T")[0]], // ta bara datum-delen, inte tid
                    ["Typ", orderData.OrderHead?.OrderType],
                    ["Butik", orderData.OrderHead?.NewShop?.Name],
                  ].map(([label, value]) => (
                    // Rad för varje orderfält
                    <div
                      key={label}
                      style={{
                        display: "flex",
                        justifyContent: "space-between",
                        padding: "6px 0",
                        borderBottom: "0.5px solid #e8edf1",
                        fontSize: "15px",
                      }}
                    >
                      <span style={{ color: "#1a252f" }}>{label}</span>
                      <span style={{ color: "#1a252f", fontWeight: 500 }}>
                        {value}
                      </span>
                    </div>
                  ))}
                </div>
              </div>

              {/* Produktlista */}
              <div
                style={{
                  background: "#eef2f5",
                  borderRadius: "10px",
                  overflow: "hidden",
                  border: "1px solid #e8edf1",
                }}
              >
                <div
                  style={{
                    padding: "12px 16px",
                    borderBottom: "1px solid #e8edf1",
                  }}
                >
                  <span
                    style={{
                      fontSize: "16px",
                      color: "#2c2c2c",
                      textTransform: "uppercase",
                      letterSpacing: "0.08em",
                      fontWeight: 600,
                    }}
                  >
                    Produkter
                  </span>
                </div>

                {/* Loopa igenom alla produkter i ordern */}
                {orderData.Items?.map((item: OrderItem, i: number) => (
                  <div
                    key={i}
                    style={{
                      display: "flex",
                      alignItems: "center",
                      gap: "12px",
                      padding: "12px 16px",
                      borderBottom: "1px solid #e8edf1",
                      background: "white",
                    }}
                  >
                    {/* Produktbild - visas bara om ImageLink finns */}
                    {item.ImageLink && (
                      <img
                        src={item.ImageLink}
                        style={{
                          width: "80 px",
                          height: "60px",
                          borderRadius: "8px",
                          objectFit: "cover",
                        }}
                      />
                    )}
                    <div style={{ flex: 1 }}>
                      {/* Produktnamn */}
                      <div
                        style={{
                          fontSize: "15px",
                          fontWeight: 500,
                          color: "#1a252f",
                        }}
                      >
                        {item.ProductName}
                      </div>
                      {/* Artikelnummer, färg och storlek */}
                      <div style={{ fontSize: "15px", color: "#999" }}>
                        {item.PartNo} · {item.Color} · {item.Size}
                      </div>
                    </div>
                    {/* Pris formaterat med sv-SE locale (mellanslag som tusentalsavgränsare) */}
                    <div
                      style={{
                        fontSize: "15px",
                        fontWeight: 500,
                        color: "#1a252f",
                      }}
                    >
                      {item.GrossAmount?.toLocaleString("sv-SE")} kr
                    </div>
                  </div>
                ))}

                {/* Totalpris */}
                <div
                  style={{
                    display: "flex",
                    justifyContent: "flex-end",
                    padding: "14px 16px",
                    gap: "16px",
                    background: "white",
                  }}
                >
                  <span style={{ fontSize: "15px", color: "#1a252f" }}>
                    Totalt
                  </span>
                  <span
                    style={{
                      fontSize: "16px",
                      fontWeight: 500,
                      color: "#1a252f",
                    }}
                  >
                    {orderData.OrderHead?.TotalGrossAmount?.toLocaleString(
                      "sv-SE",
                    )}{" "}
                    kr
                  </span>
                </div>
              </div>
            </div>
          )}
        </div>
      </div>
    </div>
  );
};

export default OrderCentralPage;
