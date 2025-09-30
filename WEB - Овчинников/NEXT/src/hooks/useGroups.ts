
import { useQuery } from '@tanstack/react-query';
import { getGroupsApi } from '@/api/groupsApi';
import type GroupInterface from '@/types/GroupInterface';

interface GroupsHookInterface {
  groups: GroupInterface[];
}

const useGroups = (): GroupsHookInterface => {
  // const queryClient = useQueryClient();

const { data } = useQuery({
  queryKey: ['groups'],
  queryFn: () => getGroupsApi(),
  // enabled: раньше было фалсе
});
  return {
    groups: data ?? [],
  };
};

export default useGroups;