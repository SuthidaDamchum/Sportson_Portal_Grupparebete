import "./ContactsPage.css";

const contacts = [
  {
    id: 1,
    name: "Anna Svensson",
    role: "Leverantörskontakt",
    company: "Shimano",
    email: "anna@shimano.se",
    phone: "070-123 45 67",
  },
  {
    id: 2,
    name: "Erik Johansson",
    role: "Säljkontakt",
    company: "Garmin",
    email: "erik@garmin.se",
    phone: "070-987 65 43",
  },
];

const Contacts = () => {
  return (
    <div className="contacts-page">
      <div className="contacts-header">
        <h1>Leverantörskontakter</h1>
        <p>Här kan du hitta kontaktuppgifter till leverantörer och partners.</p>
      </div>

      <input
        type="text"
        placeholder="Sök kontakt"
        data-testid="contacts-search-input"
        className="contacts-search-input"
      />

      <div className="contacts-grid">
        {contacts.map((contact) => (
          <div key={contact.id} className="contact-card">
            <div className="contact-top">
              <div className="contact-avatar">{contact.name.charAt(0)}</div>
              <div>
                <h2>{contact.name}</h2>
                <p className="contact-role">{contact.role}</p>
              </div>
            </div>

            <div className="contact-info">
              <p><strong>Företag:</strong> {contact.company}</p>
              <p>
                <strong>E-post:</strong>{" "}
                <a
                  href={`mailto:${contact.email}`}
                  data-testid={`contact-email-link-${contact.id}`}
                >
                  {contact.email}
                </a>
              </p>
              <p>
                <strong>Telefon:</strong>{" "}
                <a
                  href={`tel:${contact.phone}`}
                  data-testid={`contact-phone-link-${contact.id}`}
                >
                  {contact.phone}
                </a>
              </p>
            </div>

            <button
              data-testid={`contact-button-${contact.id}`}
              className="contact-button"
            >
              Visa mer
            </button>
          </div>
        ))}
      </div>
      <footer className="contacts-footer">
  <div className="footer-column">
    <h3>KUNDSUPPORT</h3>
    <ul>
      <li>Kontakta oss</li>
      <li>Köpvillkor</li>
      <li>Garantier</li>
      <li>Delbetalning</li>
      <li>FAQ - Vanliga frågor</li>
      <li>Integritetspolicy</li>
      <li>Monteringsguide för cykel</li>
      <li>Skötselråd för cykel</li>
      <li>Öppet köp</li>
    </ul>
  </div>

  <div className="footer-column">
    <h3>OM OSS</h3>
    <ul>
      <li>Om oss</li>
      <li>Butiker</li>
      <li>Bli franchisetagare</li>
      <li>Förmånscykel</li>
      <li>Jobba hos oss</li>
      <li>Verkstad</li>
      <li>Verkstadsprislista</li>
      <li>Sponsring</li>
    </ul>
  </div>

  <div className="footer-column">
    <h3>HOS OSS</h3>
    <ul>
      <li>Alltid hos oss</li>
      <li>Ett års fri service</li>
      <li>Företagstjänster</li>
      <li>Inbytesgaranti på barncyklar</li>
      <li>Monterat och körklart</li>
      <li>Servicepaket för cykel</li>
      <li>Självriskeliminering</li>
      <li>Sportson Patrol - cykelservice där du är</li>
    </ul>
  </div>
</footer>
    </div>
    
  );
};

export default Contacts;