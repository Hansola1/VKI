import ChildrenType from '@/types/ChildrenType';

import styles from './Main.module.scss';

interface Props {
  children?: ChildrenType;
}

const Main = ({ children }: Props): React.ReactElement => (
  <div className={styles.Main}>
    {children}
  </div>
);

export default Main;
