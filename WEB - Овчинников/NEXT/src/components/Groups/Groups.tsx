'use client';

import { useQuery } from '@tanstack/react-query';
import { getGroupsApi } from '@/api/groupsApi';
import GroupInterface from '@/types/GroupInterface';

const Groups = () => {
  const { data: groups, isLoading, error } = useQuery({
    queryKey: ['groups'],
    queryFn: getGroupsApi,
  });

  if (isLoading) {
    return <div>Загрузка групп...</div>;
  }

  if (error) {
    return <div>Ошибка при загрузке групп: {error.message}</div>;
  }

  return (
    <div>
      <h1>Список групп</h1>
      {groups && groups.length > 0 ? (
        <ul>
          {groups.map((group: GroupInterface, index: number) => (
            <li key={index}>{group.name}</li>
          ))}
        </ul>
      ) : (
        <p>Группы не найдены</p>
      )}
    </div>
  );
};

export default Groups;