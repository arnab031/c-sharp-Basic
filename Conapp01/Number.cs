namespace Conapp01
{
    class Number
    {
        private int num1;
        public Number()      //default constructor
        {
            num1 = 0;
        }
        public Number(int num1)   //parametrized constructor
        {
            this.num1= num1;
        }
        public void GetNumber()
        {
            Console.WriteLine($"num1 = {this.num1}");
        }
    }
}
