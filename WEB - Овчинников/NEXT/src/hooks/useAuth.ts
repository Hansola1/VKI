import type UserInterface from '../types/UserInterface';
import { create } from 'zustand';

interface AuthState {
  user: UserInterface | undefined | null;
  setUser: (user: UserInterface | undefined | null) => void;
}

export const useAuth = create<AuthState>(set => ({
  user: undefined,
  setUser: (user): void => set(state => ({ ...state, user })),
}));