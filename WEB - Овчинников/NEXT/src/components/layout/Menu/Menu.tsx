'use client';
 
import { usePathname } from 'next/navigation';
import Link from 'next/link';
import styles from './Menu.module.scss';

const Menu = (): React.ReactElement => {
  const pathname = usePathname ();
  return (
    <nav className={styles.Menu}>
      <div className={pathname === '/' ? styles.linkActive : ''}>
        <Link href="/">Главная</Link>
      </div>
      <div className={pathname === '/groups' ? styles.linkActive : ''}>
        <Link href="/groups">Группы</Link>
      </div>
      <div className={pathname === '/students' ? styles.linkActive : ''}>
        <Link href="/students">Студенты</Link>
      </div>
    </nav>
  );
};

export default Menu;
