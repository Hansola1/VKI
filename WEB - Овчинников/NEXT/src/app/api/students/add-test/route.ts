import { addRandomStudentsDb } from '@/db/studentDb';
import { addStudentDb } from '@/db/studentDb';
import { NextRequest, NextResponse } from 'next/server'; // import { type NextApiRequest } from 'next/types'; 

// export async function POST(): Promise<Response> {
//   const students = await addRandomStudentsDb();

//   return new Response(JSON.stringify(students), {
//     headers: {
//       'Content-Type': 'application/json',
//     },
//   });
// };

export async function POST(req: NextRequest): Promise<NextResponse> 
{
  const student = await req.json(); 
  const newStudent = await addStudentDb(student);

  console.log(newStudent);
  return NextResponse.json(newStudent); 
}