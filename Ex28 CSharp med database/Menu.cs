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
                try
                {
                    con.Open();

                    do
                    {
                        switch (input)
                        {
                            case "1":
                                SqlCommand cmd1 = new SqlCommand("InsertPet", con);
                                cmd1.CommandType = CommandType.StoredProcedure;
                                Console.WriteLine("Insert pet name");
                                cmd1.Parameters.Add(new SqlParameter("@PetName", Console.ReadLine()));
                                Console.WriteLine("Insert pet type");
                                cmd1.Parameters.Add(new SqlParameter("@PetType", Console.ReadLine()));
                                Console.WriteLine("Insert pet breed");
                                cmd1.Parameters.Add(new SqlParameter("@PetBreed", Console.ReadLine()));
                                Console.WriteLine("Insert pet DOB");
                                cmd1.Parameters.Add(new SqlParameter("@PetDOB", Console.ReadLine()));
                                Console.WriteLine("Insert pet weight");
                                cmd1.Parameters.Add(new SqlParameter("@PetWeight", Console.ReadLine()));
                                Console.WriteLine("Insert owner id");
                                cmd1.Parameters.Add(new SqlParameter("@OwnerID", Console.ReadLine()));
                                cmd1.ExecuteNonQuery();
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
                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }
    }
}
