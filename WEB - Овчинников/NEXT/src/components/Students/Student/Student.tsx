// src/components/Students/Student.tsx
import type StudentInterface from '../../../types/StudentsInterface';

interface StudentProps {
  student: StudentInterface;
}

const StudentDetails = ({ student }: StudentProps) => {
  return (
    <div style={{ padding: '1rem', border: '1px solid #ccc', borderRadius: '8px', maxWidth: '400px' }}>
      <h2>
        {student.lastName} {student.firstName} {student.middleName}
      </h2>
      <p><strong>ID:</strong> {student.id}</p>
      <p><strong>Группа:</strong> {student.groupId}</p>
      {/* {student.contacts && <p><strong>Контакты:</strong> {student.contacts}</p>} */}
      {student.isDeleted && <p><em>Удалён</em></p>}
      {/* {student.isNew && <p><em>Новый (ещё не сохранён)</em></p>} */}
    </div>
  );
};

export default StudentDetails;