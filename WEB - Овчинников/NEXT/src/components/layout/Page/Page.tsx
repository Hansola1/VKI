import ChildrenType from '@/types/ChildrenType';

import styles from './Page.module.scss';

interface Props {
  children?: ChildrenType;
}

const Page = ({ children }: Props): React.ReactElement => (
  <div className={styles.main}>
    {children}
  </div>
);

export default Page;
