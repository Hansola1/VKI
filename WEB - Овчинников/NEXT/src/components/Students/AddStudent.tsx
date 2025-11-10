'use client';

import { useState, useEffect } from 'react';
import { useForm } from 'react-hook-form';

interface Group {
  id: number;
  name: string;
}

interface AddStudentForm {
  firstName: string;
  lastName: string;
  middleName?: string;
  groupId?: number; 
}

export default function AddStudent({ onAdd, onCancel }: {
  onAdd: (data: AddStudentForm) => void;
  onCancel: () => void;
}) {
  const { register, handleSubmit, setValue } = useForm<AddStudentForm>();
  // сonst { register, handleSubmit, watch, setValue } = useForm<AddStudentForm>();
  const [groups, setGroups] = useState<Group[]>([]);

   useEffect(() => {
    fetch('/api/groups')
      .then(res => res.json())
      .then(data => {
        setGroups(data);
        if (data.length > 0) {
          setValue('groupId', data[0].id); // по умолчанию пусть будет
        }
      });
  }, [setValue]);

  return (
    <form onSubmit={handleSubmit(onAdd)} style={{ padding: '16px', border: '1px solid #ddd' }}>
      <h3>Добавить студента</h3>

      {/* Поля */}
      <input {...register('firstName')} placeholder="Имя" required />
      <input {...register('lastName')} placeholder="Фамилия" required />
      <input {...register('middleName')} placeholder="Отчество" />
      <input {...register('groupId', { valueAsNumber: true })} type="number" placeholder="ID группы" />

      {/* Селектор групп */}
      <select
        {...register('groupId', { required: true })}
        defaultValue=""
        onChange={(e) => setValue('groupId', Number(e.target.value))}>
        <option value="" disabled>Выберите группу</option>

        {groups.map((group) => (
          <option key={group.id} value={group.id}>
            {group.name}
          </option>
        ))}
      </select>

      {/* Кнопки */}
      <button type="submit">Добавить</button>
      <button type="button" onClick={onCancel}>Отмена</button>
    </form>
  );
}