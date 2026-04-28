import './TermsPage.css';

export const PrivacyPage = () => {
  return (
    <main className="privacy-page">
      <section className="privacy-container">
        <h1>Integritetspolicy</h1>
        <h2>Sportson View - Integritetspolicy</h2>
        <p className="updated">Senast uppdaterad: April 2026</p>

        <h3>1. Personuppgiftsansvarig</h3>
        <p>
          Sportson AB är personuppgiftsansvarig för den behandling av
          personuppgifter som sker inom Sportson View.
        </p>

        <h3>2. Vilka uppgifter behandlar vi?</h3>
        <p>
          Vid inloggning skapas en JWT, JSON Web Token, som lagras lokalt i din
          webbläsare via localStorage. Denna token innehåller följande uppgifter:
        </p>

        <ul>
          <li>Användarnamn</li>
          <li>Unikt användar-ID</li>
          <li>Ett slumpmässigt sessions-ID, JTI</li>
        </ul>

        <p>
          Inga känsliga personuppgifter som lösenord, adress eller personnummer
          lagras i token.
        </p>

        <h3>3. Syfte och rättslig grund</h3>
        <p>
          Uppgifterna behandlas för att autentisera dig mot systemet och
          upprätthålla din inloggade session. Behandlingen är nödvändig för att
          tillhandahålla åtkomst till den interna portalen och dess funktioner.
        </p>

        <h3>4. Lagringstid</h3>
        <p>
          Din session är aktiv i 1 timme från inloggningstillfället, varefter
          token automatiskt upphör att gälla och du loggas ut. Token lagras
          enbart lokalt i din webbläsare och skickas till servern vid varje
          begäran för verifiering. Den sparas inte i någon databas på
          serversidan.
        </p>

        <h3>5. Delning av uppgifter</h3>
        <p>
          Vi delar inte uppgifterna i din token med tredje part. Uppgifterna
          används uteslutande för intern autentisering inom Sportson View.
        </p>

        <h3>6. Dina rättigheter</h3>
        <p>
          Du har rätt att begära information om vilka personuppgifter vi
          behandlar om dig, begära rättelse av felaktiga uppgifter samt begära
          att ditt konto raderas. Kontakta din systemadministratör eller ansvarig
          kontaktperson inom Sportson för sådana ärenden.
        </p>

        <h3>7. Kontakt</h3>
        <p>
          Frågor om denna policy riktas till ansvarig administratör eller
          Sportsons dataskyddsansvariga kontaktperson.
        </p>

        <p className="note">
          Obs: Detta är helt exempeltext och inte en giltig juridisk
          dokumentation.
        </p>
      </section>
    </main>
  );
};

const TermsPage = () => {
  return (
    <main className="terms-page">
      <section className="terms-container">
        <h1>Användarvillkor</h1>
        <h2>Sportson View - Användarvillkor</h2>
        <p className="updated">Senast uppdaterad: April 2026</p>

        <h3>1. Om tjänsten</h3>
        <p>
          Sportson View är en intern butiksportal avsedd för behöriga användare
          inom Sportson-organisationen, inklusive butikspersonal,
          administratörer samt godkända tredjepartsleverantörer. Tillgång till
          portalen förutsätter att du har tilldelats ett konto av en
          systemadministratör.
        </p>

        <h3>2. Behörighet och ansvar</h3>
        <p>
          Du ansvarar för att hålla dina inloggningsuppgifter konfidentiella och
          får inte dela ditt konto med andra. Du förbinder dig att endast använda
          portalen för arbetsrelaterade ändamål inom ramen för din roll.
        </p>

        <h3>3. Roller och åtkomst</h3>
        <p>
          Portalen tillämpar rollbaserad åtkomstkontroll. Din behörighet styrs
          av den roll du tilldelats: butikspersonal, administratör eller
          tredjepartsleverantör.
        </p>

        <h3>4. Tredjepartsleverantörer</h3>
        <p>
          Leverantörer som ges tillgång till portalen förbinder sig att följa
          dessa villkor samt eventuella separata avtal som tecknats med
          Sportson.
        </p>

        <h3>5. Immateriella rättigheter</h3>
        <p>
          Allt innehåll i portalen, inklusive data, rapporter och
          systemstruktur, tillhör Sportson eller dess samarbetspartners.
        </p>

        <h3>6. Ändringar</h3>
        <p>
          Sportson förbehåller sig rätten att uppdatera dessa villkor. Fortsatt
          användning av portalen efter publicering av uppdaterade villkor innebär
          att du accepterar de nya villkoren.
        </p>
      </section>
    </main>
  );
};

export default TermsPage;