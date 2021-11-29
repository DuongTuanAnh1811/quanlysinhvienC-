using System.Text.RegularExpressions;

namespace Kethua { 
    class Program
    {
        #region ke thua
        public static double coutcar = 0;
        public class Car
        {
            private string _color;
            private string _version;
            private double _mass;


            //public Car(string mau , string phienban , double can)
            //{
            //    _color = mau;
            //    _version = phienban;
            //    _mass = can;
            //    coutcar++;

            //}
            public virtual void nhap()
            {
                Console.Write("nhap mau sac ");
                _color = Console.ReadLine();
                Console.Write("nhap phien ban ");
                _version = Console.ReadLine();
                Console.Write("nhap trong luong ");
                _mass = isCheckNhap();


            }
            public double isCheckNhap()
            {
                while (true)
                {
                    try
                    {
                        return double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai dinh dang moi nhap lai");
                    }
                }
            }
            public virtual void Xuat()
            {
                Console.WriteLine("mau sac " + _color);
                Console.WriteLine("phien ban " + _version);
                Console.WriteLine("trong luong " + _mass);

            }
        }
        public class CarToyota : Car
        {
            private string _function;
            private double _money;
            //public CarToyota (string mau, string phienban, double can, string _function, double _money ) :base(mau, phienban, can)
            //{
            //    this._function = _function;
            //    this._money = _money;

            //}
            //public void NhapToyota()
            //{
            //    base.nhap();
            //    Console.Write("nhap chuc nang ");
            //    _function = Console.ReadLine();
            //    Console.Write("nhap gia ");
            //    _money = double.Parse(Console.ReadLine());
            //}
            //public void XuatToyota()
            //{
            //    base.Xuat();
            //    Console.WriteLine("gia da tinh thue cua toyota " + ThueToyota());
            //}
            public override void nhap()
            {
                base.nhap();
                Console.Write("nhap chuc nang ");
                _function = Console.ReadLine();
                Console.Write("nhap gia ");
                _money = isCheckNhap();
            }
            public double ThueToyota()
            {
                double thue = 0.2;
                double gia = _money + _money * thue;
                return gia;
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine("gia da tinh thue cua toyota " + ThueToyota());
            }

        }
        #endregion
        #region static
        public static class tinhtoan
        {
            public static double tong(int a, int b)
            {
                return a + b;
            }

        }
        #endregion
        #region da hinh 
        abstract class Animal
        {
            public virtual void Speak()
            {
                //Console.WriteLine("dong vat keu");
            }
        }
        class Cat : Animal
        {
            public override void Speak()
            {
                base.Speak();

            }
            public void SpeakMeo()
            {
                base.Speak();
                Console.WriteLine("meo keu meo meo");
            }
        }
        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("cho keu gau gau");
            }
        }
        #endregion
        #region vi du1
        class Person
        {
            protected string _name;
            protected int _age;
            protected string _sex;
            protected int check;

            public virtual void Nhap()
            {
                Console.Write("nhap ten ");
                _name = Check5();
                Console.Write("nhap tuoi ");
                _age = Check1();
                Console.Write("nhap gioi tinh ");
                _sex = CheckSex();

            }
            public string CheckSex()
            {
                while (true)
                {
                    try
                    {
                        string sex = Console.ReadLine();
                        sex = sex.ToLower();
                        if (sex.Equals("nam") || sex.Equals("nu"))
                        {
                            return sex;
                        }
                        else
                        {
                            Console.WriteLine("nhap sai moi nhap lai");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public string Check6()
            {
                while (true)
                {
                    try
                    {
                        string chuoi = Console.ReadLine();

                        if (Regex.IsMatch(chuoi, @"\d[a-zA-Z]"))
                        {
                            return chuoi;
                        }
                        else
                        {
                            Console.WriteLine("nhap sai moi nhap lai");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public string Check5()
            {
                while (true)
                {
                    try
                    {
                        string chuoi = Console.ReadLine();

                        if (Regex.IsMatch(chuoi, "[a-zA-z][^0-9]")) //tra ve true neu chuoi co ki tu tu a-z
                        {
                            return chuoi;
                        }
                        else
                        {
                            Console.WriteLine("nhap sai moi nhap lai");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public int Check2()
            {
                while (true)
                {
                    try
                    {
                        int gioitinh = int.Parse(Console.ReadLine());
                        if (gioitinh == 0 || gioitinh == 1)
                        {
                            return gioitinh;
                        }
                        else
                        {
                            Console.WriteLine("nhap sai moi nhap lai");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public int Check1()
            {
                while (true)
                {
                    try
                    {
                        return int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public double Check()
            {
                while (true)
                {
                    try
                    {
                        return double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public virtual void Xuat()
            {
                Console.WriteLine("ten cua ban: " + _name);
                Console.WriteLine("tuoi cua ban: " + _age);
                Console.WriteLine("gioi tinh cua ban " + _sex);
            }
        }
        class Student : Person
        {
            protected string _class;
            protected double _diemtoan;
            protected double _diemly;
            protected double _diemhoa;

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("nhap ten lop: ");
                _class = Check6();
                Console.Write("nhap diem toan: ");
                _diemtoan = Check();
                Console.Write("nhap diem ly: ");
                _diemly = Check();
                Console.Write("nhap diem hoa: ");
                _diemhoa = Check();

            }
            public double DiemTB()
            {
                return (_diemhoa + _diemly + _diemly) / 3;
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine("ten lop: " + _class);
                Console.WriteLine("diem toan: " + _diemtoan);
                Console.WriteLine("diem ly: " + _diemly);
                Console.WriteLine("diem hoa: " + _diemhoa);
                Console.WriteLine("diem trung binh: " + DiemTB());
            }

        }
        class Teacher : Person

        {
            protected double _money;
            protected float _heso;
            protected int _chuyenmon;

            public int check3()
            {
                while (true)
                {
                    try
                    {
                        int chuyenmon = int.Parse(Console.ReadLine());
                        if (chuyenmon == 0 || chuyenmon == 1 || chuyenmon == 2)
                        {
                            return chuyenmon;
                        }
                        else
                        {
                            Console.WriteLine("nhap sai moi nhap lai");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }
            public float CheckHeSo()
            {
                while (true)
                {
                    try
                    {
                        float heso = float.Parse(Console.ReadLine());
                        return heso;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
            }

            public override void Nhap()
            {
                base.Nhap();
                Console.WriteLine("moi ban nhap chuyen mon 0:giao vien   1:thu quy   2:hieu pho ");
                _chuyenmon = check3();
                Console.WriteLine("moi ban nhap luong co ban ");
                _money = Check();
                Console.WriteLine("moi ban nhap he so ");
                _heso = CheckHeSo();

            }
            public double Luong()
            {
                return _heso * _money;
            }
            public override void Xuat()
            {
                base.Xuat();
                switch (_chuyenmon)
                {
                    case 0:
                        Console.WriteLine("ban la giao vien");
                        break;
                    case 1:
                        Console.WriteLine("ban la thu quy ");
                        break;
                    case 2:
                        Console.WriteLine("ban la hieu pho ");
                        break;
                }
                Console.WriteLine("luong cua ban la " + Luong());

            }


        }
        public static int check4()
        {
            while (true)
            {
                try
                {
                    int vaitro = int.Parse(Console.ReadLine());
                    if (vaitro == 0 || vaitro == 1)
                    {
                        return vaitro;
                    }
                    else
                    {
                        Console.WriteLine("nhap sai moi nhap lai");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai moi nhap lai");
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region
            //CarToyota car = new CarToyota();
            //car.nhap();
            //car.Xuat();
            //tinhtoan.tong(2, 3);
            //Cat cat = new Cat();
            //cat.SpeakMeo();
            //Dog dog = new Dog();
            //dog.Speak();
            #endregion
           
            int check;
            Console.Write("moi ban nhap 0:student       1:teacher ");
            check = check4();


            if (check == 0)
            {
                int count = 0;
                Console.WriteLine("ban la student");
                Console.WriteLine("moi ban nhap du lieu");
                Console.Write("nhap so luong sinh vien ");
                int n = int.Parse(Console.ReadLine());
                Student[] st = new Student[n];
                for (int i = 0; i < n; i++)
                {

                    st[i] = new Student();
                    st[i].Nhap();
                    count++;
                }
                Console.WriteLine("----danh sach {0} sinh vien---", count);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(" sinh vien thu {0}", i + 1);

                    st[i].Xuat();
                }
            }
            else
            {
                int count = 0;
                Console.WriteLine("ban la teacher");
                Console.WriteLine("moi ban nhap du lieu");
                Console.Write("nhap so luong giao vien ");
                int n = int.Parse(Console.ReadLine());
                Teacher[] tc = new Teacher[n];
                for (int i = 0; i < n; i++)
                {

                    tc[i] = new Teacher();
                    tc[i].Nhap();
                    count++;
                }
                Console.WriteLine("----danh sach {0} giao vien---", count);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(" giao vien thu {0}", i + 1);

                    tc[i].Xuat();
                }
            }
            
            Console.ReadKey();

        }
    }

}

