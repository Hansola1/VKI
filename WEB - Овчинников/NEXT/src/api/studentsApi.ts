import type StudentInterface from '../types/StudentsInterface';
const URL = process.env.NEXT_PUBLIC_API;

export const getStudentsApi = async (): Promise<StudentInterface[]> => {

  const response = await fetch(`${URL}/students?withGroup=true`);
  const students = await response.json();

  return students;
};

export const deleteStudentApi = async (studentId: number): Promise<number> => {
  console.log('deleteStudentApi', studentId);
  debugger;

  try{ 
    await fetch(`${URL}/students/${studentId}`, {
      method: 'DELETE',
    });
  
    console.log('deleteStudentApi OK', studentId);
    debugger;
    return studentId;
  }
  catch
  {
    return -1;
  }

};

export const addStudentApi = async (studentData: Partial<StudentInterface>): Promise<StudentInterface> => {
  const response = await fetch(`${URL}/students`, { 
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(studentData),
  }); // //н9-11

  return response.json();
};