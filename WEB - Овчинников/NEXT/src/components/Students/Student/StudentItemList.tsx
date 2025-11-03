import type StudentInterface from '../../../types/StudentsInterface';
import styles from './Student.module.scss';
import Link from 'next/link';

interface Props {
  student: StudentInterface;
  onDelete: (id: number) => void;
}

const Student = ({ student, onDelete }: Props): React.ReactElement => {
  const onDeleteHandler = (): void => {
    onDelete(student.id);
  };

    const modifier = student.isDeleted ? '--isDeleted' : student.isNew ? '--isNew' : '';

  return (
    <div
     className={`${styles.Student} ${styles[modifier]}`}>
      <Link href={`/students/${student.id}`} style={{ textDecoration: 'none', color: 'inherit' }}>
        <div>
          {student.id || 'xxxx'} - {student.lastName} {student.firstName} {student.middleName}
        </div>
      </Link>
{/* 
      {`${student.id || 'xxxx'} - ${student.lastName} ${student.firstName} ${student.middleName}`} */}
      <button onClick={onDeleteHandler}>Удаляяяяй</button>
    </div>
  );
};

//   return (
//     <div className={`${styles.Student} ${student.isDeleted ? styles['--isDeleted'] : '' }`}>
//       {student.id}
//       {' - '}
//       {student.lastName}
//       {' '}
//       {student.firstName}
//       {' '}
//       {student.middleName}
//       {' '}
//       <button onClick={onDeleteHandler}>Удаляшка</button>
//     </div>
//   );
// };

export default Student;
