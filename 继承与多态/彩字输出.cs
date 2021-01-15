using System;

namespace 继承与多态
{
    public class ColoredText
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
    }
}