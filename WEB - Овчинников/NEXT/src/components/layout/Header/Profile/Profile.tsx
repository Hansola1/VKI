'use client';

import { usePathname, useRouter } from 'next/navigation';
import type UserInterface from '../../../../types/UserInterface';
import { useAuth } from '../../../../hooks/useAuth';
import styles from './Profile.module.scss';
import Link from 'next/link';

interface Props {
  userFromServer?: UserInterface;
}

const Profile = ({
  userFromServer,
}: Props): React.ReactElement => {
  const router = useRouter();
  const pathname = usePathname();

  const { user, setUser } = useAuth();

  const getUser = (): UserInterface | null | undefined => user === undefined ? userFromServer : user;

  const logoutHandler = (e: React.MouseEvent<HTMLElement>): void => {
    e.preventDefault();

    const logout = async (): Promise<void> => {
      try {
        const response = await fetch('/api/auth/logout', {
          method: 'POST',
        });

        if (response.ok) {
          router.push('/login');
          setUser(null);
        }
        else {
          console.error('Logout failed');
        }
      }
      catch (error) {
        console.error('Logout error:', error);
      }
    };

    logout();
  };

  return (
    <div className={styles.Profile}>

      {getUser() && (
        <>
          {getUser()?.email}
          {'   '}
        </>
      )}

      {!getUser() && (
        <Link
          href="/login"
          className={pathname.includes('/login') ? styles.linkActive : ''}
        >
          Вход
        </Link>
      )}

      {getUser() && <Link href="/logout" onClick={logoutHandler}>Выход</Link>}
    </div>
  );
};
export default Profile;