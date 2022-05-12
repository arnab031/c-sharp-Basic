namespace Conapp01
{
    class Numbers
    {
        private int num1, num2;      //data members: Refers to variable inside a class
        
        public Numbers()
        {
            num1 = num2 = 0;
        }
        public Numbers(int num1, int num2)//method: refers to function inside a class
        {
            this.num1 = num1;     //current object datamember will be called using this keyword 
            this.num2 = num2;
        }
        public void GetNumbers()
        {
            Console.WriteLine($"num1 = {this.num1}, num2 = {this.num2}");
        }
    }
}
/*
 Private : It is an access modifier, the content in this is accessible within the class only
 Public : It is an access modifier, the content in this accessible within inside amd outside a class
 */