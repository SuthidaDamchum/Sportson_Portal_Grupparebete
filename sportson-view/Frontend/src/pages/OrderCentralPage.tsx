import { useState } from "react";

const OrderCentralPage = () => {
  const [selected, setSelected] = useState("ordernummer");
  const [filterOpen, setFilterOpen] = useState(false);

  return (
    <div
      style={{
        background: "#1a1a1a",
        minHeight: "100vh",
        width: "100%",
        padding: "32px 36px 36px",
      }}
    >
      <div
        style={{
          display: "flex",
          borderBottom: "0.5px solid rgba(255,255,255,0.08)",
          marginBottom: "26px",
          overflowX: "auto",
        }}
      >
        {[
          "Hantera Order",
          "Förmånscykel ▾",
          "Webbordrar",
          "Avtalskunder",
          "Click & Collect Leverantörer",
        ].map((tab) => (
          <div
            key={tab}
            style={{
              padding: "11px 18px",
              fontSize: "15px",
              fontWeight: 500,
              color: tab === "Hantera Order" ? "#F5C800" : "#555",
              borderBottom:
                tab === "Hantera Order"
                  ? "2px solid #F5C800"
                  : "2px solid transparent",
              marginBottom: "-0.5px",
              whiteSpace: "nowrap",
              cursor: "pointer",
            }}
          >
            {tab}
          </div>
        ))}
      </div>

      {/* SEARCH CARD */}
      <div
        style={{
          background: "#242424",
          border: "0.5px solid rgba(255,255,255,0.07)",
          borderRadius: "14px",
          padding: "28px",
          marginBottom: "16px",
        }}
      >
        <div
          style={{
            fontSize: "12px",
            fontWeight: 600,
            letterSpacing: "2px",
            textTransform: "uppercase",
            color: "#555",
            marginBottom: "18px",
          }}
        >
          Sök efter en order
        </div>

        <input
          type="text"
          placeholder="Ange ordernummer, fakturanummer eller ramnummer…"
          style={{
            width: "100%",
            background: "#2c2c2c",
            border: "0.5px solid rgba(255,255,255,0.1)",
            borderRadius: "9px",
            padding: "13px 16px",
            fontSize: "16px",
            color: "#f0f0f0",
            fontFamily: "inherit",
            marginBottom: "16px",
            outline: "none",
          }}
        />

        <div
          style={{
            display: "flex",
            gap: "8px",
            marginBottom: "16px",
            flexWrap: "wrap",
          }}
        >
          {[
            { id: "ordernummer", label: "Ordernummer" },
            { id: "faktura", label: "Fakturanummer (Nutid)" },
            { id: "ramnummer", label: "Ramnummer" },
          ].map(({ id, label }) => (
            <div
              key={id}
              onClick={() => setSelected(id)}
              style={{
                padding: "8px 18px",
                borderRadius: "24px",
                border:
                  selected === id
                    ? "0.5px solid #F5C800"
                    : "0.5px solid rgba(255,255,255,0.12)",
                fontSize: "13px",
                color: selected === id ? "#F5C800" : "#666",
                background:
                  selected === id ? "rgba(245,200,0,0.08)" : "transparent",
                display: "flex",
                alignItems: "center",
                gap: "8px",
                cursor: "pointer",
                fontFamily: "inherit",
              }}
            >
              <div
                style={{
                  width: "14px",
                  height: "14px",
                  borderRadius: "50%",
                  border: `1.5px solid ${selected === id ? "#F5C800" : "#666"}`,
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  flexShrink: 0,
                }}
              >
                {selected === id && (
                  <div
                    style={{
                      width: "6px",
                      height: "6px",
                      borderRadius: "50%",
                      background: "#F5C800",
                    }}
                  />
                )}
              </div>
              {label}
            </div>
          ))}
        </div>

        <div
          onClick={() => setFilterOpen(!filterOpen)}
          style={{
            width: "100%",
            background: "#2c2c2c",
            border: "0.5px solid rgba(255,255,255,0.08)",
            borderRadius: "9px",
            padding: "11px 16px",
            fontSize: "14px",
            color: "#666",
            display: "flex",
            alignItems: "center",
            gap: "8px",
            marginBottom: "16px",
            cursor: "pointer",
            fontFamily: "inherit",
          }}
        >
          {filterOpen ? "－" : "＋"}{" "}
          {filterOpen ? "Stäng filter" : "Öppna filter"}
        </div>

        {filterOpen && (
          <div
            style={{
              display: "grid",
              gridTemplateColumns: "repeat(3, 1fr)",
              gap: "14px",
              marginBottom: "16px",
            }}
          >
            {[
              "Butik",
              "Datum från",
              "Datum till",
              "Orderstatus",
              "Kundnamn",
              "Leverantör",
            ].map((label) => (
              <div key={label}>
                <div
                  style={{
                    fontSize: "11px",
                    color: "#555",
                    marginBottom: "6px",
                  }}
                >
                  {label}
                </div>
                <input
                  type="text"
                  style={{
                    width: "100%",
                    background: "#2c2c2c",
                    border: "0.5px solid rgba(255,255,255,0.1)",
                    borderRadius: "8px",
                    padding: "9px 12px",
                    fontSize: "13px",
                    color: "#f0f0f0",
                    fontFamily: "inherit",
                    outline: "none",
                  }}
                />
              </div>
            ))}
          </div>
        )}
        <button
          style={{
            width: "100%",
            background: "#F5C800",
            borderRadius: "9px",
            padding: "15px",
            fontSize: "14px",
            fontWeight: 600,
            color: "#111",
            textAlign: "center",
            marginBottom: "14px",
            cursor: "pointer",
            border: "none",
            fontFamily: "inherit",
          }}
        >
          Hämta Order via ordernummer
        </button>

        <div style={{ fontSize: "11px", color: "#444", textAlign: "right" }}>
          Senast ändring i systemet:{" "}
          <span style={{ color: "#666" }}>2020-11-23 11:54:24</span>
        </div>
      </div>

      <div
        style={{
          background: "#242424",
          border: "0.5px solid rgba(255,255,255,0.07)",
          borderRadius: "14px",
          padding: "48px",
          display: "flex",
          alignItems: "center",
          justifyContent: "center",
        }}
      >
        <div style={{ fontSize: "13px", color: "#555" }}>
          Orderuppgifter visas här efter sökning
        </div>
      </div>
    </div>
  );
};

export default OrderCentralPage;
