import { dehydrate } from '@tanstack/react-query';
import TanStackQuery from '@/containers/TanStackQuery';
import queryClient from '@/api/reactQueryClient';
import Header from '@/components/layout/Header/Header';
import Footer from '@/components/layout/Footer/Footer';
import Main from '@/components/layout/Main/Main';
import Groups from '@/components/Groups/Groups';

import { getGroupsApi } from '@/api/groupsApi';
import GroupInterface from '@/types/GroupInterface';

import type { Metadata } from 'next';

export const metadata: Metadata = {
  title: 'Группы - Вэб разработка ВКИ',
  description: 'Список учебных групп',
};

const GroupsPage = async () => {
  await queryClient.prefetchQuery({
    queryKey: ['groups'],
    queryFn: getGroupsApi,
  });

  const state = dehydrate(queryClient, { shouldDehydrateQuery: () => true });

  return (
    <TanStackQuery state={state}>
      <html lang="ru">
        <body>
          <Header />
          <Main>
            <Groups />
          </Main>
          <Footer />
        </body>
      </html>
    </TanStackQuery>
  );
};

export default GroupsPage;