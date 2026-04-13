import 'reflect-metadata';
import Page from '../components/layout/Page/Page';


const HomePage = (): React.ReactNode => {
  return (
    <Page>
      <h1>Главная страница</h1>
      <h2>Заголовок 2</h2>
      <h3>Заголовок 3</h3>
      <h4>Заголовок 4</h4>
    </Page>
  );
};

export default HomePage;
