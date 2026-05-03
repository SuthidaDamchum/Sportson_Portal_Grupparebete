import React, { useEffect, useState } from "react";
import { Navigate } from "react-router-dom";
import { authService } from "../services/AuthService";
import { getUserData } from "../services/UserService";

const ProtectedRoute = ({ children }: { children: React.ReactNode }) => {
  const [auth, setAuth] = useState<"loading" | "ok" | "fail">(
    authService.isAuthenticated() ? "loading" : "fail",
  );

  useEffect(() => {
    if (auth === "fail") return;
    getUserData()
      .then(() => setAuth("ok"))
      .catch(() => {
        authService.logout();
        setAuth("fail");
      });
  }, []);

  if (auth === "loading") return null;
  if (auth === "fail") return <Navigate to="/login" />;
  return <>{children}</>;
};

export default ProtectedRoute;
