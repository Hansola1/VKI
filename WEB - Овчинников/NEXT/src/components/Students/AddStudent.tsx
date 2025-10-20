'use client';

import { useForm } from 'react-hook-form';

interface AddStudentForm {
  firstName: string;
  lastName: string;
  middleName?: string;
  groupId?: number; //вообще в идеале убрать(
}

export default function AddStudent({ onAdd, onCancel }: {
  onAdd: (data: AddStudentForm) => void;
  onCancel: () => void;
}) {
  const { register, handleSubmit } = useForm<AddStudentForm>();

  return (
    <form onSubmit={handleSubmit(onAdd)} style={{ padding: '16px', border: '1px solid #ddd' }}>
      <h3>Добавить студента</h3>

      <input {...register('firstName')} placeholder="Имя" required />
      <input {...register('lastName')} placeholder="Фамилия" required />
      <input {...register('middleName')} placeholder="Отчество" />
      <input {...register('groupId', { valueAsNumber: true })} type="number" placeholder="ID группы" />

      <button type="submit">Добавить</button>
      <button type="button" onClick={onCancel}>Отмена</button>
    </form>
  );
}