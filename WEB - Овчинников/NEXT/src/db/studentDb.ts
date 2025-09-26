import sqlite3 from 'sqlite3';
import GroupInterface from '@/types/GroupInterface';
import StudentInterface from '@/types/StudentsInterface';

sqlite3.verbose();
const db = new sqlite3.Database('./db/vki-web.db');

export const deleteStudentDb = (id: number): Promise<number> => {
  return new Promise((resolve, reject) => {
    db.serialize(() => {
      db.run(
        'DELETE FROM student WHERE id = ?',
        [id],
        function (err) {
          if (err) {
            console.error('Ошибка при удалении студента:', err);
            reject(err);
            return;
          }

          if (this.changes === 0) {
            reject(new Error(`Студент с ID ${id} не найден`));
            return;
          }

          console.log(`Студент с ID ${id} удалён`);
          resolve(id);
        }
      );
    });
  });
};

export const getStudentsDb = (): Promise<StudentInterface[]> => {
  return new Promise((resolve, reject) => {
    const students: StudentInterface[] = [];

    db.serialize(() => {
      db.each(
        'SELECT * FROM student',
        (err, row) => {
          if (err) {
            console.error('Ошибка при чтении студентов:', err);
            reject(err);
            return;
          }
          students.push(row as StudentInterface);
        },
        (err, count) => {
          if (err) {
            reject(err);
          } else {
            console.log(`Загружено студентов: ${count}`);
            resolve(students);
          }
        }
      );
    });
  });
};
