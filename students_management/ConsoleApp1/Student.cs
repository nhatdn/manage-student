using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Student
    {
        private string maSoSinhVien;
        private string hoVaTen;
        private float DiemToan;
        private float DiemVan;
        private float DiemTrungBinh;
        static int SoLuongSV;
        public string MaSoSV
        {
            get
            {
                return maSoSinhVien;
            }
        }
        public float DiemTB
        {
            get
            {
                return DiemTrungBinh;
            }
        }
        public static int SoLuongSinhVien
        {
            get
            {
                return SoLuongSV;
            }
            set
            {
                SoLuongSV = value;
            }
        }
        public void NhapThongTinSinhVien(Point viTri, int ToaDoY)
        {
            Console.SetCursorPosition(viTri.MaSoSinhVien + 19, ToaDoY + 2);
            this.maSoSinhVien = Console.ReadLine();
            Console.SetCursorPosition(viTri.HoVaTenSinhVien + 23, ToaDoY + 2);
            this.hoVaTen = Console.ReadLine();
            Console.SetCursorPosition(viTri.DiemVan + 12, ToaDoY + 2);
            this.DiemToan = float.Parse(Console.ReadLine());
            Console.SetCursorPosition(viTri.DiemToan + 13, ToaDoY + 2);
            this.DiemVan = float.Parse(Console.ReadLine());
            Console.CursorVisible = false;
        }
        public void TinhDiemTrungBinhMon()
        {
            this.DiemTrungBinh = (DiemToan + DiemVan) / 2;
        }
        public void GiaoDienXuatThongTinSinhVien(Point viTri, int ToaDoY)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(viTri.MaSoSinhVien + 19, ToaDoY + 12);
            Console.Write(maSoSinhVien);
            Console.SetCursorPosition(viTri.HoVaTenSinhVien + 23, ToaDoY + 12);
            Console.Write(hoVaTen);
            Console.SetCursorPosition(viTri.DiemVan + 12, ToaDoY + 12);
            Console.Write(DiemVan);
            Console.SetCursorPosition(viTri.DiemToan + 13, ToaDoY + 12);
            Console.Write(DiemToan);
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = ToaDoY; i <= ToaDoY + 3; i++)
            {
                Console.SetCursorPosition(viTri.DiemTrungBinh,11+ i);
                Console.Write(" ");
            }
            Console.SetCursorPosition(10, ToaDoY + 14);
            for (int i = 0; i < 160; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(viTri.Cuoi + 2, ToaDoY + 12);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" Diem TB: " + DiemTrungBinh);
            Console.CursorVisible = true;
        }
    }
}