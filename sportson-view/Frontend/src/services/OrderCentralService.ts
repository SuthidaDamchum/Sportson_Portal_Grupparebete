import axios from "axios";
import type { Order } from "../types/OrderType";
import { authService } from "./AuthService";

export const getOrder = async (orderNo: string): Promise<Order> => {
  try {
    const token = authService.getToken();

    const response = await axios.get<Order[]>(`/api/Order/${orderNo}`, {
      headers: token ? { Authorization: `Bearer ${token}` } : {},
    });

    return response.data[0];
  } catch (error) {
    if (axios.isAxiosError(error) && error.response?.status === 401) {
      console.error(
        "Användaren är inte inloggad eller token är ogiltig!",
        error,
      );
      throw new Error("Du måste vara inloggad för att hämta order.");
    }

    console.error("Kunde inte nå Order API:", error);
    throw new Error(
      "Kunde inte hämta order-data. Kontrollera att servern är igång.",
    );
  }
};
