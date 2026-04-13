import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity('user')
export class User {
  @PrimaryGeneratedColumn()
  id!: number;

  @Column({ unique: true })
  email!: string;

  @Column()
  fullName!: string;

  @Column()
  password!: string;

  @Column({ default: true })
  isActive!: boolean;
}