import "./App.css";
import { Route, Routes } from "react-router";
import { routePaths } from "./services/RouteService";
import Header from "./components/Header/Header";
import Home from "./pages/Home";
import ArticlePage from "./pages/ArticlePage";
import ManualsPage from "./pages/ManualsPage";
import OrderCentralPage from "./pages/OrderCentralPage";
import SupportPage from "./pages/SupportPage";
import Contacts from "./pages/ContactsPage";
import LoginPage from "./pages/LoginPage";
import ProtectedRoute from "./pages/ProtectedRoute";

function App() {
  return (
    <>
      <Header />
      <Routes>
        <Route path={routePaths.login} element={<LoginPage />}></Route>{" "}
        {/* Alla andra routes kräver inloggning */}
        <Route
          path={routePaths.home}
          element={
            <ProtectedRoute>
              <Home />
            </ProtectedRoute>
          }
        />
        <Route
          path={routePaths.news}
          element={
            <ProtectedRoute>
              <ArticlePage />
            </ProtectedRoute>
          }
        />
        <Route
          path={routePaths.manuals}
          element={
            <ProtectedRoute>
              <ManualsPage />
            </ProtectedRoute>
          }
        />
        <Route
          path={routePaths.orderCentral}
          element={
            <ProtectedRoute>
              <OrderCentralPage />
            </ProtectedRoute>
          }
        />
        <Route
          path={routePaths.SupportPage}
          element={
            <ProtectedRoute>
              <SupportPage />
            </ProtectedRoute>
          }
        />
        <Route
          path={routePaths.contacts}
          element={
            <ProtectedRoute>
              <Contacts />
            </ProtectedRoute>
          }
        />
      </Routes>
    </>
  );
}

export default App;
