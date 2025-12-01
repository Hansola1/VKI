import Menu from '../Menu/Menu';
import styles from './Header.module.scss';
import Link from 'next/link';
import type UserInterface from '../../../types/UserInterface';
import Profile from './Profile/Profile';

// const Header = (): React.ReactElement => (
//   <header className={styles.Header}>
//     <div className={styles.title}>WEB разработка</div>
//     <Menu />
//   </header>
// );


interface Props {
  userFromServer?: UserInterface;
}

const Header = ({ userFromServer }: Props): React.ReactElement => {
  return (
    <header className={styles.Header}>
      <Link href="/" className={styles.title} role="heading">
        ВКИ Класс
      </Link>
      <Menu />
      <Profile userFromServer={userFromServer} />
    </header>
  );
};


export default Header;
