import {type SupportRequest } from "../types/SupportType";
const API_URL = '/api';

export const supportService = {
  sendSupportMessage: async (request: SupportRequest) => {
    const response = await fetch(`${API_URL}/support/send`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(request),
    });

    if (!response.ok) {
      throw new Error('Failed to send support message');
    }

    return await response.json();
  },
};