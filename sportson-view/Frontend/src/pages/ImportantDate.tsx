import { useEffect, useState } from "react";
import { getImportantDate } from "../services/ImportantDateService";
import type { ImportantDateDto } from "../types/ImportantDateType";
import "./ImportantDate.css";

const ImportantDate = () => {
  //Mockdata
  const mockData: ImportantDateDto[] = [
    { id: 1, title: "Frukostmöte: Nytt förmånspaket", month: "Maj", dateDisplay: "04", time: "08.00 - 09.00" },
    { id: 2, title: "Kampanjstart: Sommarcyklar 2026", month: "Maj", dateDisplay: "11", time: "Hela dagen" },
    { id: 3, title: "Personalmöte - Volvo tjänstebilar", month: "Maj", dateDisplay: "15", time: "13.00 - 15.00" },
    { id: 4, title: "Utbildning: Service av elmotorer", month: "Maj", dateDisplay: "26", time: "09.00 - 17.00" },
    { id: 5, title: "Deadline: Beställning Volvo-kläder", month: "Juni", dateDisplay: "02", time: "Senast kl 16.00" },
    { id: 6, title: "Sommarfest med teamet", month: "Juni", dateDisplay: "19", time: "17.00 - Sent" },
    { id: 7, title: "Inventering av butikslager", month: "Juni", dateDisplay: "25", time: "07.00 - 12.00" }
  ];

  //Kör mockdatan annars det blir tomt utan koppla till API 
  const [dates, setDates] = useState<ImportantDateDto[]>(mockData);

  useEffect(() => {
    getImportantDate()
      .then((result) => {
        // Om databasen svarar och inte är tom, använd den datan istället
        if (result && result.length > 0) {
          setDates(result);
        }
      })
      .catch((err) => {
        console.error("Kunde inte nå databasen, använder mock-data:", err);
      });
  }, []);

  const months = Array.from(new Set(dates.map((d) => d.month)));

  return (
    <div className="compact-side-container">
      <div className="side-header">
        <h2>Viktiga datum</h2>
        <button className="view-all-btn">Visa alla →</button>
      </div>

      <div className="scroll-content">
        {months.map((monthName) => (
          <div key={monthName} className="month-block">
            <h3 className="month-label">{monthName}</h3>

            {dates
              .filter((d) => d.month === monthName)
              .map((item, index) => (
                <div key={item.id} className="event-card-row">
                  <div className="date-box-black">{item.dateDisplay}</div>
                  <div
                    className={`event-info-box ${
                      index % 2 === 0 ? "new-bg-yellow" : "new-bg-white"
                    }`}
                  >
                    <p className="event-name">{item.title}</p>
                    <div className="time-row">
                      <span style={{ fontSize: "0.65rem" }}>🕒</span>
                      <span className="time-text">
                        {item.time || "Hela dagen"}
                      </span>
                    </div>
                  </div>
                </div>
              ))}
          </div>
        ))}
      </div>
    </div>
  );
};

export default ImportantDate;