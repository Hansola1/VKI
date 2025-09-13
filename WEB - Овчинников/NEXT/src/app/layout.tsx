import { dehydrate } from '@tanstack/react-query';

import TanStackQuery from '@/containers/TanStackQuery';
import queryClient from '@/api/reactQueryClient';
import Header from '@/components/layout/Header/Header';
import Footer from '@/components/layout/Footer/Footer';
import Main from '@/components/layout/Main/Main';

import { getGroupsApi } from '@/api/groupsApi';
import GroupInterface from '@/types/GroupInterface';

import { getStudentsApi } from '@/api/studentsApi';
import StudentsInterface from '@/types/StudentsInterface';


import type { Metadata } from 'next';

import '@/styles/globals.scss';

export const metadata: Metadata = {
  title: 'Вэб разработка ВКИ - Next.js шаблон',
  description: 'Шаблон для веб-разработки с использованием Next.js, React Hook Form, Yup, SCSS, Eslint, TanStack Query (React Query)',
};

const RootLayout = async ({ children }: Readonly<{children: React.ReactNode}>) => {  
  let groups: GroupInterface[];
  let students: StudentsInterface[];

  // выполняется на сервере - загрузка групп
  await queryClient.prefetchQuery({
    queryKey: ['groups'], 
    queryFn: async () => {
      groups = await getGroupsApi();
      console.log('Groups', groups);
      return groups;
    },
  });

  await queryClient.prefetchQuery({
    queryKey: ['students'], 
    queryFn: async () => {
      students = await getStudentsApi();
      console.log('Students', students);
      return students;
    },
  });
  
  const state = dehydrate(queryClient, { shouldDehydrateQuery: () => true });

  return (
    <TanStackQuery state={state}>
      <html lang="ru">
        <body>
          <Header />
          <Main>
            <>{children}</>
          </Main>
          <Footer />
        </body>
      </html>
    </TanStackQuery>
  );
};

export default RootLayout;
