import styles from './Footer.module.scss';

const Header = (): React.ReactElement => (
  <footer className={styles.Footer}>
    ©
    {' '}
    {(new Date()).getFullYear()}
    {' '}
    Высший колледж информатики НГУ
  </footer>
);

export default Header;