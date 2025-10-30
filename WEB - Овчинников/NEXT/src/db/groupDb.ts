import sqlite3 from 'sqlite3';
import { Group } from './Entity/Group.entity';
import AppDataSource from './AppDataSource';
import type GroupInterface from '../types/GroupInterface';

sqlite3.verbose();
const db = new sqlite3.Database('./db/vki-web.db');

const groupRepository = AppDataSource.getRepository(Group);

/**
 * Получение групп
 * @returns  Promise<GroupInterface[]>
 */
export const getGroupsDb = async (): Promise<GroupInterface[]> => {
  return await groupRepository.find();
};

/**
 * Добавление группы
 * @returns  Promise<GroupInterface>
 */
export const addGroupsDb = async (groupFields: Omit<GroupInterface, 'id'>): Promise<GroupInterface> => {
  const group = new Group();
  const newGroup = await groupRepository.save({
    ...group,
    ...groupFields,
  });

  return newGroup;
};

//ВАРИАНТ 2 - OLD

// export const getGroupsDb = (): Promise<GroupInterface[]> => {
//   return new Promise((resolve, reject) => {
//     const groups: GroupInterface[] = [];

//     db.serialize(() => {
//       db.each(
//         'SELECT * FROM class',
//         (err, row) => {
//           if (err) {
//             console.error('Ошибка при чтении из БД:', err);
//             reject(err);
//             return;
//           }
//           groups.push(row as GroupInterface);
//         },

//         (err, count) => {
//           if (err) {
//             reject(err);
//           } else {
//             console.log(`Получено ${count} записей`);
//             resolve(groups);
//           }
//         }
//       );
//     });
//   });
// };

// export const getStudentsNoDb = (): StudentInterface[] => {

//   const students: StudentInterface[] = [
//     { name: 'Анастасия Бородина'},
//     { name: 'Настя Бородина'}
//   ];

//   return students;
// };
