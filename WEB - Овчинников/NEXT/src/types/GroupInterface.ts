interface GroupInterface {
  id: number;
  name: string;
   description?: string;
  //contacts: string;

  //н9-11
    students?: Array<{
    id: number;
    firstName: string;
    lastName: string;
    middleName?: string;
  }>;
};

export default GroupInterface;