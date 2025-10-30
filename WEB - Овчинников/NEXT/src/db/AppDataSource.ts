import 'reflect-metadata';
import { DataSource } from 'typeorm';
import { Group } from './Entity/Group.entity';
import { Student } from './Entity/Student.entity';

const AppDataSource = new DataSource({
  type: 'sqlite',
  database: process.env.DB ?? './db/vki-web.db', // Path to your SQLite database file
  entities: [Group, Student],
  synchronize: true, // Auto-create schema on startup (use with caution in production)
  logging: false,
});


AppDataSource.initialize()
  .then(() => {
    console.log('Норм!');
    // You can now interact with your entities
  })
  .catch((err) => {
    console.error('Не норм', err);
  });

export default AppDataSource;