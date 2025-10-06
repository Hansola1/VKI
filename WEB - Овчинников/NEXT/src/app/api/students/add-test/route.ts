import { addRandomStudentsDb } from '@/db/studentDb';

export async function POST(): Promise<Response> {
  const students = await addRandomStudentsDb();

  return new Response(JSON.stringify(students), {
    headers: {
      'Content-Type': 'application/json',
    },
  });
};
