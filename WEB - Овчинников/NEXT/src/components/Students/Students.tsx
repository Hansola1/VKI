import { dehydrate } from '@tanstack/react-query';
import TanStackQuery from '@/containers/TanStackQuery';
import queryClient from '@/api/reactQueryClient';
import Header from '@/components/layout/Header/Header';
import Footer from '@/components/layout/Footer/Footer';
import Main from '@/components/layout/Main/Main';
import Students from '@/components/Students/Students';

import { getStudentsApi } from '@/api/studentsApi';
import StudentsInterface from '@/types/StudentsInterface';

import type { Metadata } from 'next';

export const metadata: Metadata = {
  title: 'Студенты - Вэб разработка ВКИ',
  description: 'Список студентов',
};

const StudentsPage = async () => {

  await queryClient.prefetchQuery({
    queryKey: ['students'],
    queryFn: getStudentsApi,
  });

  const state = dehydrate(queryClient, { shouldDehydrateQuery: () => true });

  return (
    <TanStackQuery state={state}>
      <html lang="ru">
        <body>
          <Header />
          <Main>
            <Students />
          </Main>
          <Footer />
        </body>
      </html>
    </TanStackQuery>
  );
};

export default StudentsPage;