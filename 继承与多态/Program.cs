using System;

namespace 继承与多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal A = new Animal("杰瑞鼠");
            Cat C = new Cat("汤姆猫");
            Animal AC = new Cat("披着鼠皮的猫");
            
            A.Rides(A);
            A.Rides(C);
            A.Rides(AC);
            
            C.Rides(A);
            C.Rides(C);
            C.Rides(AC);
            
            AC.Rides(A);
            AC.Rides(C);
            AC.Rides(AC);
        }
    }

    class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            Name = "";
        }

        public Animal(string name):this()//既然java中委派构造任务给其他人必须放在第一行，C#干脆醒目地要求你放在函数声明
        {
            Name = name;
        }

        protected ColoredText ctUpper_Animal = new ColoredText(ConsoleColor.Red,"Animal");
        protected ColoredText ctUpper_Cat = new ColoredText(ConsoleColor.Red,"Cat");
        protected ColoredText ctLower_Animal = new ColoredText(ConsoleColor.Blue,"animal");
        protected ColoredText ctLower_Cat = new ColoredText(ConsoleColor.Blue,"cat");
        virtual public void Rides(Animal other)//C#中，virtual方法才允许重写，其他方法静态绑定，父子无关
        {
            Console.WriteLine("{2} {0} is riding on {3} {1}",this.Name,other.Name,ctLower_Animal,ctLower_Animal);
        }
        virtual public void Rides(Cat other)
        {
            Console.WriteLine("{2} {0} is riding on {3} {1}",this.Name,other.Name,ctLower_Animal,ctLower_Cat);
        }
    }

    class Cat:Animal
    {
        public Cat(string name):base(name)
        {
        }

        public override void Rides(Animal other)
        {
            Console.WriteLine("{2} {0} is riding on {3} {1}",this.Name,other.Name,ctUpper_Cat,ctLower_Animal);

        }

        public override void Rides(Cat other)
        {
            Console.WriteLine("{2} {0} is riding on {3} {1}",this.Name,other.Name,ctUpper_Cat,ctLower_Cat);
        }
    }
}