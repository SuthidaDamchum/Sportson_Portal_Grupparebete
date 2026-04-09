import { useState } from 'react';
import './SupportPage.css';
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
  console.log({ name, email, department, message }); //<- Replace here
  alert("Ditt meddelande har skickats!");
  setName("");
  setEmail("");
  setDepartment("");
  setMessage("");
};

  return (
  <div className="support-wrapper">
    <h1>Support</h1>
      
      <div className="support-form">
        {/* Name */}     
        <input
          type="text"
          placeholder="Ditt namn"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        {/* Email */}           
        <input
          type="email"
          placeholder="Din e-post"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
        {/* Dropdown for department selection */}
        <select value={department} onChange={(e) => setDepartment(e.target.value)}>
          <option value="">Välj avdelning</option>
          {Object.keys(departmentEmails).map((dept) => (
            <option key={dept} value={dept}>{dept}</option>
          ))}
        </select>
        {/* Message */}     
        <textarea
          placeholder="Ditt meddelande"
          className='messageArea'
          value={message}
          onChange={(e) => setMessage(e.target.value)}
        />
        {/* Send it */}     
        <button onClick={handleSubmit}>Skicka</button>
      </div>
    
    </div>
  );
};

export default SupportPage;
