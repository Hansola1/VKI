import type GroupInterface from '../../../types/GroupInterface';
import { groupService } from '../../../services/GroupService';

const defaultGroups: GroupInterface[] = [
  {
    id: 1,
    name: 'Group-1',
    // contacts: 'group1@test.test',
  },
  {
    id: 2,
    name: 'Group-2',
    // contacts: 'group2@test.test',
  },
  {
    id: 3,
    name: 'Group-3',
    // contacts: 'group3@test.test',
  },
  {
    id: 4,
    name: 'Group-4',
    // contacts: 'group4@test.test',
  },
];

export async function GET(): Promise<Response> {
  const newGroups: GroupInterface[] = [];
  const existGroups: GroupInterface[] = [];

  await Promise.all(defaultGroups.map(async (group) => {
    const exists: GroupInterface = await groupService.getGroupsById(group.id);
    if (!exists) {
      const newGroup: GroupInterface = await groupService.addGroup(group);
      newGroups.push(newGroup);
    } else {
      existGroups.push(exists);
    }
  }));

  return new Response(JSON.stringify({
    newGroups,
    existGroups,
  }), {
    status: 201,
    headers: {
      'Content-Type': 'application/json',
    },
  });
};

// import { NextResponse, NextRequest } from 'next/server';
// import { getGroupsDb } from '../../../db/groupDb'; 

// export async function GET(request: NextRequest) {
//   try 
//   {
//     const { searchParams } = new URL(request.url);
//     const withStudents = searchParams.get('withStudents') === 'true';

//     const groups = await getGroupsDb(withStudents);
//     return NextResponse.json(groups, { status: 200 });
//   }
//   catch (error)
//   {
//     console.error('Ошибка в API /groups:', error);
    
//     return NextResponse.json(
//       { error: 'Не удалось загрузить группы' },
//       { status: 500 }
//     );
//   }
// }