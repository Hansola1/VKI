'use client';

import { useState, type ReactNode } from 'react';
import { useForm } from 'react-hook-form';
import styles from './LoginForm.module.scss';
import { useAuth } from '../../hooks/useAuth';

type LoginFormValues = {
  email: string;
  password: string;
};

const LoginForm = (): ReactNode => {
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<string | null>(null);
  const { setUser } = useAuth();

  const {
    register,
    handleSubmit,
    formState: { errors, isSubmitting },
  } = useForm<LoginFormValues>({
    defaultValues: {
      email: 'admin@example.com',
      password: 'admin123',
    },
  });

  const onSubmit = async (values: LoginFormValues): Promise<void> => {
    setError(null);
    setSuccess(null);

    try {
      const response = await fetch('/api/auth/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(values),
      });

      const data = await response.json();

      setUser(data.user);

      if (!response.ok) {
        throw new Error(data?.message ?? 'Ошибка авторизации');
      }

      window.localStorage.setItem('accessToken', data.token);
      setSuccess('Авторизация успешна! Токен сохранён в localStorage.');
    }
    catch (submitError) {
      setError(
        submitError instanceof Error ? submitError.message : 'Ошибка авторизации',
      );
    }
  };

  return (
    <form className={styles.LoginForm} onSubmit={handleSubmit(onSubmit)}>
      <div className={styles.field}>
        <label className={styles.label} htmlFor="email">
          Email
        </label>
        <input
          id="email"
          className={styles.input}
          type="email"
          placeholder="admin@example.com"
          {...register('email', { required: 'Email обязателен' })}
        />
        {errors.email?.message && (
          <span className={styles.error}>{errors.email.message}</span>
        )}
      </div>

      <div className={styles.field}>
        <label className={styles.label} htmlFor="password">
          Пароль
        </label>
        <input
          id="password"
          className={styles.input}
          type="password"
          placeholder="••••••••"
          {...register('password', { required: 'Пароль обязателен' })}
        />
        {errors.password?.message && (
          <span className={styles.error}>{errors.password.message}</span>
        )}
      </div>

      <div className={styles.actions}>
        <button className={styles.button} type="submit" disabled={isSubmitting}>
          {isSubmitting ? 'Загрузка...' : 'Войти'}
        </button>
        <p className={styles.hint}>
          После успешной авторизации токен сохраняется в localStorage по ключу
          <code>accessToken</code>
          .
        </p>
      </div>

      {error && <p className={styles.error}>{error}</p>}
      {success && <p className={styles.success}>{success}</p>}
    </form>
  );
};

export default LoginForm;