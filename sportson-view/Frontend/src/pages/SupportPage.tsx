import { useState } from 'react';
import './SupportPage.css';
import emailjs from '@emailjs/browser';
//Placeholder email
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

//TODO: Replace with actual email sending logic - EmailJS or similar
const handleSubmit = () => {
  if (!name || !email || !department || !message) {
    alert("Fyll i alla fält");
    return;
  }
    emailjs.send(
        "service_wjjx8qh", //IDKEY
        "template_ckjywh9", //TEMPLATEKEY
        {
          from_name: name,
          from_email: email,
          department: department,
          message: message,
          to_email: departmentEmails[department], //Unused due to emailjs free package limitations, sends to kevin.spehling@iths.se currently
          department_name: department
        },
        "4qDKbbtSPS3-VqLTl" //PASSKEY
      ).then(() => {
        alert("Ditt meddelande har skickats!");
        setName("");
        setEmail("");
        setDepartment("");
        setMessage("");
      }).catch(() => {
        alert("Något gick fel, försök igen.");
      });
};

  return (
  <div className="support-wrapper">
    <h1>Support</h1>
      <div className="support-form">
        {/* Name */}     
        <input
          id="support-name-input"
          type="text"
          placeholder="Ditt namn"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        {/* Email */}           
        <input
          id="support-email-input"
          type="email"
          placeholder="Din e-post"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        {/* Dropdown for department selection */}
        <select id="support-department-select" value={department} onChange={(e) => setDepartment(e.target.value)}>
          <option value="">Välj avdelning</option>
          {Object.keys(departmentEmails).map((dept) => (
            <option key={dept} value={dept}>{dept}</option>
          ))}
        </select>
        {/* Message */}     
        <textarea
          id="support-message-textarea"
          placeholder="Ditt meddelande"
          className='messageArea'
          value={message}
          onChange={(e) => setMessage(e.target.value)}
        />
        {/* Send it */}     
        <button id="support-submit-button" onClick={handleSubmit}>Skicka</button>
      </div>
    </div>
    
  );
};
export default SupportPage;
