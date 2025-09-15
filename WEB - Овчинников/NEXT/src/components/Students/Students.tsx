'use client';

import { useQuery } from '@tanstack/react-query';
import { getStudentsApi } from '@/api/studentsApi';
import StudentInterface from '@/types/StudentsInterface';

const Students = () => {
  const { data: students, isLoading, error } = useQuery({
    queryKey: ['students'],
    queryFn: getStudentsApi,
  });

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
          {students.map((student: StudentInterface, index: number) => (
            <li key={index}>{student.name}</li>
          ))}
        </ul>
      ) : (
        <p>Студенты не найдены</p>
      )}
    </div>
  );
};

export default Students;