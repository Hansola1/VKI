'use client';

import { useParams } from 'next/navigation';
import { useQuery } from '@tanstack/react-query';
import { getStudentsApi } from '../../../api/studentsApi';
import BackButton from '../../../components/BackButton';
import StudentDetails from '../../../components/Students/Student/Student';

const StudentPage = () => {
  const params = useParams();
  const id = params.id as string;

  const { data: students, isLoading, error } = useQuery({
    queryKey: ['students'],
    queryFn: getStudentsApi,
  });

  if (isLoading) return <div>Загрузка...</div>;
  if (error) return <div>Ошибка: {(error as Error).message}</div>;

  if (!students || !id) return <div>Студент не найден</div>;

  const student = students.find((s) => s.id === Number(id));
  if (!student) return <div>Студент с ID {id} не найден</div>;

  return (
    <div>
      <BackButton href="/students" label="Назад (к списку студентов)" />
      <StudentDetails student={student} />
    </div>
  );
};

export default StudentPage;