using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien
{
    class Diemmonhoc
    {
        public double diemlaptrinh { get; set; }
        public double diemcosodulieu { get; set; }
        public double diemlaprap { get; set; }
        public double diemgiaithuat { get; set; }
        public Diemmonhoc(double diemlaptrinh, double diemcosodulieu, double diemlaprap, double diemgiaithuat)
        {
            this.diemlaptrinh = diemlaptrinh;
            this.diemcosodulieu = diemcosodulieu;
            this.diemlaprap = diemlaprap;
            this.diemgiaithuat = diemgiaithuat;
        }
        public Diemmonhoc()
        {

        }
        public void nhapdiem()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNHAP DIEM SINH VIEN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Nhap diem mon lap trinh c#: ");
            diemlaptrinh = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon tin hoc: ");
            diemcosodulieu = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon co so du lieu: ");
            diemlaprap = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon Lap rap may tinh: ");
            diemgiaithuat = double.Parse(Console.ReadLine());
        }

    }
}
