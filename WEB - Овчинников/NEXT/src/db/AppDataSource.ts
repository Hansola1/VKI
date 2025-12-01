import 'reflect-metadata';
import { DataSource } from 'typeorm';
import { Group } from './Entity/Group.entity';
import { Student } from './Entity/Student.entity';
import { User } from './Entity/User.entity';

//СТАРОЕ
// const AppDataSource = new DataSource({
//   type: 'sqlite',
//   database: process.env.DB ?? './db/vki-web.db', // Path to your SQLite database file
//   entities: [Group, Student],
//   synchronize: true, // Auto-create schema on startup (use with caution in production)
//   logging: false,
// });


// AppDataSource.initialize()
//   .then(() => {
//     console.log('Норм!');
//     // You can now interact with your entities
//   })
//   .catch((err) => {
//     console.error('Не норм', err);
//   });
//СТАРОЕ


const AppDataSource = new DataSource({
  type: 'sqlite',
  database: process.env.DB ?? './db/vki-web.db', // Path to your SQLite database file
  // synchronize: true, // Auto-create schema on startup (use with caution in production)
  synchronize: process.env.NODE_ENV !== 'production', // Отключаем в production
  migrationsRun: process.env.NODE_ENV === 'production', // Включаем миграции в production
  logging: false,
  entities: [Student, Group, User],
  // namingStrategy: new SnakeNamingStrategy(),
});


export const dbInit = async (): Promise<void> => {
  try {
    if (AppDataSource.isInitialized) {
      console.log('>>> AppDataSource.isInitialized');
      return;
    }
    await AppDataSource.initialize();
    console.log('>>> AppDataSource.initialize');
  }
  catch (error) {
    console.log(error);
  }
};

await dbInit();
export default AppDataSource;