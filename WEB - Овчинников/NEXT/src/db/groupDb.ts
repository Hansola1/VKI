import sqlite3 from 'sqlite3';
import GroupInterface from '@/types/GroupInterface';
import StudentInterface from '@/types/StudentsInterface';

sqlite3.verbose();
const db = new sqlite3.Database('./db/vki-web.db');

// export const getGroupsDb = (): GroupInterface[] => {

//   db.serialize(() => {

//     const groups = db.each('SELECT * FROM class', (err, row) => {
//       if (err) {
//         console.error(err);
//       } else {
//         console.log(row);
//       }
//     });

//   });
//   return groups; db.each() — асинхронный — он выполняется позже, а return groups — сразу.

//   // Наша временная заглушка пока-пока.
//   // const groups: GroupInterface[] = [
//   //   {
//   //     name: '2207 д2',
//   //   },
//   //   {
//   //     name: '2207 д2',
//   //   }
//   // ];
// };

export const getGroupsDb = (): Promise<GroupInterface[]> => {
  return new Promise((resolve, reject) => {
    const groups: GroupInterface[] = [];

    db.serialize(() => {
      db.each(
        'SELECT * FROM class',
        (err, row) => {
          if (err) {
            console.error('Ошибка при чтении из БД:', err);
            reject(err);
            return;
          }
          groups.push(row as GroupInterface);
        },

        (err, count) => {
          if (err) {
            reject(err);
          } else {
            console.log(`Получено ${count} записей`);
            resolve(groups);
          }
        }
      );
    });
  });
};

// export const getStudentsNoDb = (): StudentInterface[] => {

//   const students: StudentInterface[] = [
//     { name: 'Анастасия Бородина'},
//     { name: 'Настя Бородина'}
//   ];

//   return students;
// };
