import { getGroupsDb } from '../db/groupDb';
import GroupInterface from '../types/GroupInterface';
const URL = process.env.NEXT_PUBLIC_API;

export const getGroupsApi = async (): Promise<GroupInterface[]> => 
{
  const response = await fetch(`${URL}/groups`);
  const groups = await response.json();

  return groups;
};