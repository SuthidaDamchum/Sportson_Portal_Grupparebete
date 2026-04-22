import { useEffect, useState } from 'react';
import './SupportPage.css';
import emailjs from '@emailjs/browser';
import { getUserData } from "../services/UserService";
import type { UserType } from "../types/UserType";

// Placeholder email
const departmentEmails: Record<string, string> = {
  "IT": "kevin.spehling@iths.se",
  "Marknadsföring": "kevin.spehling@iths.se",
  "Inköp": "kevin.spehling@iths.se",
  "Övrigt": "kevin.spehling@iths.se"
};

const SupportPage = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [department, setDepartment] = useState("");
  const [message, setMessage] = useState("");
  const [error, setError] = useState("");

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


  const handleSubmit = () => {
    if (!validateForm()) {
      return;
    }

    emailjs.send(
      "service_wjjx8qh",
      "template_ckjywh9",
      {
        from_name: name,
        from_email: email,
        department: department,
        message: message,
        to_email: departmentEmails[department],
        department_name: department
      },
      "4qDKbbtSPS3-VqLTl"
    ).then(() => {
      alert("Ditt meddelande har skickats!");
      setName("");
      setEmail("");
      setDepartment("");
      setMessage("");
      setError("");
    }).catch(() => {
      setError("Något gick fel, försök igen.");
    });
  };

  return (
    <div className="support-wrapper">
      <h1>Support</h1>
      <div className="support-form">
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
            <option key={dept} value={dept}>{dept}</option>
          ))}
        </select>

        <textarea
          id="support-message-textarea"
          placeholder="Ditt meddelande"
          className="messageArea"
          value={message}
          onChange={(e) => setMessage(e.target.value)}
        />

        <button id="support-submit-button" 
                onClick={handleSubmit}>
                Skicka
        </button>

        {error && (
          <textarea
            readOnly
            value={error}
            className="messageArea"
            style={{
              color: '#f0c000',
              textAlign: 'center',
              maxWidth: '100%',
              minHeight: '25px',
              maxHeight: '35px',
              backgroundColor: '#1a1a1a',
              marginTop: '5px',
              resize: 'none'
            }}
          />
        )}
      </div>
    </div>
  );
};

export default SupportPage;