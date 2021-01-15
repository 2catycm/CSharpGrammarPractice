using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void 我是公共方法(){}
        protected void 我可以被同包或者子类访问(){}
        internal  void 我是包内可访问的方法(){}
        protected internal void 同包的子类才能访问我(){} 
        //不报错，但是不推荐// internal protected void 同包的子类才能访问我1(){}
        private void 我是私有方法(){}
    }
}