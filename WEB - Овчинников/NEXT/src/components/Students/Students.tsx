'use client';

import { useState } from 'react';
import useStudents from '../../hooks/useStudents';
import { useQuery } from '@tanstack/react-query';
import { getStudentsApi } from '../../api/studentsApi';
import StudentInterface from '../../types/StudentsInterface';
import Student from './Student/Student';
import AddStudent from './AddStudent';

const Students = () => {
  const [showAddForm, setShowAddForm] = useState(false); //Добавили

  const { data: students, isLoading, error } = useQuery({
    queryKey: ['students'],
    queryFn: getStudentsApi,
  });
  const { deleteStudentMutate, addStudentMutate } = useStudents();

  const onDeleteHandler = (studentId: number): void => {
    debugger; //н9
    console.log('OnDeleteHandler', studentId); //н9

    if (confirm('Удалить студента?')) {
      deleteStudentMutate(studentId);
    }
  };

    const onAddHandler = (data: any) => {
    debugger; //н9
    console.log('Добавление студента', data); //н9
      
    addStudentMutate(data); 
    setShowAddForm(false);
  };

  if (isLoading) {
    return <div>Загрузка студентов...</div>;
  }

  if (error) {
    return <div>Ошибка при загрузке студентов: {error.message}</div>;
  }

  return (
    <div>
      <h1>Список студентов</h1>

      <button onClick={() => setShowAddForm(!showAddForm)}>
        {showAddForm ? 'Неть' : 'Добавить студента'}
      </button>

      {showAddForm && (
        <AddStudent
          onAdd={onAddHandler}
          onCancel={() => setShowAddForm(false)}
        />
      )}

      {students && students.length > 0 ? (
        <ul>
          {students.map((student: StudentInterface) => (
            <li key={student.id}>
              <Student
                student={student}
                onDelete={onDeleteHandler}
              />
            </li>
          ))}
        </ul>
      ) : (
        <p>Студенты не найдены</p>
      )}
    </div>
  );
};

export default Students;