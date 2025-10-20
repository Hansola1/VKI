interface StudentInterface {
  id: number;
  firstName: string;
  lastName: string;
  middleName: string;
  groupId: number;
  isDeleted?: boolean;
  uuid?: string; //ну необязательно на самом деле 
}

export default StudentInterface;