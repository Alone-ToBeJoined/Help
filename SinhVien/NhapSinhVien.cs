using System.Reflection.Metadata.Ecma335;

namespace SinhVien
{
    internal class NhapSinhVien
    {
        class SinhVien
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            public int Age { get; set; }
            public double diemToan { get; set; }
            public double diemLy { get; set; }
            public double diemHoa { get; set; }
            public double diemTB { get; set; }
        }
        //ham tao ID tang dan cho sinh vien
        private List<SinhVien> listSinhVien = null;
        private int GenerateID()
        {
            int max = 1;
            if (listSinhVien != null && listSinhVien.Count > 0)
            {
                max = listSinhVien[0].ID;
                foreach (SinhVien sv in listSinhVien)
                {
                    if (max < sv.ID)
                    {
                        max = sv.ID;
                    }
                    max++;
                }
                return max;
            }
            return 0;
        }
        public int SoLuongSinhVien()
        {
            int count = 0;
            if (listSinhVien != null)
            {
                count = listSinhVien.Count;
            }
            return count;
        }
        //ham nhap thong tin sinh vien
        public void GhiSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.ID = GenerateID();
            Console.WriteLine("Nhap ten sinh vien : ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gioi tinh sinh vien : ");
            sv.Sex = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi cua sinh vien : ");
            sv.Age = int.Parse(Console.ReadLine());

            Console.Write("Nhap diem Toan cua sinh vien : ");
            sv.diemToan = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Ly cua sinh vien : ");
            sv.diemLy = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Hoa cua sinh vien : ");
            sv.diemHoa = double.Parse(Console.ReadLine());

            //void TinhDTB(SinhVien sv)
            //{
            //    double diemTB = (sv.diemToan + sv.diemLy + sv.diemHoa) / 3;
            //    sv.diemTB = Math.Round(diemTB, 2, MidpointRounding.AwayFromZero);
            //}
        }
        //ham update thong tin sinh vien
         public void UpdateThongTinSinhVien(int ID)
        {
            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                Console.WriteLine("Nhap ten sinh vien : ");
                string name = Convert.ToString(Console.ReadLine());
                if (name != null && name.Length > 0)
                {
                    sv.Name = name;
                }

                Console.WriteLine("Nhap gioi tinh sinh vien : ");
                string sex = Convert.ToString(Console.ReadLine());
                if (sex != null && sex.Length > 0)
                {
                    sv.Sex = sex;
                }

                Console.WriteLine("Nhap tuoi sinh vien : ");
                string ageStr = Convert.ToString(Console.ReadLine());
                if (ageStr != null && ageStr.Length > 0)
                {
                    sv.Age = int.Parse(ageStr);
                }

                Console.WriteLine("Nhap diem Toan cua sinh vien : ");
                string diemToanStr = Convert.ToString(Console.ReadLine());
                if (diemToanStr != null && diemToanStr.Length > 0)
                {
                    sv.diemToan = Convert.ToDouble(diemToanStr);
                }

                Console.WriteLine("Nhap diem Ly cua sinh vien : ");
                string diemLyStr = Convert.ToString(Console.ReadLine());
                if (diemLyStr != null && diemLyStr.Length > 0)
                {
                    sv.diemLy = Convert.ToDouble(diemLyStr);
                }

                Console.WriteLine("Nhap diem Hoa cua sinh vien : ");
                string diemHoaStr = Convert.ToString(Console.ReadLine());
                if (diemHoaStr != null && diemHoaStr.Length > 0)
                {
                    sv.diemHoa = Convert.ToDouble(diemHoaStr);
                }
                //TinhDTB(sv);
                //XepLoaiSinhVien(sv);
            }
        }
        //public bool DeleteById(int ID)
        //{
        //    bool isDeleted = false;
        //    SinhVien sv =  
        //}
    }
}
