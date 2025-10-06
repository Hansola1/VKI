'use client';

import { useForm } from 'react-hook-form';

interface AddStudentForm {
  first_name: string;
  last_name: string;
  middle_name?: string;
  groupId?: number;
}

export default function AddStudent({ onAdd, onCancel }: {
  onAdd: (data: AddStudentForm) => void;
  onCancel: () => void;
}) {
  const { register, handleSubmit } = useForm<AddStudentForm>();

  return (
    <form onSubmit={handleSubmit(onAdd)} style={{ padding: '16px', border: '1px solid #ddd' }}>
      <h3>Добавить студента</h3>

      <input {...register('first_name')} placeholder="Имя" required />
      <input {...register('last_name')} placeholder="Фамилия" required />
      <input {...register('middle_name')} placeholder="Отчество" />
      <input {...register('groupId', { valueAsNumber: true })} type="number" placeholder="ID группы" />

      <button type="submit">Добавить</button>
      <button type="button" onClick={onCancel}>Отмена</button>
    </form>
  );
}