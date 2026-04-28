import { useEffect, useState } from "react";
import { getImportantDate } from "../services/ImportantDateService";
import type { ImportantDateDto } from "../types/ImportantDateType";
import "./ImportantDate.css";

const ImportantDate = () => {
  //Mockdata
  const mockData: ImportantDateDto[] = [
    {
      id: 1,
      title: "Frukostmöte: Nytt förmånspaket",
      month: "Maj",
      dateDisplay: "04",
      time: "08.00 - 09.00",
    },
    {
      id: 2,
      title: "Kampanjstart: Sommarcyklar 2026",
      month: "Maj",
      dateDisplay: "11",
      time: "Hela dagen",
    },
    {
      id: 3,
      title: "Kampanj: Cykelhjälmar REA",
      month: "Maj",
      dateDisplay: "15",
      time: "13.00 - 15.00",
    },
    {
      id: 4,
      title: "Utbildning: Service av elmotorer",
      month: "Maj",
      dateDisplay: "26",
      time: "09.00 - 17.00",
    },
    {
      id: 5,
      title: "Servicedag: Bromsar och växlar",
      month: "Juni",
      dateDisplay: "02",
      time: "Senast kl 17.00",
    },
    {
      id: 6,
      title: "Sommarfest med teamet",
      month: "Juni",
      dateDisplay: "19",
      time: "17.00 - Sent",
    },
    {
      id: 7,
      title: "Inventering av butikslager",
      month: "Juni",
      dateDisplay: "25",
      time: "07.00 - 12.00",
    },
  ];
  const [dates, setDates] = useState<ImportantDateDto[]>(mockData);
  //Ingenting bör visas fören användaren är inloggad, så jag har lagt till en state för det också.
  const [isSignedIn, setIsSignedIn] = useState(false);

  useEffect(() => {
    getImportantDate()
      .then((result) => {
        if (result && result.length > 0) {
          setDates(result);
          setIsSignedIn(true);
        }
      })
      .catch(() => {
        //Not sure we need to catch anything here, but if the API call fails, we can just keep showing the mock data and not set the user as signed in.
      });
  }, []);

  const months = Array.from(new Set(dates.map((d) => d.month)));

  if (isSignedIn) {
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
  }
};

export default ImportantDate;
