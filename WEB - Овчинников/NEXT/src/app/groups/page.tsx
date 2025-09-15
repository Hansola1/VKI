import type { Metadata } from 'next';
import Groups from '@/components/Groups/Groups'

export const metadata: Metadata = {
  title: 'Студенты - Вэб разработка ВКИ',
  description: 'Список групп',
};

const GroupsPage = () => {
  return <Groups />;
};

export default GroupsPage;
