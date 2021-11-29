using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derived
{
    public class Student:Person
    {
        protected double _diemtoan;
        protected double _diemly;
        protected double _diemhoa;
        protected double _diemtb;
        protected string _hocluc;
        protected double _class;

        public double CheckNhapLop()
        {
            while (true)
            {
                try
                {
                    double _class = double.Parse(Console.ReadLine());
                    if (_class >= 10 && _class <= 12)
                    {
                        return _class;
                    }
                    else
                    {
                        Console.WriteLine("dlop phai tu lop 10 - lop 12");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai dinh dang moi nhap lai");
                }
            }
        }
        public double CheckNhapDiem()
        {
            while (true)
            {
                try
                {
                    double diem= double.Parse(Console.ReadLine());
                    if (diem >= 0 && diem <= 10)
                    {
                        return diem;
                    }
                    else
                    {
                        Console.WriteLine("diem phai 0 <= diem <=10 ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai dinh dang moi nhap lai"); 
                }
            }
        }
        public double DiemTB()
        {
            return (_diemtoan+_diemhoa+_diemly)/ 3;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("nhap lop ");
            _class = CheckNhapLop();
            Console.Write("nhap diem toan ");
            _diemtoan=CheckNhapDiem();
            Console.Write("nhap diem ly ");
            _diemly = CheckNhapDiem();
            Console.Write("nhap diem hoa ");
            _diemhoa = CheckNhapDiem();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("diem toan "+_diemtoan);
            Console.WriteLine("diem ly " + _diemly);
            Console.WriteLine("diem hoa " + _diemhoa);
            Console.WriteLine("diem trung binh " +DiemTB());
            if (DiemTB() >= 8)
            {
                _hocluc = "Gioi";
            }
            else if (DiemTB() >= 6.5)
            {
                _hocluc = "Kha";
            }
            else if (DiemTB() >= 5)
            {
                _hocluc = "Trung Binh";
            }
            else
            {
                _hocluc = "Yeu";
            }
            Console.WriteLine("hoc luc " + _hocluc);
            if (_hocluc.Equals("Gioi") || _hocluc.Equals("Kha") || _hocluc.Equals("Trung Binh"))
            {
                Console.WriteLine("ban duoc len lop");
            }
            else
            {
                Console.WriteLine("ban o lai lop");
            }
        }
    }
}
