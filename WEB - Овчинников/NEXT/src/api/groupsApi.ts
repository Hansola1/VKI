import { getGroupsDb } from '@/db/groupDb';
import GroupInterface from '@/types/GroupInterface';

export const getGroupsApi = async (): Promise<GroupInterface[]> => {

  /* TODO: groupsApi должен возвращать данные через апи,
    не должно быть обращение в БД напрямую
  */
  //const groups = getGroupsDb();

  /* TODO: реализовать получение данных через апи
   http://localhost:3000/api/groups используя fetch
   */
  const response = await fetch('http://localhost:3000/api/groups');
  const groups = await response.json();

  return groups;
};