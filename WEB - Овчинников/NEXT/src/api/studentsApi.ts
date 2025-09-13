import StudentInterface from '@/types/StudentsInterface';

export const getStudentsApi = async (): Promise<StudentInterface[]> => {

  const response = await fetch('http://localhost:3000/api/students');
  const students = await response.json();

  return students;
};