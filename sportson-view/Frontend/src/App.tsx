import "./App.css";

import { Route, Routes } from "react-router";
import { routePaths } from "./services/RouteService";
import Header from "./components/Header/Header";
import Home from "./pages/Home";
import NewsPage from "./pages/NewsPage";
import ManualsPage from "./pages/ManualsPage";
import OrderCentralPage from "./pages/OrderCentralPage";
import SupportPage from "./pages/SupportPage";

function App() {
  return (
    <>
      <Header />
      <Routes>
        <Route path={routePaths.home} element={<Home />}></Route>
        <Route path={routePaths.news} element={<NewsPage />}></Route>
        <Route path={routePaths.manuals} element={<ManualsPage />}></Route>
        <Route
          path={routePaths.orderCentral}
          element={<OrderCentralPage />}
        ></Route>
        <Route path={routePaths.SupportPage} element={<SupportPage />}></Route>
        <Route path={routePaths.contacts} element={<SupportPage />}></Route>
      </Routes>
    </>
  );
}

export default App;
