import { Entity, PrimaryGeneratedColumn, Column, OneToMany, JoinColumn } from 'typeorm';
// import { Student } from './Student.entity'; ЦИКЛИЧ ЗАВИСИМ

@Entity()
export class Group {
  @PrimaryGeneratedColumn()
  id!: number;

  @Column()
  name!: string;

  //1 группа - много студентов (связь один ко многим)
//   @OneToMany(() => Student, student => student.group)
// students!: Student[];

//Возникла ошибка с инициализацией(referenceError: Cannot access 'Group' before initialization),
  // ничего лучше этого костыля я не придумала. Может вернусь к этому позже.

    @OneToMany(() => {
    const { Student } = require('./Student.entity');
    return Student;
  }, (student: any) => student.group)
  students!: any[];

  //  @Column({ nullable: true })
  // description?: string;

//   @Column()
//   contacts!: string;
}