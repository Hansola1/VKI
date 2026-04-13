import { dehydrate } from '@tanstack/react-query';

import TanStackQuery from '../containers/TanStackQuery';
import queryClient from '../api/reactQueryClient';
import { getGroupsApi } from '../api/groupsApi';
import type GroupInterface from '../types/GroupInterface';
import Header from '../components/layout/Header/Header';
import Footer from '../components/layout/Footer/Footer';
import Main from '../components/layout/Main/Main';
import { cookies } from 'next/headers';

import type { Metadata } from 'next';

import '@/styles/globals.scss';
import { META_DESCRIPTION, META_TITLE } from '../constants/meta';
import type StudentInterface from '../types/StudentsInterface';
import { getStudentsApi } from '../api/studentsApi';
// import { verifyAccessToken } from '../utils/jwt';
// import UserInterface from '@/types/UserInterface';

export const metadata: Metadata = {
  title: META_TITLE,
  description: META_DESCRIPTION,
};

const RootLayout = async ({ children }: Readonly<{ children: React.ReactNode }>): Promise<React.ReactElement> => {

  // выполняется на сервере - загрузка групп
  let groups: GroupInterface[];
  await queryClient.prefetchQuery({
    queryKey: ['groups'],
    queryFn: async () => {
      groups = await getGroupsApi();
      console.log('Groups', groups);
      return groups;
    },
  });

  // выполняется на сервере - загрузка студентов
  let students: StudentInterface[];
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

// const RootLayout = async ({ children }: Readonly<{ children: React.ReactNode }>): Promise<React.ReactElement> => {
//   const cookieStore = await cookies();

//   const accessToken = cookieStore.get('accessToken')?.value;

//   const userFromServer = verifyAccessToken(accessToken);

//   // выполняется на сервере - загрузка студентов
//   await queryClient.prefetchQuery({
//     queryKey: ['students'],
//     queryFn: getStudentsApi,
//   });

//   // выполняется на сервере - загрузка групп
//   await queryClient.prefetchQuery({
//     queryKey: ['groups'],
//     queryFn: getGroupsApi,
//   });

//   // дегидрация состояния
//   const state = dehydrate(queryClient, { shouldDehydrateQuery: () => true });

//   return (
//     <TanStackQuery state={state}>
//       <html lang="ru">
//         <body>
//           {/* eslint-disable-next-line @typescript-eslint/ban-ts-comment */}
//           <Header userFromServer={userFromServer} />
//           <Main>
//             <>{children}</>
//           </Main>
//           <Footer />
//         </body>
//       </html>
//     </TanStackQuery>
//   );
// };


export default RootLayout;
