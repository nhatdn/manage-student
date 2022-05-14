using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string titleNhap = "NHAP THONG TIN SINH VIEN THU ";
            const string titleXuat = "XUAT DANH SACH THONG TIN CAC SINH VIEN ";
            const string titleXuatCoTimKiem = "XUAT DANH SACH THONG TIN CAC SINH VIEN CO DIEM TRUNG BINH LON HON HOAC BANG ";
            Console.CursorVisible = false;
            Console.WriteLine("Nhap so luong sinh vien: ");
            Student.SoLuongSinhVien = int.Parse(Console.ReadLine());
            Console.Clear();
            Student[] SV = new Student[Student.SoLuongSinhVien];
            GiaoDien x = new GiaoDien();
            x.GiaoDienTieuDeThongBaoNhap();
            x.GiaoDienThongTinSinhVien(5);
            Point S = new Point();
            S = x.ViTri;

            int[] a = new int[100];

            // Nhap danh sach sinh vien
            for (int i = 0; i < Student.SoLuongSinhVien; i++)
            {
                Student test = new Student();
                x.HienThiTieuDeNhap(titleNhap + (i + 1).ToString(), titleNhap.Length + 1);
                test.NhapThongTinSinhVien(S, 15);
                for (int j = 0; j < i; j++)
                {
                    while (test.MaSoSV == SV[j].MaSoSV)
                    {
                        x.Error();
                        x.XoaDuLieuCuTrenManHinh(15);
                        test.NhapThongTinSinhVien(S, 15);
                    }
                }
                Console.SetCursorPosition(70, 35);
                Console.WriteLine("                                                                                    ");
                SV[i] = test;
                x.XoaDuLieuCuTrenManHinh(15);
            }
            bool kt = true;
            Console.Clear();
            int n = 1;
            x.menu();
            n = int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                x.menu();
                switch (n)
                {
                    case 1:
                        {
                            //Xuat danh sach sinh vien


                            for (int i = 0; i < Student.SoLuongSinhVien; i++)
                            {
                                kt = false;
                                x.GiaoDienThongTinSinhVien(5 + 4 * i);
                                SV[i].TinhDiemTrungBinhMon();
                                SV[i].GiaoDienXuatThongTinSinhVien(S, 5 + 4 * i);
                            }
                            if (kt == false)
                            {
                                x.HienThiTieuDeXuat(titleXuat, titleNhap.Length);
                                x.GiaoDienTieuDeThongBaoXuat();
                            }
                            Console.CursorVisible = false;
                            break;
                        }
                    case 2:
                        {
                            //xuat danh sach sinh vien co diem trung binh lon hon k
                            Console.Clear();
                            Console.Write("Nhap gia tri k: ");
                            double SearchByDiem = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            x.HienThiTieuDeXuat(titleXuatCoTimKiem + SearchByDiem.ToString(), titleXuatCoTimKiem.Length - 1);
                            x.GiaoDienTieuDeThongBaoXuat();
                            int y = 0;
                            for (int i = 0; i < Student.SoLuongSinhVien; i++)
                            {
                                SV[i].TinhDiemTrungBinhMon();
                                if (SV[i].DiemTB >= SearchByDiem)
                                {
                                    x.GiaoDienThongTinSinhVien(5 + 4 * y);
                                    SV[i].GiaoDienXuatThongTinSinhVien(S, 5 + 4 * y);
                                    y++;
                                }
                            }
                            Console.CursorVisible = false;
                            break;
                        }
                    case 3:
                        {
                            //xuat thong tin sinh vien tim bang id
                            const string titleXuatCoTimKiemBangID = "XUAT THONG TIN SINH VIEN CO ID LA: ";
                            Console.Clear();
                            Console.Write("Nhap ID can tim: ");
                            string SearchByID = Console.ReadLine();
                            Console.Clear();
                            x.HienThiTieuDeXuat(titleXuatCoTimKiemBangID + SearchByID, titleXuatCoTimKiemBangID.Length + SearchByID.Length);
                            x.GiaoDienTieuDeThongBaoXuat();
                            bool check = true;
                            for (int i = 0; i < Student.SoLuongSinhVien; i++)
                            {
                                if (SV[i].MaSoSV == SearchByID)
                                {
                                    check = false;
                                    x.GiaoDienThongTinSinhVien(5);
                                    SV[i].TinhDiemTrungBinhMon();
                                    SV[i].GiaoDienXuatThongTinSinhVien(S, 5);
                                    break;
                                }
                            }
                            if (check == true)
                            {
                                x.ErrorSearchID();
                            }
                            Console.CursorVisible = false;
                            break;
                        }
                }
                x.menu();
                Console.CursorVisible = true;
                n = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}