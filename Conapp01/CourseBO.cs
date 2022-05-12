namespace Conapp01
{
    class CourseBO      //CourseUtil
    {
        public List<CourseModel> Courses { get; set; }
        public CourseBO()
        {
            Courses = new List<CourseModel>()
            {
                new CourseModel { Id = 101, Course = "EEE", Hod = "Eman", Fee = 25000 },
                new CourseModel { Id = 102, Course = "IT", Hod = "Indrajith", Fee = 28000 },
                new CourseModel { Id = 103, Course = "CSE", Hod = "Chandra", Fee = 32000 }
            };
        }
        public List<CourseModel> GetAllCourses()
        {
            return Courses;
        }
        public CourseModel GetCourseByid(int id)
        {
            CourseModel c = new CourseModel();
            for (int i = 0; i < Courses.Count; i++)
            {
                if(Courses[i].Id ==id)
                {
                    c = Courses[i];
                    break;
                }
            }
            return c;
        }
        public void AddCourse(CourseModel c)
        {
            Courses.Add(c);
        }
        public void EditCourse(int id, CourseModel c)
        {
            int pos = -1;
            for (int i = 0; i < Courses.Count; i++)
            {
                if(Courses[i].Id == id)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
                Courses[pos] = c;
        }
        public void DeleteCourseById(int id)
        {
            int pos = -1;
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].Id == id)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
                Courses.RemoveAt(pos);
        }
    }
}
