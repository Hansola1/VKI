import {
  useQuery,
  useMutation,
  useQueryClient,
} from '@tanstack/react-query';
import { v4 as uuidv4 } from 'uuid';
import { deleteStudentApi, getStudentsApi, addStudentApi } from '@/api/studentsApi';
import isServer from '@/utils/isServer';
import type StudentInterface from '@/types/StudentsInterface';

// для обновления студента на клиенте, после post запроса на сервере можно добавить поле uuid, 
// выставлять это поле на клиенте, записывать его в бд
 
// import { v4 as uuidv4 } from 'uuid';
// //....
// addStudentMutate({
// id: -1,
// ...studentFormField,
// groupId: 1,
// uuid: uuidv4(),
// });

interface StudentsHookInterface {
  students: StudentInterface[];
  deleteStudentMutate: (studentId: number) => void;
  addStudentMutate: (data: Partial<StudentInterface>) => void; 
}

const useStudents = (): StudentsHookInterface => {
  const queryClient = useQueryClient();

  const { data, refetch } = useQuery({
    queryKey: ['students'],
    queryFn: () => getStudentsApi(),
    enabled: false,
  });

  /**
   * Мутация удаления студента
   */
  const deleteStudentMutate = useMutation({
    // вызов API delete
    mutationFn: async (studentId: number) => deleteStudentApi(studentId),
    // оптимистичная мутация (обновляем данные на клиенте до API запроса delete)
    onMutate: async (studentId: number) => {
      await queryClient.cancelQueries({ queryKey: ['students'] });
      // получаем данные из TanStackQuery
      const previousStudents = queryClient.getQueryData<StudentInterface[]>(['students']);
      let updatedStudents = [...(previousStudents ?? [])] ;

      if (!updatedStudents) return;

      // помечаем удаляемую запись
      updatedStudents = updatedStudents.map((student: StudentInterface) => ({
        ...student,
        ...(student.id === studentId ? { isDeleted: true } : {}),
      }));
      // обновляем данные в TanStackQuery
      queryClient.setQueryData<StudentInterface[]>(['students'], updatedStudents);

      return { previousStudents, updatedStudents };
    },
    onError: (err, variables, context) => {
      console.log('>>> deleteStudentMutate  err', err);
      queryClient.setQueryData<StudentInterface[]>(['students'], context?.previousStudents);
    },
    // обновляем данные в случаи успешного выполнения mutationFn: async (studentId: number) => deleteStudentApi(studentId),
    onSuccess: async (studentId, variables, { previousStudents }) => {
      await queryClient.cancelQueries({ queryKey: ['students'] });
      // вариант 1 - запрос всех записей
      // refetch();

      // вариант 2 - удаление конкретной записи
      if (!previousStudents) {
        return;
      }
      const updatedStudents = previousStudents.filter((student: StudentInterface) => student.id !== studentId);
      queryClient.setQueryData<StudentInterface[]>(['students'], updatedStudents);
    },
    // onSettled: (data, error, variables, context) => {
    //   // вызывается после выполнения запроса в случаи удачи или ошибке
    //   console.log('>> deleteStudentMutate onSettled', data, error, variables, context);
    // },
  });

// --- Мутация добавления (новая) ---
const addStudentMutate = useMutation({
    mutationFn: (newStudent: Partial<StudentInterface>) => addStudentApi(newStudent),
    onMutate: async (newStudent) => {
      await queryClient.cancelQueries({ queryKey: ['students'] });
      const previousStudents = queryClient.getQueryData<StudentInterface[]>(['students']);

      // Оптимистичное добавление: временно добавляем студента с временным id 
    const optimisticStudent: StudentInterface = {
      id: -1,
      uuid: uuidv4(), 
      firstName: newStudent.firstName ?? '',
      lastName: newStudent.lastName ?? '',
      middleName: newStudent.middleName ?? '',
      groupId: newStudent.groupId ?? 1,
      isDeleted: false,
    };

      queryClient.setQueryData(['students'], [
        ...(previousStudents ?? []),
        optimisticStudent,
      ]);
      return { previousStudents, optimisticStudent };
    },
  onSuccess: (savedStudent, variables, context) => {
    queryClient.setQueryData<StudentInterface[]>(['students'], (old = []) => {
      return old.map(student =>
        student.uuid === context?.optimisticStudent.uuid 
          ? { ...savedStudent, uuid: student.uuid } 
          : student
      );
    });
  },
  onError: (err, variables, context) => {
    queryClient.setQueryData(['students'], context?.previousStudents); // Откатываем оптимистичное изменение
  },
});

  return {
    students: data ?? [],
    deleteStudentMutate: deleteStudentMutate.mutate,
    addStudentMutate: addStudentMutate.mutate,
  };
};

export default useStudents;
