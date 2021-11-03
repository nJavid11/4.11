using Ikinci_project;
using System;

namespace Ilk_project
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Class1 c = new Class1();

            c.Aa();  //public
            //c.Ee()  error : private
            //c.Bb()  error : internal
            p.Cc();  //protected internal
            //c.Dd()  error : protected
            //c.Ee()  error : private
            //c.Ff()  error : private protected


        }
    }
}
