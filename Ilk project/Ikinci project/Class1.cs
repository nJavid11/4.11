using System;

namespace Ikinci_project
{
    public class Class1
    {
        public void Aa()
        {
            Console.WriteLine("Public");
        }
        private void Ee()
        {
            Console.WriteLine("Private");
        }

        protected void Dd()
        {
            Console.WriteLine("Protected");
        }

        internal void Bb()
        {
            Console.WriteLine("Internal");
        }

        protected internal void Cc()
        {
            Console.WriteLine("Protected Internal");
        }
        protected private void Ff() {
            Console.WriteLine("Private Protected");
        }

    }
}
