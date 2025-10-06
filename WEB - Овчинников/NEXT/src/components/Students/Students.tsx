'use client';

import useStudents from '@/hooks/useStudents';
import { useQuery } from '@tanstack/react-query';
import { getStudentsApi } from '@/api/studentsApi';
import StudentInterface from '@/types/StudentsInterface';
import Student from './Student/Student';

const Students = () => {
  const { data: students, isLoading, error } = useQuery({
    queryKey: ['students'],
    queryFn: getStudentsApi,
  });
  const { deleteStudentMutate } = useStudents();

  const onDeleteHandler = (studentId: number): void => {
    if (confirm('Удалить студента?')) {
      deleteStudentMutate(studentId);
    }
  };

  if (isLoading) {
    return <div>Загрузка студентов...</div>;
  }

  if (error) {
    return <div>Ошибка при загрузке студентов: {error.message}</div>;
  }

  return (
    <div>
      <h1>Список студентов</h1>
      {students && students.length > 0 ? (
        <ul>
          {students.map((student: StudentInterface) => (
            <li key={student.id}>
              <Student
                student={student}
                onDelete={onDeleteHandler}
              />
            </li>
          ))}
        </ul>
      ) : (
        <p>Студенты не найдены</p>
      )}
    </div>
  );
};

export default Students;