import { getStudentsDb } from '@/db/studentDb';

export async function GET() {

  const students = await getStudentsDb(); 

  return new Response(JSON.stringify(students), {
    headers: {
      'Content-Type': 'application/json'
    },
  });
};

