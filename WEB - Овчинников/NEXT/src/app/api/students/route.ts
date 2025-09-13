import { getStudentsNoDb } from '@/db/groupDb';

export async function GET() {

  const students = getStudentsNoDb();

  return new Response(JSON.stringify(students), {
    headers: {
      'Content-Type': 'application/json'
    },
  });
};

