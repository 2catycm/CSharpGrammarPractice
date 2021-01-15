using System;
using System.Xml;

namespace 彩字输出
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MixedColorText//尝试聚合关系
    {
        
    }
    class ColoredText
    {
        private ConsoleColor Color { get; set; }
        private string Text { get; set; }

        public ColoredText()
        {
        }

        public ColoredText(ConsoleColor color, string text)
        {
            Color = color;
            Text = text;
        }

        public void write()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(this.Text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override string ToString()
        {
            this.write();
            return "";
        }
    }
}