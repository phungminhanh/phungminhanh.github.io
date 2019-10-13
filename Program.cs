using System;

namespace ConsoleApp1
{
    class Program
    {
        static void splitOFmonnrey()
        {
            
            long? Monney = null;
            while (Monney == null)
            {
                Console.WriteLine("nhap so tien can tinh:");
                Monney = Convert.ToInt32(Console.ReadLine());
                while (Monney % 1000 != 0 || Monney <= 0)
                {
                    Console.WriteLine("khong hop le nhap lai");
                    Monney = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int tien1000 = 1; Monney - 1000 >= 0; tien1000++)
            {
                Monney = Monney - 1000;
                Console.WriteLine("dung " + tien1000 + " loai tien 1000");
                Console.WriteLine("so tien con lai la" + Monney);
                if (Monney - 1000 == 0)
                {
                    Console.WriteLine($"di den truong hop cuoi cung :dung { tien1000 + 1}  loai tien 1000 ket thuc chuong trinh");
                    break;
                }
                for (int tien2000 = 1; Monney - 2000 >= 0; tien2000++)
                {
                    Monney = Monney - 2000;
                    Console.WriteLine("dung " + tien2000 + " loai tien 2000");
                    Console.WriteLine("so tien con lai la" + Monney);
                    if (Monney == 0 || Monney - 2000 < 0)
                    {
                        Monney = Monney + tien2000 * 2000;
                        Console.WriteLine("tra lai" + Monney);
                        Console.WriteLine("di den truong hop tiep theo");
                        break;
                    }
                    for (int tien5000 = 1; Monney - 5000 >= 0; tien5000++)
                    {
                        Monney = Monney - 5000;
                        Console.WriteLine("dung " + tien5000 + " loai tien 5000");
                        Console.WriteLine("so tien con lai la" + Monney);
                        if (Monney == 0 || Monney - 5000 < 0)
                        {
                            Monney = Monney + tien5000 * 5000;
                            Console.WriteLine("tra lai" + Monney);
                            Console.WriteLine("di den truong hop tiep theo");
                            break;
                        }
                        for (int tien10000 = 1; Monney - 10000 >= 0; tien10000++)
                        {
                            Monney = Monney - 10000;
                            Console.WriteLine("dung " + tien10000 + " loai tien 10000");
                            Console.WriteLine("so tien con lai la" + Monney);
                            if (Monney == 0 || Monney - 10000 < 0)
                            {
                                Monney = Monney + tien10000 * 10000;
                                Console.WriteLine("tra lai" + Monney);
                                Console.WriteLine("di den truong hop tiep theo");
                                break;
                            }
                            for (int tien20000 = 1; Monney - 20000 >= 0; tien20000++)
                            {
                                Monney = Monney - 20000;
                                Console.WriteLine("dung " + tien20000 + " loai tien 20000");
                                Console.WriteLine("so tien con lai la" + Monney);
                                if (Monney == 0 || Monney - 20000 < 0)
                                {
                                    Monney = Monney + tien20000 * 20000;
                                    Console.WriteLine("tra lai" + Monney);
                                    Console.WriteLine("di den truong hop tiep theo");
                                    break;
                                }


                            }


                        }


                    }

                }
            }
            /*for (int count1000 = 1; Monney > 0; count1000++)
            {

                Monney = Monney - 1000;
                s = (int)Monney;
                Console.WriteLine("dung" + count1000 + "to loai 1000");
                Console.WriteLine("tien con" + Monney);
               for (int count2000 = 1; Monney - 2000 >= 0; count2000++)
                {
                    Monney = Monney - 2000;

                    if (Monney == 0)
                    {
                        Console.WriteLine("dung" + count2000 + "to loai 2000");
                        Console.WriteLine("tien con" + Monney);
                        Monney = s;
                        break;
                    }
                    else if (Monney - 2000 < 0)
                    {
                        Monney = s;
                        Console.WriteLine("loai truong hop nay");
                        break;
                    }
                    s = (int)Monney;
                    for (int count5000 = 1; Monney - 5000 >= 0; count5000++)
                    {
                        Monney = Monney - 5000;

                        if (Monney == 0)
                        {
                            Console.WriteLine("dung" + count5000 + "to loai 5000");
                            Console.WriteLine("tien con" + Monney);
                            Monney = s;
                            break;
                        }
                        else if (Monney - 2000 < 0)
                        {
                            Monney = s;
                            Console.WriteLine("loai truong hop nay");
                            break;
                        }

                    }

                }*/
        }
    

            static void Main(string[] args)
            {
                splitOFmonnrey();

            }
        
    }
}