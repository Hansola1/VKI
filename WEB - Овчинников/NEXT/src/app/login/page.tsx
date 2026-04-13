import LoginForm from '../../components/auth/LoginForm';
import Page from '../../components/layout/Page/Page';
import { META_DESCRIPTION, META_TITLE } from '../../constants/meta';
import { type Metadata } from 'next/types';

export const metadata: Metadata = {
  title: `Вход - ${META_TITLE}`,
  description: META_DESCRIPTION,
};

const LoginPage = (): React.ReactNode => (
  <Page>
    <h1>Авторизация</h1>
    <p>
      Используйте один из тестовых аккаунтов:
      <br />
      admin@example.com / admin123
      <br />
      manager@example.com / manager123
    </p>
    <LoginForm />
  </Page>
);

export default LoginPage;