import AppDataSource from '../db/AppDataSource';
import { User } from '../db/Entity/User.entity';
import type UserInterface from '../types/UserInterface';
import { hashPassword, verifyPassword } from '../utils/password';

export class UserService {
  private get repository(): ReturnType<typeof AppDataSource.getRepository> {
    if (!AppDataSource.isInitialized) {
      throw new Error('AppDataSource is not initialized');
    }

    return AppDataSource.getRepository(User);
  }

  async findByEmail(email: string): Promise<User | null> {
    return await this.repository.findOne({ where: { email } }) as User;
  }

  async createUser(userData: Omit<UserInterface, 'id' | 'password'> & { password: string }): Promise<User> {
    const user = this.repository.create({
      ...userData,
      password: hashPassword(userData.password),
    });

    return await this.repository.save(user) as User;
  }

  async verifyCredentials(email: string, password: string): Promise<User | null> {
    const user = await this.findByEmail(email);

    if (!user) {
      return null;
    }

    const isValid = verifyPassword(password, user.password);

    if (!isValid) {
      return null;
    }

    return user;
  }
}

export const userService = new UserService();