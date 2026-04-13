import { Entity, PrimaryGeneratedColumn, Column, ManyToOne, JoinColumn } from 'typeorm';
// import { Group } from './Group.entity'; // циклич зависим!!!

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
  //  @ManyToOne(() => Group, (group) => group.students, { nullable: true })
  // @JoinColumn({ name: 'groupId' })
  // group?: Group;

  //Возникла ошибка с инициализацией(referenceError: Cannot access 'Group' before initialization),
  // ничего лучше этого костыля я не придумала. Может вернусь к этому позже.

   @ManyToOne(() => {
    const { Group } = require('./Group.entity');
    return Group;
  }, (group: any) => group.students, { nullable: true })
  @JoinColumn({ name: 'groupId' })
  group?: any;
}