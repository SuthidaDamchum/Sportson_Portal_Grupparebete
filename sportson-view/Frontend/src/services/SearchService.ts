import axios from "axios";
import type { SearchResult } from "../types/SearchType";
import { authService } from "./AuthService";

/**
 * Hämtar manualer direkt från databasen via API:et.
 * Kräver giltig inloggningstoken. Om anropet misslyckas kastas ett fel
 * för att signalera att systemet inte kan hämta nödvändig data.
 */
export const getSearchResults = async (): Promise<SearchResult[]> => {
  try {
    const token = authService.getToken();

    const response = await axios.get("/api/Manual", {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });

    // Mappa datan från backend-modellen till frontend-typen SearchResult
    // Vi antar här att backend returnerar en lista direkt eller ett objekt med en lista.
    const data = response.data.manuals || response.data;

    return data.map((m: any) => ({
      id: m.id,
      type: m.type,
      title: m.title,
      description: m.description,
      category: m.category,
      URL: m.url, // Säkerställ att 'url' från C# mappas till 'URL'
    }));
  } catch (error) {
    console.error("Kritiskt fel: Kunde inte hämta data från databasen.", error);
    // Vi kastar felet vidare istället för att returnera mockSearchResults.
    // Detta gör att din UI-komponent (ManualsPage) kan visa ett felmeddelande till användaren.
    throw new Error(
      "Systemet kunde inte hämta manualer. Kontrollera din anslutning eller inloggning.",
    );
  }
};
