import type StudentInterface from '@/types/StudentInterface';

export const getStudentsApi = async (): Promise<StudentInterface[]> => {

  const response = await fetch('http://localhost:3000/api/students');
  const students = await response.json();

  return students;
};

export const deleteStudentApi = async (studentId: number): Promise<number> => {
  await fetch(`http://localhost:3000/api/students/${studentId}`, {
    method: 'DELETE',
  });
  
  return studentId;
};