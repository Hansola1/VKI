interface StudentInterface {
  id: number;
  uuid?: string; 
  firstName: string;
  lastName: string;
  middleName: string;
  contacts?: string;
  groupId: number;
  isDeleted?: boolean;
  isNew?: boolean;
 groupName?: string; // лаб10
}

export default StudentInterface;