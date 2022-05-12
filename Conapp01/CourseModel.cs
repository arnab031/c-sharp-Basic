namespace Conapp01
{
    class CourseModel
    {
        public int Id { get; set; }
        public string Course { get; set; }
        public string Hod { get; set; }
        public int Fee { get; set; }
    }
}
/*
POCO: Plain Old CLR object
    These is a class contains autoimplemented properties

    The object of this class can store row in a database table

EmpModel
Business Objects:
	These are the object which allow to perform operations on the data like
		GetAllRows, GetRowById, AddRow(),		EditRow,		DeleteRow


Task:   Implement StudentModel and EmpModel 
 */