import "./ContactsPage.css";

const contacts = [
  {
    id: 1,
    name: "Anna Svensson",
    role: "Leverantörskontakt",
    company: "Shimano",
    email: "anna.svensson@shimano.se",
    phone: "070-123 45 67",
  },
  {
    id: 2,
    name: "Erik Johansson",
    role: "Säljkontakt",
    company: "Garmin",
    email: "erik.johansson@garmin.se",
    phone: "070-987 65 43",
  },
  {
    id: 3,
    name: "Maria Lindström",
    role: "Regionansvarig",
    company: "Trek Bicycle",
    email: "maria.lindstrom@trekbikes.com",
    phone: "073-456 78 90",
  },
  {
    id: 4,
    name: "Jonas Bergqvist",
    role: "Teknisk support",
    company: "SRAM",
    email: "jonas.bergqvist@sram.com",
    phone: "076-234 56 78",
  },
  {
    id: 5,
    name: "Sofia Karlsson",
    role: "Kontoansvarig",
    company: "Specialized",
    email: "sofia.karlsson@specialized.com",
    phone: "070-345 67 89",
  },
  {
    id: 6,
    name: "Mikael Strand",
    role: "Logistikansvarig",
    company: "DHL Sweden",
    email: "mikael.strand@dhl.se",
    phone: "073-567 89 01",
  },
  {
    id: 7,
    name: "Lena Holm",
    role: "Inköpskontakt",
    company: "Thule Group",
    email: "lena.holm@thule.com",
    phone: "070-678 90 12",
  },
  {
    id: 8,
    name: "Peter Engström",
    role: "Säljrepresentant",
    company: "Continental Tyres",
    email: "peter.engstrom@continental.com",
    phone: "076-789 01 23",
  },
  {
    id: 9,
    name: "Karin Nilsson",
    role: "Partnerkontakt",
    company: "Cykelfrämjandet",
    email: "karin.nilsson@cykelframjandet.se",
    phone: "073-890 12 34",
  },
  {
    id: 10,
    name: "Anders Magnusson",
    role: "Kontoansvarig",
    company: "Bontrager",
    email: "anders.magnusson@bontrager.com",
    phone: "070-901 23 45",
  },
  {
    id: 11,
    name: "Helena Björk",
    role: "Marknadskontakt",
    company: "Maxxis Tires",
    email: "helena.bjork@maxxis.com",
    phone: "076-012 34 56",
  },
  {
    id: 12,
    name: "David Lundgren",
    role: "Teknisk rådgivare",
    company: "Bosch eBike Systems",
    email: "david.lundgren@bosch-ebike.com",
    phone: "073-123 45 67",
  },
  {
    id: 13,
    name: "Camilla Rydén",
    role: "Säljkontakt",
    company: "POC Sports",
    email: "camilla.ryden@pocsports.com",
    phone: "070-234 56 78",
  },
  {
    id: 14,
    name: "Fredrik Åberg",
    role: "Leverantörskontakt",
    company: "Michelin",
    email: "fredrik.aberg@michelin.com",
    phone: "076-345 67 89",
  },
  {
    id: 15,
    name: "Therese Sandström",
    role: "Partneransvarig",
    company: "Svenska Cykelförbundet",
    email: "therese.sandstrom@scf.se",
    phone: "073-456 78 90",
  },
];

const Contacts = () => {
  return (
    <div className="contacts-page">
      <div className="contacts-header">
        <h1>Leverantörskontakter</h1>
        <p>Här kan du hitta kontaktuppgifter till leverantörer och partners.</p>
      </div>

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
              <p>
                <strong>Företag:</strong> {contact.company}
              </p>
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
          <h3>OM OSS</h3>
          <ul>
            <li>Butiker</li>
            <li>Förmånscykel</li>
            <li>Verkstad</li>
            <li>Verkstadsprislista</li>
          </ul>
        </div>
      </footer>
    </div>
  );
};

export default Contacts;
