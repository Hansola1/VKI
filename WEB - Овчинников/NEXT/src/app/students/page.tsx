import type { Metadata } from 'next';
import Students from '@/components/Students/Students'

export const metadata: Metadata = {
  title: 'Студенты - Вэб разработка ВКИ',
  description: 'Список студентов',
};

const StudentsPage = () => {
  return <Students />;
};

export default StudentsPage;
