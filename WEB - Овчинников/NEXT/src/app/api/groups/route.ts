import { NextResponse, NextRequest } from 'next/server';
import { getGroupsDb } from '../../../db/groupDb'; 

export async function GET(request: NextRequest) {
  try 
  {
    const { searchParams } = new URL(request.url);
    const withStudents = searchParams.get('withStudents') === 'true';

    const groups = await getGroupsDb(withStudents);
    return NextResponse.json(groups, { status: 200 });
  }
  catch (error)
  {
    console.error('Ошибка в API /groups:', error);
    
    return NextResponse.json(
      { error: 'Не удалось загрузить группы' },
      { status: 500 }
    );
  }
}