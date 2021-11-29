namespace Derived
{
    class Program 

    {
        public int CheckSoNguyen()
        {
            while (true)
            {
                try
                {
                    int songuyen =int.Parse(Console.ReadLine());
                    return songuyen;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nhap sai dinh dang moi nhap lai");
                }
            }
        }
        static void Main(string[] ards)
        {
           
            int count = 0;

            Console.Write("nhap so luong sinh vien ");
            int n = int.Parse(Console.ReadLine());
           
                Student[] st = new Student[n];
                
                        Console.WriteLine("\n1. Them sinh vien.");
                        for (int i = 0; i < st.Length; i++)
                        {
                            st[i] = new Student();
                            st[i].Nhap();
                            count++;

                        }
                        Console.WriteLine("\nThem {0} sinh vien thanh cong!", count);
                        for (int i = 0; i < st.Length; i++)
                        {

                                 Console.WriteLine("sinh vien thu {0}", i + 1);
                                 st[i].Xuat();
                        }
                 
           

            Console.ReadKey();

        }
    }

}
