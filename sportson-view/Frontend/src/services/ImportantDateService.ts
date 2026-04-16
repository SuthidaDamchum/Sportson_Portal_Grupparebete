import axios from "axios";
import type { ImportantDateDto } from "../types/ImportantDateType.ts";

export type ImportantDateResponse = { importantDates: ImportantDateDto[] };

export const getImportantDate = async (): Promise<ImportantDateDto[]> => {
  try {
    const response = await axios.get<ImportantDateResponse>(
      "http://localhost:5178/api/ImportantDate",
    );

    return response.data.importantDates || [];
  } catch (error) {
    console.error("Kunde inte nå API:", error);

    throw new Error("Kunde inte hämta data. Kontrollera att servern är igång.");
  }
};
