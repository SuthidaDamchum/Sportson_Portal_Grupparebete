import { NavLink } from "react-router";
import "./Header.css";
import { useUser } from "../../context/UserContext";
import { routePaths } from "../../services/RouteService";
import sportssonLogo from "../../assets/logos/SportsonLogo.png";
import { authService } from "../../services/AuthService";

const Header = () => {
  const capitalize = (str: string) =>
    str[0].toLocaleUpperCase("sv-SE") + str.slice(1);

  const { user, setUser } = useUser();

  const handleLogout = async () => {
    authService.logout();
    setUser(null);
    location.reload(); 
  };

  return (
    <header className="header">
      <nav className="header-nav" id="header-navigation">
        <div>
          <NavLink to={routePaths.home} id="header-home-link">
            <img src={sportssonLogo} className="logo" alt="Sportson logo" />
            <span>Portalen</span>
          </NavLink>

          <div>
            <div className="store-button" id="header-store-button">
              {!user ? (
                <p>Ej inloggad</p>
              ) : (
                <>
                  <h2>{capitalize(user.username)}</h2>
                  <h3>Butik: {user.store}</h3>
                  <button onClick={handleLogout} className="logout-button">
                    Logga ut
                  </button>
                </>
              )}
            </div>
          </div>
        </div>

        <ul className="nav-links">
          <li>
            <NavLink to={routePaths.login}>Login</NavLink>
          </li>
          <li>
            <NavLink to={routePaths.news} id="header-news-link">
              Nyheter
            </NavLink>
          </li>
          <li>
            <NavLink to={routePaths.manuals} id="header-manuals-link">
              Butiksservice
            </NavLink>
          </li>
          <li>
            <NavLink to={routePaths.orderCentral} id="header-ordercentral-link">
              Ordercentral
            </NavLink>
          </li>
          <li>
            <NavLink to={routePaths.SupportPage} id="header-support-link">
              Supportärenden
            </NavLink>
          </li>
          <li>
            <NavLink to={routePaths.contacts} id="header-contacts-link">
              Kontakter
            </NavLink>
          </li>
        </ul>
      </nav>
    </header>
  );
};

export default Header;
