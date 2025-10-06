import type StudentInterface from '@/types/StudentInterface';

export const getStudentsApi = async (): Promise<StudentInterface[]> => {

  const response = await fetch('http://localhost:3001/api/students');
  const students = await response.json();

  return students;
};

export const deleteStudentApi = async (studentId: number): Promise<number> => {
  await fetch(`http://localhost:3001/api/students/${studentId}`, {
    method: 'DELETE',
  });
  
  return studentId;
};

export const addStudentApi = async (studentData: Partial<StudentInterface>): Promise<StudentInterface> => {
  const response = await fetch('http://localhost:3001/api/students', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(studentData),
  });

  const newStudent: StudentInterface = await response.json();
  return newStudent;
};