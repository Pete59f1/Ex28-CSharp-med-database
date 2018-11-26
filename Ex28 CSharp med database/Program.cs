using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_CSharp_med_database
{
    class Program
    {
        Menu menu = new Menu();

        static void Main(string[] args)
        {
            Program pro = new Ex28_CSharp_med_database.Program();
            pro.Run();
        }

        private void Run()
        {
            menu.RunMenu();
        }
    }
}
