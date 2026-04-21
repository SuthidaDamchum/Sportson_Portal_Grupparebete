import { NavLink } from "react-router";
import "./Header.css";
import { getUserData } from "../../services/UserService";
import type { UserType } from "../../types/UserType";
import { routePaths } from "../../services/RouteService";
import sportssonLogo from "../../assets/logos/SportsonLogo.png";
import { useEffect, useState } from "react";


const Header = () => {

 const capitalize = (str: string) =>
  str[0].toLocaleUpperCase("sv-SE") + str.slice(1);
const [user, setUser] = useState<UserType | null>(null);
useEffect(() => {
  const fetchUser = async () => {
    try {
      const data = await getUserData();
      setUser(data);
    } catch {
      setUser(null);
    }
  };

  fetchUser();
}, []);

  return (
    <header className="header">
      <nav className="header-nav">
        <div>
          <NavLink to={routePaths.home}>
            <img src={sportssonLogo} className="logo" />
            <span>Portalen</span>
          </NavLink>
          <div>
            <button type="button" className="store-button">
                {!user ? (
                  <p>Ej inloggad</p>
                ) : (
                  <>
                  <h2>{capitalize(user.username)}</h2>
                  <h3>Butik: {user.store}</h3>
                  </>
                )}
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
          {/* test */}
            <NavLink to={routePaths.login}>Login</NavLink>            
          {/* test */}
          </li>

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
