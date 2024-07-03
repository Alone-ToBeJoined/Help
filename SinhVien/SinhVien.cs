using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    internal class SinhVien
    {
        public static void ThongTinSinhVien()
        {
            string name, id, age, address;
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter ID : ");
            id = Console.ReadLine();

            Console.WriteLine("Enter Age");
            age = Console.ReadLine();

            Console.WriteLine("Enter Adress");
            address = Console.ReadLine();

            Console.WriteLine("Student informations : ");
            Console.WriteLine("Student's name : {0}", name);
            Console.WriteLine("Student's ID : {0}", id);
            Console.WriteLine("Student's Age : {0}", age);
            Console.WriteLine("Student's Address  : {0}", address);
            Console.ReadKey();
        }
    }
}
