import { NavLink } from "react-router";
import "./Header.css";

import { routePaths } from "../../services/RouteService";
import sportssonLogo from "../../assets/logos/SportsonLogo.png";

const Header = () => {
  return (
    <header className="header">
      <nav className="header-nav">
        <div>
          <NavLink to={routePaths.home}>
            <img src={sportssonLogo} alt="Sportsson" className="logo" />
            <span>Portalen</span>
          </NavLink>

          <div>
            <button type="button" className="store-button">
              <span>Min butik</span>
              <span>Göteborg</span>
            </button>

            <ul role="menu">
              <li>
                <button type="button" role="menuitem">
                  Logga ut
                </button>
              </li>
            </ul>
          </div>
        </div>

        <ul className="nav-links">
          <li>
            <NavLink to={routePaths.news}>Nyheter</NavLink>
          </li>
          <li>
            <NavLink to={routePaths.manuals}>Manualer</NavLink>
          </li>
          <li>
            <NavLink to={routePaths.orderCentral}>Ordercentral</NavLink>
          </li>
          <li>
            <NavLink to={routePaths.SupportPage}>Supportärenden</NavLink>
          </li>
          <li>
            <NavLink to={routePaths.contacts}>Kontakter</NavLink>
          </li>
        </ul>
      </nav>
    </header>
  );
};

export default Header;
