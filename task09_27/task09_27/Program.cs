//Task-1
//Console.WriteLine("4 reqemli eded daxil edin");
//int num = int.Parse(Console.ReadLine());
//if (num > 1000 && num < 9999)
//{
//    int teklik = num % 10;
//    int onluq = ((num / 10) % 10) * 10;
//    int yuzluk = (num / 100) * 100;
//    int minlik = (num / 1000) * 1000;
//    Console.WriteLine($"{teklik} + {onluq} + {yuzluk} + {minlik}");
//}
//else
//{
//    Console.WriteLine("eded 4 reqemli deyil");
//}



//Task-2
//Console.WriteLine("3 reqemli eded daxil edin:");

//int num = int.Parse(Console.ReadLine());

//int teklik = num % 10;
//int onluq = (num / 10) % 10;
//int yuzluk = num / 100;
//bool MertebelerFerqlidir = false;

//if (teklik != onluq && yuzluk != onluq && teklik != onluq)
//{
//    MertebelerFerqlidir = true;
//    Console.WriteLine("Ferqlidir");
//}
//else
//{
//    Console.WriteLine("Eynidir");
//}



//Task-3
//int a, b, temp;

//Console.Write("a daxil edin");
//if (int.TryParse(Console.ReadLine(), out a))
//{
//    Console.Write("b daxil edin");
//    if (int.TryParse(Console.ReadLine(), out b))
//    {
//        temp = a;
//        a = b;
//        b = temp;

//        Console.WriteLine("a: " + a);
//        Console.WriteLine("b: " + b);
//    }
//    else
//    {
//        Console.WriteLine("b-sehvdir");
//    }
//}
//else
//{
//    Console.WriteLine("a-sehvdir");
//}

//Console.ReadLine();



//Task-4
//Console.WriteLine("Yasinizi daxil edin");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Telebedirse 'true', deyilse 'false'");
//bool IsStudent = bool.Parse(Console.ReadLine());

//double TicketPrice = 0.0d;

//if(age <= 12 || age >= 60)
//{
//    Console.WriteLine("Qiymete uygundur");
//    TicketPrice = 5.0;
//}
//else if(age >- 13 && age <= 59)
//{
//    if (IsStudent)
//    {
//        TicketPrice = 7.5;
//    }
//    else
//    {
//        TicketPrice = 10.0;
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}
//Console.WriteLine("Bilet qiymeti" + TicketPrice + "azn");