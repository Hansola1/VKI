import { deleteStudentDb } from '@/db/studentDb';
import { type NextApiRequest } from 'next/types';

interface Params {
  params: { id: number };
}

export async function DELETE(req: NextApiRequest, { params }: Params): Promise<Response> {  
  const p = await params;
  const studentId = await p.id;

  const deletedStudentId = await deleteStudentDb(studentId);

  return new Response(JSON.stringify({ deletedStudentId }), {
    headers: {
      'Content-Type': 'application/json',
    },
  });
};
