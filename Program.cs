using System;
using System.Collections.Generic;
using System.Linq;

namespace Zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<spisok1> spisok3 = new List<spisok1>
            {
                new spisok1{Id=1 , country="Турция" },
                new spisok1{Id=2 , country="Египет" },
                new spisok1{Id=3 , country="Франция" },
                new spisok1{Id=4 , country="Испания" },
                new spisok1{Id=5 , country="Италия" }
            };
            List<spisok2> spisok4 = new List<spisok2>
            {
                new spisok2{id=1,name="Rivas",count=2,price=2*2000 },
                new spisok2{id=2,name="Sonesta",count=1,price=1*1600 },
                new spisok2{id=3,name="Remuri",count=3,price=3*2500 },
                new spisok2{id=4,name="Itolian",count=4,price=4*1500 },
                new spisok2{id=5,name="Marino",count=5,price=5*1900 },
            };
            var s1 = from a in spisok4
                     join i in spisok3 on a.id equals i.Id into c
                     from b in c.DefaultIfEmpty()
                     select new
                     {
                         nomer = b.Id,
                         name = a.name,
                         country = b.country,
                         count = a.count,
                         price = a.price
                     };
            Console.WriteLine("Индификатор путевки\tНазвание отеля\tСтрана\tКоличество\tЦена");
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (var s2 in s1)
            {
                Console.WriteLine(s2.nomer + "\t" + s2.name + "\t" + s2.country + "\t" + s2.count + "\t" + s2.price);
            }
            Console.WriteLine("Выберите по какому принципу сортировать");
            Console.WriteLine("1 - по суммарной цене путевок");
            Console.WriteLine("2 - по количеству путевок");
            string y= Console.ReadLine();
            char o = Convert.ToChar(y[0]);
            if (char.IsNumber(o))
            {
                int sss = Convert.ToInt32(o);
                sss = sss - 48;
                if (sss == 1)
                {
                    var s6 = s1.OrderBy(x => x.price);
                    foreach (var s2 in s6)
                    {
                        Console.WriteLine(s2.nomer + "\t" + s2.name + "\t" + s2.country + "\t" + s2.count + "\t" + s2.price);
                    }
                    Console.WriteLine("Введите номер строки, которую нужно удалить");
                    string q = Console.ReadLine();
                    char e = Convert.ToChar(q[0]);
                    if (char.IsNumber(e))
                    {
                        int w = Convert.ToInt32(e);
                        w = w - 48;
                        if (w > 0)
                        {
                            foreach (var s7 in s6)
                            {
                                if (s7.nomer != w)
                                {
                                    Console.WriteLine(s7.nomer + "\t" + s7.name + "\t" + s7.country + "\t" + s7.count + "\t" + s7.price);
                                }
                                else
                                {

                                }
                            }
                        }
                        
                    }
                }
                else if (sss == 2)
                {
                    var s6 = s1.OrderBy(x => x.count);
                    foreach (var s2 in s6)
                    {
                        Console.WriteLine(s2.nomer + "\t" + s2.name + "\t" + s2.country + "\t" + s2.count + "\t" + s2.price);
                    }
                    foreach (var s2 in s6)
                    {                        
                        Console.WriteLine("Введите номер строки, которую нужно удалить");
                        string q = Console.ReadLine();
                        char e = Convert.ToChar(q[0]);
                        if (char.IsNumber(e))
                        {
                            int w = Convert.ToInt32(e);
                            w = w - 48;
                            if (w > 0)
                            {
                                foreach (var s7 in s6)
                                {
                                    if (s2.nomer != w)
                                    {
                                        Console.WriteLine(s2.nomer + "\t" + s2.name + "\t" + s2.country + "\t" + s2.count + "\t" + s2.price);
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else { Console.WriteLine("Неккоректный ответ"); }
                        }
                        else { Console.WriteLine("Вы ввели не число"); }
                    }
                }
                else if (sss != 1 || sss != 2)
                {
                    { Console.WriteLine("Неккоректный ответ, сортировки не будет");
                        Console.WriteLine("Введите номер строки, которую нужно удалить");
                        string q = Console.ReadLine();
                        char e = Convert.ToChar(q[0]);
                        if (char.IsNumber(e))
                        {
                            int w = Convert.ToInt32(e);
                            w = w - 48;
                            if (w > 0)
                            {
                                foreach (var s2 in s1)
                                {
                                    if (s2.nomer != w)
                                    {
                                        Console.WriteLine(s2.nomer + "\t" + s2.name + "\t" + s2.country + "\t" + s2.count + "\t" + s2.price);
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else { Console.WriteLine("Неккоректный ответ"); }
                        }
                    }
                }
            }
            else { 
                     Console.WriteLine("Надо было ввести число, сортировки не будет");
                Console.WriteLine("Введите номер строки, которую нужно удалить");
                string q = Console.ReadLine();
                char e = Convert.ToChar(q[0]);
                if (char.IsNumber(e))
                {
                    int w = Convert.ToInt32(e);
                    w = w - 48;
                    if (w > 0)
                    {
                        foreach (var s2 in s1)
                        {
                            if (s2.nomer != w)
                            {
                                Console.WriteLine(s2.nomer + "\t" + s2.name + "\t" + s2.country + "\t" + s2.count + "\t" + s2.price);
                            }
                            else
                            {

                            }
                        }
                    }
                    else { Console.WriteLine("Неккоректный ответ"); }
                }
            }
            

        }
    }
}
