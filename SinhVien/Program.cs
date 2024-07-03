using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using SinhVien;

namespace MyApp
{
    internal class Program
    {
        Encoding UTP8 = Encoding.UTF8;
        static void Main(string[] args)
        {
          NhapSinhVien nhapSinhVien = new NhapSinhVien();
            while (true)
            {
                Console.WriteLine("Quan ly danh sach sinh vien");
                Console.WriteLine("1. Them thong tin sinh vien");
                Console.WriteLine("");

                int key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        Console.WriteLine("Them sinh vien");
                        nhapSinhVien.GhiSinhVien();
                        Console.WriteLine("Them sinh vien thanh cong");
                        break;
                    //case 2:
                    //    int id;
                    //    Console.WriteLine("Cap nhat thong tin sinh sien");
                    //    Console.WriteLine("Nhap ID");
                    //    id = Convert.ToInt32(Console.ReadLine());
                    //    nhapSinhVien.UpdateThongTinSinhVien(id);
                    //    break;
                }
            }
        }
    }
}