
import { hashPassword } from '../../../../../utils/password';
import { User } from '../../../../../db/Entity/User.entity';
import AppDataSource from '../../../../../db/AppDataSource';

const defaultUsers = [
  {
    email: 'admin@example.com',
    fullName: 'Администратор Системы',
    password: hashPassword('admin123'),
  },
  {
    email: 'manager@example.com',
    fullName: 'Менеджер Учебного Отдела',
    password: hashPassword('manager123'),
  },
];

export async function GET(): Promise<Response> {
  let newUsers: number = 0;
  let existUsers: number = 0;
  const repository = AppDataSource.getRepository(User);

  await Promise.all(defaultUsers.map(async (user) => {
    const exists = await repository.findOne({
      where: { email: user.email },
    });

    if (!exists) {
      await repository.save(repository.create(user));
      newUsers++;
    } else {
      existUsers++;
    }
  }));

  return new Response(JSON.stringify({
    newUsers,
    existUsers,
  }), {
    status: 201,
    headers: {
      'Content-Type': 'application/json',
    },
  });
};
