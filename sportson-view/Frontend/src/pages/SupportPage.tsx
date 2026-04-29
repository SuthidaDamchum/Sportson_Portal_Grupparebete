import { useEffect, useState } from "react";
import "./SupportPage.css";
import { supportService } from "../services/SupportService";
import { getUserData } from "../services/UserService";
import type { UserType } from "../types/UserType";

// Placeholder email
const departmentEmails: Record<string, string> = {
  IT: "kevin.spehling@iths.se",
  Marknadsföring: "kevin.spehling@iths.se",
  Inköp: "kevin.spehling@iths.se",
  Övrigt: "kevin.spehling@iths.se",
};

const SupportPage = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [department, setDepartment] = useState("");
  const [message, setMessage] = useState("");
  const [error, setError] = useState("");
  const [openFaq, setOpenFaq] = useState<number | null>(null);

  const faqs = [
    {
      question: "Hur skapar jag ett supportärende?",
      answer:
        "Fyll i formuläret ovan med namn, e-post, avdelning och ditt meddelande. Klicka sedan på Skicka.",
    },
    {
      question: "Vilken avdelning ska jag välja?",
      answer:
        "Välj den avdelning som bäst passar ditt ärende. Om du är osäker kan du välja Övrigt.",
    },
    {
      question: "Vad händer efter att jag skickat in ett ärende?",
      answer:
        "Ditt meddelande skickas till rätt avdelning, och du får hjälp så snart som möjligt.",
    },
    {
      question: "Vad gör jag om jag inte får något svar?",
      answer:
        "Om du inte får svar kan du skicka in ett nytt ärende eller kontakta ansvarig avdelning direkt.",
    },
  ];

  const emailRegex = /^[^\s@]+@[^\s@]+\.[a-zA-Z]{2,63}$/;
  const [user, setUser] = useState<UserType | null>(null);

  const capitalize = (str: string) =>
    str[0].toLocaleUpperCase("sv-SE") + str.slice(1);

  useEffect(() => {
    const fetchUser = async () => {
      try {
        const data = await getUserData();
        setUser(data);
        setName(capitalize(data.username));
        setEmail(data.email);
      } catch {
        setUser(null);
      }
    };

    fetchUser();
  }, []);
  const validateForm = (): boolean => {
    setError("");

    if (!name.trim()) {
      setError("Fyll i namn");
      return false;
    }

    if (name.trim().length < 2) {
      setError("Namn måste innehålla minst 2 tecken.");
      return false;
    }

    if (!email.trim()) {
      setError("Fyll i e-postadress");
      return false;
    }

    if (!emailRegex.test(email.trim())) {
      setError("Vänligen ange en giltig e-postadress.");
      return false;
    }

    if (!department) {
      setError("Välj en avdelning");
      return false;
    }

    if (!message.trim()) {
      setError("Fyll i meddelande");
      return false;
    }

    if (message.trim().length < 10) {
      setError("Meddelande måste innehålla minst 10 tecken.");
      return false;
    }

    return true;
  };

  const handleSubmit = async () => {
    if (!validateForm()) {
      return;
    }

    try {
      await supportService.sendSupportMessage({
        name,
        store: user?.store ?? "Okänd",
        fromEmail: email,
        department,
        message,
      });

      setDepartment("");
      setMessage("");
      setError("");

      if (!user) {
        setName("");
        setEmail("");
      }
      setError("Ditt meddelande har skickats!");
    } catch (err) {
      setError(
        "Oväntat fel inträffade: " + (err instanceof Error ? err.message : ""),
      );
    }
  };

  return (
    <div className="support-wrapper">
      <div className="support-form">
        <h1>Support</h1>
        <h3>Kontaktformulär för {user?.store || "allmänna"}</h3>
        <input
          id="support-name-input"
          type="text"
          placeholder={user?.username || "Ditt namn"}
          disabled={!!user?.username}
          value={name}
          onChange={(e) => setName(e.target.value)}
        />

        <input
          id="support-email-input"
          type="email"
          value={email}
          placeholder={user?.email || "Ditt e-post"}
          disabled={!!user?.email}
          onChange={(e) => setEmail(e.target.value)}
        />

        <select
          id="support-department-select"
          value={department}
          onChange={(e) => setDepartment(e.target.value)}
        >
          <option value="">Välj avdelning</option>
          {Object.keys(departmentEmails).map((dept) => (
            <option key={dept} value={dept}>
              {dept}
            </option>
          ))}
        </select>

        <textarea
          id="support-message-textarea"
          placeholder="Ditt meddelande"
          className="messageArea"
          value={message}
          onChange={(e) => setMessage(e.target.value)}
        />

        <button id="support-submit-button" onClick={handleSubmit}>
          Skicka
        </button>

        {error && <p className="support-error">{error}</p>}
        <section className="faq-section">
          <h2>Vanliga frågor</h2>

          <div className="faq-list">
            {faqs.map((faq, index) => (
              <div className="faq-item" key={index}>
                <button
                  className="faq-question"
                  onClick={() => setOpenFaq(openFaq === index ? null : index)}
                >
                  <span>{openFaq === index ? "−" : "+"}</span>
                  {faq.question}
                </button>

                {openFaq === index && (
                  <div className="faq-answer">
                    <p>{faq.answer}</p>
                  </div>
                )}
              </div>
            ))}
          </div>
        </section>
      </div>
    </div>
  );
};

export default SupportPage;
