import { Entity, PrimaryGeneratedColumn, Column, OneToMany, JoinColumn } from 'typeorm';
import { Student } from './Student.entity';

@Entity()
export class Group {
  @PrimaryGeneratedColumn()
  id!: number;

  @Column()
  name!: string;

  //1 группа - много студентов (связь один ко многим)
  @OneToMany(() => Student, (student: Student) => student.group) // ← Явно указали тип Student
  students!: Student[];

  //  @Column({ nullable: true })
  // description?: string;

//   @Column()
//   contacts!: string;
}