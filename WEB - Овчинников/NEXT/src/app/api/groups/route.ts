import { NextResponse } from 'next/server';
import { getGroupsDb } from '../../../db/groupDb'; 

export async function GET() {
  try 
  {
    const groups = await getGroupsDb();
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