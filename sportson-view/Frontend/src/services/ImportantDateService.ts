import axios from "axios";
import type { ImportantDateDto } from "../types/ImportantDateType.ts";
import { authService } from "./AuthService";

export type ImportantDateResponse = { importantDates: ImportantDateDto[] };

// Hämtar alla viktiga datum som ska visas i kalendern på startsidan, med token auth för att säkerställa att endast inloggade användare kan se datumen.
export const getImportantDate = async (): Promise<ImportantDateDto[]> => {
  try {
    const token = authService.getToken();

    const response = await axios.get<ImportantDateResponse>(
      "/api/ImportantDate/All",
      {
        headers: token ? { Authorization: `Bearer ${token}` } : {},
      }
    );

    return response.data.importantDates || [];
  } catch (error) {
    if (axios.isAxiosError(error) && error.response?.status === 401) {
      console.error("Användaren är inte inloggad eller token är ogiltig!", error);
      throw new Error("Du måste vara inloggad för att hämta viktiga datum.");
    }

    console.error("Kunde inte nå API:", error);
    throw new Error("Kunde inte hämta data. Kontrollera att servern är igång.");
  }
};