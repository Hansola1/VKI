import type StudentInterface from '@/types/StudentInterface';
const URL = process.env.NEXT_PUBLIC_API;

export const getStudentsApi = async (): Promise<StudentInterface[]> => {

  const response = await fetch(`${URL}/students`);
  const students = await response.json();

  return students;
};

export const deleteStudentApi = async (studentId: number): Promise<number> => {
  await fetch(`${URL}/students/${studentId}`, {
    method: 'DELETE',
  });
  
  return studentId;
};

export const addStudentApi = async (studentData: Partial<StudentInterface>): Promise<StudentInterface> => {
  const response = await fetch(`${URL}/api/students`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(studentData),
  });

  return response.json();
};