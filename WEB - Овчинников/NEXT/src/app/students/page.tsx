import type { Metadata } from 'next';
import Students from '../../components/Students/Students'

export const metadata: Metadata = {
  title: 'Студенты - Вeб разработка ВКИ',
  description: 'Список студентов',
};

const StudentsPage = () => {
  return <Students />;
};

export default StudentsPage;
