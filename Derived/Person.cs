using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Derived
{
    public class Person
    {
        protected int _id;
        protected string _name;
        protected double _age;
        protected string _sex;
        protected string _email;
        protected double _phone;
        protected string _address;
        protected string _city;

        public int CheckSoNguyen()
        {
            while (true)
            {
                try
                {
                    int songuyen = int.Parse(Console.ReadLine());
                    return songuyen;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai dinh dang moi nhap lai");
                }
            }
        }
        public string CheckNhapChuoi()
        {
            while (true)
            {
                try
                {
                    string chuoi = Console.ReadLine();
                    if (Regex.IsMatch(chuoi,@"[a-zA-Z]"))
                    {
                        return chuoi;
                    }
                    else
                    {
                        Console.WriteLine("nhap sai dinh dang moi nhap lai");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai dinh dang moi nhap lai");
                }
            }
        }
        public double CheckNhapTuoi()
        {
            while (true)
            {
                try
                {
                    double tuoi = double.Parse(Console.ReadLine());
                    return tuoi;
                }
                catch(Exception ex)
                {
                    Console.Write("nhap sai dinh dang moi nhap lai ");
                }
            }
        }
        public string CheckNhapSo()
        {
            while(true)
            {
                try
                {
                    string phone = Console.ReadLine();
                    if (phone.Length >= 9 && phone.Length <= 11)
                    {
                        return phone;
                    }
                    else
                    {
                        Console.Write("dien thoai dai tu 9 -11 so");
                    }
                }catch(Exception ex)
                {
                    Console.Write("nhap sai dinh dang moi nhap lai ");
                }
            }
        }
        public string CheckGioiTinh()
        {
            while (true)
            {
                try
                {
                    string sex = Console.ReadLine();
                    sex=sex.ToLower();
                    if (sex.Equals("nam") || sex.Equals("nu"))
                       {
                        return sex;
                    }
                    else
                    {
                        Console.WriteLine("nhap sai dinh dang moi nhap lai");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai dinh dang moi nhap lai");
                }
            }
        }
        public virtual void Nhap()
        {
            Console.Write("nhap id ");
            _id=CheckSoNguyen();
            Console.Write("nhap ten ");
            _name=CheckNhapChuoi();
            Console.Write("nhap tuoi ");
            _age = CheckNhapTuoi();
            Console.Write("nhap gioi tinh ");
            _sex = CheckGioiTinh();
            Console.Write("nhap email ");
            _email = CheckNhapChuoi();
            Console.Write("nhap dien thoai ");
            _phone = double.Parse(CheckNhapSo());
            Console.Write("nhap dia chi ");
            _address = CheckNhapChuoi();
            Console.Write("nhap thanh pho ");
            _city = CheckNhapChuoi();
        }
        public virtual void Xuat()
        {
           Console.WriteLine("id "+_id);
            Console.WriteLine("ten " + _name);
            Console.WriteLine("tuoi " + _age);
            Console.WriteLine("gioi tinh " + _sex);
            Console.WriteLine("email " + _email);
            Console.WriteLine("dien thoai " + _phone);
            Console.WriteLine("dia chi " + _address);
            Console.WriteLine("thanh pho "+_city);

        }
    }
   
}
