import { NavLink } from "react-router";
import "./Header.css";

import { routePaths } from "../../services/RouteService";
import sportssonLogo from "../../assets/logos/SportsonLogo.png";

const Header = () => {
  return (
    <header className="header">
      <nav className="header-nav" id="header-navigation">
        <div>
          <NavLink to={routePaths.home} id="header-home-link">
            <img src={sportssonLogo} className="logo" alt="Sportson logo" />
            <span>Portalen</span>
          </NavLink>

          <div>
            <button type="button" className="store-button" id="header-store-button">
              <span>Min butik</span>
              <span>Göteborg</span>
            </button>

            <ul role="menu" id="header-user-menu">
              <li>
                <button type="button" role="menuitem" id="header-logout-button">
                  Logga ut
                </button>
              </li>
            </ul>
          </div>
        </div>

        <ul className="nav-links">
          <li>
            <NavLink to={routePaths.news} id="header-news-link">
              Nyheter
            </NavLink>
          </li>
          <li>
            <NavLink to={routePaths.manuals} id="header-manuals-link">
              Manualer
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