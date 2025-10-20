import { getStudentsDb } from '@/db/studentDb';
import { addRandomStudentsDb } from '@/db/studentDb';
import { addStudentDb } from '@/db/studentDb';
import { NextRequest, NextResponse } from 'next/server'; // import { type NextApiRequest } from 'next/types'; 

export async function GET() {

  const students = await getStudentsDb(); 

  return new Response(JSON.stringify(students), {
    headers: {
      'Content-Type': 'application/json'
    },
  });
};

export async function POST(req: NextRequest): Promise<NextResponse> 
{
  const student = await req.json(); 
  const newStudent = await addStudentDb(student);

  console.log(newStudent);
  return NextResponse.json(newStudent); 
}