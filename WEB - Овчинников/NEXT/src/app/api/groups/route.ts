import { getGroupsDb } from '@/db/groupDb';

export async function GET() {

  const groups = getGroupsDb();

  return new Response(JSON.stringify(groups), {
    headers: {
      'Content-Type': 'application/json'
    },
  });
};

