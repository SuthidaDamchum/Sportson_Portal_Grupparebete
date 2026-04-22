import axios from "axios";
import type { UserType } from "../types/UserType";
import { authService } from "./AuthService";

export const getUserData = async (): Promise<UserType> => {
  try {
    const token = authService.getToken();
    const headers = token ? { Authorization: `Bearer ${token}` } : {};

    const response = await axios.get<UserType>("/api/Users/me", {
      headers,
    });

    return response.data;
  } catch (error) {
    console.error("Kunde inte hämta användardata:", error);
    throw new Error("Kunde inte hämta användardata.");
  }
};