namespace Conapp01
{
    class Person
    {
        private string pname;
        private string gender;
        private int age;

        public Person(string pname, string gender, int age)
        {
            this.pname = pname; this.gender = gender; this.age = age;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {this.pname}, Gender: {this.gender}, Age: {this.age}");
        }
    }
}
