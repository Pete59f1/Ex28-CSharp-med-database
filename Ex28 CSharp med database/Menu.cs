using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ex28_CSharp_med_database
{
    public class Menu
    {
        private static string conntectionString =
        "Server = ealSQL1.eal.local; Database = A_DB26_2018; User Id = A_STUDENT26; Password = A_OPENDB26;";
        private void Show()
        {
            Console.WriteLine("YELLO");
            Console.WriteLine("1. Insert a Pet");
            Console.WriteLine("0. Exit");
        }

        public void RunMenu()
        {
            Show();
            bool run = true;
            string input = Console.ReadLine();
            using (SqlConnection con = new SqlConnection(conntectionString))
            {

                do
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Hey");
                            break;
                        case "0":
                            run = false;
                            break;
                        default:
                            Console.WriteLine("??");
                            break;
                    }

                } while (run);
            }
        }
    }
}
