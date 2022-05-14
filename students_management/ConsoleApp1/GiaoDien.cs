using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    struct Point
    {
        public int MaSoSinhVien;
        public int HoVaTenSinhVien;
        public int DiemVan;
        public int DiemToan;
        public int Cuoi;
        public int DiemTrungBinh;
    }
    class GiaoDien
    {
        private Point viTri = new Point();
        public Point ViTri
        {
            get 
            {
                return viTri;
            }
            set
            {
                viTri = value;
            }
        }
        public GiaoDien()
        {
            viTri.MaSoSinhVien = 10;
            viTri.HoVaTenSinhVien = 45;
            viTri.DiemVan = 100;
            viTri.DiemToan = 124;
            viTri.Cuoi = 149;
            viTri.DiemTrungBinh = 169;
            
        }
        public void GiaoDienTieuDeThongBaoNhap()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(10, 11);
            for (int i = 1; i <= 140; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(10, 11+i);
                Console.Write(" ");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(149, 11+i);
                Console.Write(" ");
            }
            Console.SetCursorPosition(10, 15);
            for (int i = 0; i < 140; i++)
            {
                Console.Write(" ");
            }
        }
        public void GiaoDienTieuDeThongBaoXuat()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(10, 11);
            for (int i = 1; i <= 160; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(10, 11 + i);
                Console.Write(" ");
            }
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(169, 11 + i);
                Console.Write(" ");
            }
            Console.SetCursorPosition(10, 15);
            for (int i = 0; i < 160; i++)
            {
                Console.Write(" ");
            }
        }

        public void HienThiTieuDeNhap(string title, int lengthOfTitle)
        {
            Console.SetCursorPosition((149 - lengthOfTitle) / 2, 13);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(title);
        }
        public void HienThiTieuDeXuat(string title, int lengthOfTitle)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 12; i < 150;i++)
            {
                Console.SetCursorPosition(i, 13);
                
                Console.Write(" ");
            }
            Console.SetCursorPosition((169 - lengthOfTitle) / 2, 13);
            Console.Write(title);
        }

        public void GiaoDienThongTinSinhVien(int ToaDoY)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = ToaDoY; i <= ToaDoY + 3; i++)
            {
                Console.SetCursorPosition(this.viTri.MaSoSinhVien, 11 + i);
                Console.Write(" ");
                Console.SetCursorPosition(this.viTri.HoVaTenSinhVien, 11 + i);
                Console.Write(" ");
                Console.SetCursorPosition(this.viTri.DiemVan, 11 + i);
                Console.Write(" ");
                Console.SetCursorPosition(this.viTri.DiemToan, 11 + i);
                Console.Write(" ");
                Console.SetCursorPosition(this.viTri.Cuoi, 11 + i);
                Console.Write(" ");
            }
            Console.SetCursorPosition(10, ToaDoY + 11 + 3);
            for (int i = 0; i < 140; i++)
            {
                Console.Write(" ");
            }
            Console.CursorVisible = true;
            Console.SetCursorPosition(this.viTri.MaSoSinhVien + 2, ToaDoY + 12);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Ma So Sinh Vien: ");
            Console.SetCursorPosition(this.viTri.HoVaTenSinhVien + 2, ToaDoY + 12);
            Console.Write("Ho Va Ten Sinh Vien: ");
            Console.SetCursorPosition(this.viTri.DiemVan + 2, ToaDoY + 12);
            Console.Write("Diem Van: ");
            Console.SetCursorPosition(this.viTri.DiemToan + 2, ToaDoY + 12);
            Console.Write("Diem Toan: ");           
        }
        public void XoaDuLieuCuTrenManHinh(int ToaDoY)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(this.viTri.MaSoSinhVien + 19, ToaDoY + 2);
            for(int i =0; i < this.viTri.HoVaTenSinhVien - this.viTri.MaSoSinhVien - 19; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(this.viTri.HoVaTenSinhVien + 23, ToaDoY + 2);
            for (int i = 0; i < this.viTri.DiemVan - this.viTri.HoVaTenSinhVien - 23 ; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(this.viTri.DiemVan+12, ToaDoY + 2);
            for (int i = this.viTri.DiemVan + 1; i < this.viTri.DiemToan - 12; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(this.viTri.DiemToan+13, ToaDoY + 2);
            for (int i = this.viTri.DiemToan; i < this.viTri.Cuoi -13 ; i++)
            {
                Console.Write(" ");
            }
            Console.CursorVisible = true;
        }
        public void Error()
        {
            Console.SetCursorPosition(35, 25);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int i = 0; i < 90; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(35, 29);
            for (int i = 0; i < 90; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(35, 27);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Sinh vien vua nhap da co ma sinh vien trung voi cac sinh vien truoc. Yeu cau nhap lai!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ErrorSearchID()
        {
            Console.SetCursorPosition(35, 25);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int i = 0; i < 90; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(35, 29);
            for (int i = 0; i < 90; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(35, 27);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("khong tim thay sinh vien co chua id nay!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void menu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 0);
            for(int i = 0; i < 40; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(40, 10);
            for (int i = 0; i < 40; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.SetCursorPosition(40, i);
                Console.Write(" ");
                Console.SetCursorPosition(80, i);
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(45, 2);
            Console.Write("1. Xuat danh sach sinh vien");
            Console.SetCursorPosition(45, 4);
            Console.Write("2. Xuat DSSV co DTB Lon Hon so K");
            Console.SetCursorPosition(45, 6);
            Console.Write("3. Xem Thong Tin SV bang ID");
            Console.SetCursorPosition(45, 8);
            Console.Write("Nhap so lua chon: ");
            Console.SetCursorPosition(65, 8);            
        }
    }
}

