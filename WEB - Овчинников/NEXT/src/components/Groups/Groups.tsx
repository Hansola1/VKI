'use client';

import useGroups from '../../hooks/useGroups';
import type GroupInterface from '../../types/GroupInterface';
import styles from './Groups.module.scss';

const Groups = (): React.ReactElement => {
  const { groups } = useGroups();

   return (
    <div className={styles.Groups}>
      <h1>Список групп</h1>
      {groups && groups.length > 0 ? (
        <ul>
          {groups.map((group: GroupInterface) => (
            <li key={group.id}>
              <strong>{group.name}</strong>

              {group.students && group.students.length > 0 ? (
                <ul style={{ marginTop: '8px', marginLeft: '20px' }}>
                  {group.students.map((student) => (
                    <li key={student.id}>
                      {student.lastName} {student.firstName}
                      {student.middleName && ` ${student.middleName}`}
                    </li>
                  ))}
                </ul>
              ) : (
                <span style={{ color: '#888', marginLeft: '12px' }}>(студентов нет)</span>
              )}
            </li>
          ))}
        </ul>
      ) : (
        <p>Группы не найдены</p>
      )}
    </div>
  );
};

export default Groups;

// 'use client';

// import { useQuery } from '@tanstack/react-query';
// import { getGroupsApi } from '@/api/groupsApi';
// import GroupInterface from '@/types/GroupInterface';

// const Groups = () => {
//   const { data: groups, isLoading, error } = useQuery({
//     queryKey: ['groups'],
//     queryFn: getGroupsApi,
//   });

//   if (isLoading) {
//     return <div>Загрузка групп...</div>;
//   }

//   if (error) {
//     return <div>Ошибка при загрузке групп: {error.message}</div>;
//   }

//   return (
//     <div>
//       <h1>Список групп</h1>
//       {groups && groups.length > 0 ? (
//         <ul>
//           {groups.map((group: GroupInterface, index: number) => (
//             <li key={index}>{group.name}</li>
//           ))}
//         </ul>
//       ) : (
//         <p>Группы не найдены</p>
//       )}
//     </div>
//   );
// };

// export default Groups;