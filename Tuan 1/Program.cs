using System;
namespace Tuan1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap bai can lam: ");
            int a=int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    bai1();
                    break;
                case 2:
                    bai2();
                    break;
                case 3:
                    bai3();
                    break;
                case 4:
                    bai4();
                    break;
                case 5:
                    bai5();
                    break;
                case 6:
                    bai6();
                    break;
                case 7:
                    bai7();
                    break;
                case 8:
                    bai8();
                    break;
                case 9:
                    bai9();
                    break;
                case 10:
                    bai10();
                    break;
            }
            void bai1()
            {
                Console.Write("nhap ten cua ban: ");
                string ten=Console.ReadLine();

                Console.Write("Nhap tuoi cua ban: ");
                int tuoi=int.Parse(Console.ReadLine());
                Console.WriteLine("xin chao " + ten + " " + tuoi + " tuoi");
            }
            void bai2()
            {
                double dientich = 0;
                while(true)
                {
                    try
                    {
                        Console.Write("nhap chieu dai: ");
                        double chieudai = double.Parse(Console.ReadLine());
                        Console.Write("nhap chieu rong: ");
                        double chieurong = double.Parse(Console.ReadLine());
                        dientich = chieudai * chieurong;
                        if(chieudai<=0 && chieurong<=0)
                        {
                            throw new ArgumentException("so phai lon hon 0");
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ban phai nhap mot so hop le");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }    
                Console.WriteLine("dien tich hinh chu nhat la: "+dientich);
                
            }
            void bai3()
            {
                while(true)
                {
                    try
                    {
                        Console.Write("nhap do C: ");
                        double C = double.Parse(Console.ReadLine());
                        double F = (C * 9 / 5) + 32;
                        Console.WriteLine(C + " do C khi chuyen sang do F la: " + F);
                        break;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                }    
            }
            void bai4()
            {
                int a=0;
                while (true)
                {
                    try
                    {
                        Console.Write("nhap 1 so nguyen bat ki: ");
                        a = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                } 
                    
                if (a % 2 == 0)
                    Console.WriteLine(a + " la so chan");
                else
                    Console.WriteLine(a + " la so le");
            }
            void bai5()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("nhap x: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("nhap y: ");
                        double y = double.Parse(Console.ReadLine());
                        Console.WriteLine(x + " + " + y + " = " + (x + y));
                        Console.WriteLine(x + " * " + y + " = " + (x * y));
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                }    
            }
            void bai6()
            {
                while(true)
                {
                    try
                    {
                        Console.Write("nhap 1 so bat ki: ");
                        double a = double.Parse(Console.ReadLine());
                        if (a == 0)
                            Console.WriteLine(a + " la so khong");
                        else if (a < 0)
                            Console.WriteLine(a + " la so am");
                        else
                            Console.WriteLine(a + " la so duong");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                }    
            }
            void bai7()
            {
                while(true)
                {
                    try
                    {
                        Console.Write("nhap 1 nam bat ki: ");
                        int x = int.Parse(Console.ReadLine());
                        if(x<=0)
                        {
                            throw new ArgumentException("co ca nam am voi nam 0 co ak nhap lai !!!!");
                        }
                        if (x % 4 == 0)
                        {
                            if (x % 100 != 0)
                                Console.Write(x + " la nam nhuan");
                            else if (x % 100 == 0 && x % 400 == 0)
                                Console.Write(x + " la nam nhuan");
                        }
                        else
                            Console.Write(x + " k phai la nam nhuan");
                        break;

                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                    catch (ArgumentException ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                }    

            }
            void bai8()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("bang cu chuong " + i);
                    for(int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i + " * " + j + (" = ") + (i * j));
                    }    
                }    
            }
            void bai9()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("nhap 1 so nguyen duong: ");
                        int n = int.Parse(Console.ReadLine());
                        if(n<=0)
                        {
                            throw new ArgumentException("nhap 1 so nguyen duong");
                        }    
                        int tong = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            tong = tong * i;
                        }
                        Console.WriteLine("giai thua cua " + n + " = " + tong);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } 
                    
            }
            void bai10()
            {
                while(true)
                {
                    try
                    {
                        Console.Write("nhap 1 so bat ki: ");
                        int a = int.Parse(Console.ReadLine());
                        if (a<=1)    
                        {
                            throw new ArgumentException("nhap so lon hon 1");
                        }
                        for (int i = 2; i * i <= a; i++)
                        {
                            if (a % i == 0)
                            {
                                Console.WriteLine(a + " khong phai la so nguyen to");
                                return;
                            }
                        }
                        Console.WriteLine(a + " la so nguyen to");
                        break;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("nhap 1 so hop le");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }    
            }
        }
    }
}

