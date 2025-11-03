import { Entity, PrimaryGeneratedColumn, Column, ManyToOne, JoinColumn } from 'typeorm';
import { Group } from './Group.entity';

@Entity()
export class Student {
  @PrimaryGeneratedColumn()
  id!: number;

  @Column({ default: '' })
  uuid?: string;

  @Column()
  firstName!: string;

  @Column()
  lastName!: string;

  @Column()
  middleName!: string;

  @Column({ default: '' })
  contacts?: string;

  @Column()
  groupId!: number;

  // 1 студент - 1 группа
  @ManyToOne(() => Group, group => group.students)
  @JoinColumn({ name: 'groupId' })
  group!: Group;
}