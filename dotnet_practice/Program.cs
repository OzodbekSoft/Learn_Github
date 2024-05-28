// using System.Text;

// string str = "This is very beautiful!";
// // string Methods 

// // Format() method
// // Console.WriteLine(string.Format("Hello {0}", 544545));

// // Split()  
// // var full = "Lazizbek Ozodbek Amirbek";
// // var arr = full.Split(' ');
// // Console.WriteLine(arr[0]);
// // // 2 ta sonni hisoblash 
// // var input = Console.ReadLine();
// // var inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// // Console.WriteLine(int.Parse(inputs[0]) + inputs[1]);

// // Original usul
// // var sum = Console.ReadLine()?
// //     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
// //     .Select(int.Parse)
// //     .Aggregate((x, y) => x + y);
// // Console.WriteLine("Yigindi = " + sum);

// // Substring()  
// // string? longStr = Console.ReadLine();
// // longStr = longStr.Substring(2);
// // Console.WriteLine(longStr);

// // Replace()
// // Console.WriteLine(str.Replace("is", "full", StringComparison.OrdinalIgnoreCase));
// // Console.WriteLine(str.Replace('i', 'a'));

// // Contains()  true || false
// // Console.WriteLine(str.Contains("i"));
// // Console.WriteLine(str.Contains("this", StringComparison.CurrentCultureIgnoreCase));


// // Join() 
// // Console.WriteLine(string.Join(',', ["Hello", " Salom", " Privet", " How"]));


// // Trim() - Bir matnni orqasi va oldidan ' ' spacelarni olish uchun ishlatiladi 
// // Console.WriteLine(str.Trim());


// // TrimEnd() & TrimStart()

// // Console.WriteLine(str.TrimStart());
// // Console.WriteLine(str.TrimEnd());

// // EndWith() & StartWith  true || false 
// // Console.WriteLine(str.ToLower().EndsWith("beautiful"));
// // Console.WriteLine(str.ToLower().StartsWith("this"));

// // Remove()
// // Console.WriteLine(str.Remove(4));

// // ToUpper() & ToLower ()
// // Console.WriteLine(str.ToLower());
// // Console.WriteLine(str.ToUpper());

// // IndexOf() & LastIndexOf() 
// // Console.WriteLine(str.IndexOf('i'));
// // Console.WriteLine(str.LastIndexOf('u'));


// // PadLeft() & PadRight
// // Console.WriteLine(str.PadLeft(' '));
// // Console.WriteLine(str.PadRight(' '));

// // ToCharArray() 
// // var arr = str.ToCharArray();
// // Console.WriteLine(arr);

// // Compare() 
// // Console.WriteLine(string.Compare("A", "B"));

// // Equals()  true || false
// // Console.WriteLine(string.Equals('A', 'L'));

// // Append()  += dan yaxshiroq


// // var son = 0; 
// // var natija = son++;
// // Console.WriteLine(++son);
// // Console.WriteLine(natija);


// // var son = (char) Console.Read();

// // 17 - misol 
// Console.Write("Son kiriting: ");
// int son = int.Parse(Console.ReadLine());
// string toSatr = son.ToString();
// string natija = string.Join("!", toSatr.ToCharArray());
// Console.WriteLine(natija);

// // 18-masala
// Console.Write("Sekundni kiriting: ");
// int n = int.Parse(Console.ReadLine());
// int soat = n / 3600; 
// int minut = n % 3600 / 60;
// int second = n % 60;
// Console.WriteLine($"{soat:d2}:{minut:d2}:{second:d2}");

// // 21 - masala
// Console.Write("N: ");
// double n = double.Parse(Console.ReadLine());
// double pi = 3.14;
// double r = n;
// double L = 2 * pi * r;
// double S = pi * r * r;
// Console.WriteLine($"Doiraning uzunligi: {L}");
// Console.WriteLine($"Doiraning yuzi: {S}");


// // 23 - masala
// Console.Write("Belgi kiriting: ");
// var belgi = (char) Console.Read();
// if (belgi >= 65 && belgi <= 95 || belgi >= 97 && belgi <= 123) 
//     Console.WriteLine(1);
// else 
//     Console.WriteLine(0);


// // 24 - masala
// Console.Write("Son 1: ");
// int son1 = int.Parse(Console.ReadLine());
// Console.Write("Son 2: ");
// int son2 = int.Parse(Console.ReadLine());
// if (son1 > son2)
//     Console.WriteLine($"Katta son = {son1}");
// else Console.WriteLine($"Katta son = {son2}");


// 26 - masala 
// Console.Write("Son 1: ");
// int son1 = int.Parse(Console.ReadLine());
// Console.Write("Son 2: ");
// int son2 = int.Parse(Console.ReadLine());
// Console.Clear();
// if (son1 > son2) 
// {
//     Console.WriteLine($"Katta son = {son2}\n");
//     Console.WriteLine($"Natija = {son1 / son2}");
//     Console.WriteLine($"Qoldiq = {son1 % son2}");
// }
// else 
// {
//     Console.WriteLine($"Katta son = {son2}\n");
//     Console.WriteLine($"Natija = {son2 / son1}");
//     Console.WriteLine($"Qoldiq = {son2 % son1}");
// }


// 27 - misol
// Console.WriteLine("Wahid amaki budilnik qo'yishlari kerak⏰");
// Console.Write("Vaqtni kiriting: ");
// string[] vaqt = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int S = int.Parse(vaqt[0]);
// int M = int.Parse(vaqt[1]);
// int soat = 0;
// int minut;
// if (M >= 45)
// {
//     soat = S;
//     minut = M - 45;
// }
// else
// {
//     if (S == 0) soat = 23;
//     else minut = S - 1;
//     minut = M + 15;
// }
// Console.WriteLine($"{soat}:{minut} da budilnik qo'yish kerak");


// // 28 - masala
// Console.Write("Haroratni kiriting: ");
// int n = int.Parse(Console.ReadLine());
// if (n < 0) 
//     Console.WriteLine("Ichkarida o'yna!");
// else if (n > 0 && n < 40) 
//     Console.WriteLine("Tashqarida o'yna!");
// else if (n > 40) 
//     Console.WriteLine("Ichkarida o'yna havo juda issiq!");


// // 29 - misol 
// Console.Clear();
// Console.WriteLine("Ikkita sonni baravar kiriting >> Misol uchun: 2  3 ");
// Console.Write("Ikkita sonni kiriting: ");
// string[] sonlar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int son1 = int.Parse(sonlar[0]);
// int son2 = int.Parse(sonlar[1]);
// if (son1 / 2 == son2) 
//     Console.WriteLine($"{son2} * {son2} = {son2 * son2}");
// else if (son2 / 2 == son1)
//     Console.WriteLine($"{son1} * {son1} = {son1 * son1}");
// else 
//     Console.WriteLine($"{son1} * {son2} = {son1 * son2}");


// // 30 - masala
// Console.Clear();
// Console.WriteLine("Uchta sonni baravar kiriting >> Misol uchun: 1  2  3 ");
// Console.Write("Ikkita sonni kiriting: ");
// string[] sonlar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int son1 = int.Parse(sonlar[0]);
// int son2 = int.Parse(sonlar[1]);
// int son3 = int.Parse(sonlar[2]);
// int max = son1;
// if (max < son2)
//     max = son2;
// if (max < son3) 
//     max = son3; 
// Console.WriteLine($"Eng katta son = {max}");


// // 31 - masala
// Console.Write("Sonni kiriting: ");
// int son = int.Parse(Console.ReadLine());
// string res = "";
// if (son % 2 == 0 && son % 3 == 0 && son % 5 == 0) res = "A";
// else if (son % 2 == 0 && son % 3 == 0) res = "B";
// else if (son % 2 == 0 && son % 5 == 0) res = "C";
// else if (son % 3 == 0 && son % 5 == 0) res = "D";
// else if (son % 2 == 0 || son % 3 == 0 || son % 5 == 0) res = "E";
// else if (son % 2 != 0 && son % 3 != 0 && son % 5 != 0) res = "N";
// Console.WriteLine(res);

// // 32 - masala 
// Console.Write("Yilni kiriting: ");
// int yil = int.Parse(Console.ReadLine());
// if (yil % 4 == 0 && yil % 100 != 0 && yil % 400 == 0) 
//     Console.WriteLine("Kabisa yilini kiritdingiz🙌");
// else 
//     Console.WriteLine($"Kabisa yili emas bu {yil}❌");

// // 33 - misol 
// Console.Write("Random kiritng: ");
// int n = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Boya kiritgan soningiz uchdi. Endi uni qaytadan kiritasiz😉");
// qayta:
// Console.Write("Sonni toping: ");
// int son = int.Parse(Console.ReadLine());
//     if (son != n) goto qayta;
//     else Console.WriteLine("Malades o'yinni yorvordiz✅");


// // 34 - misol 
// Console.Write("Belgi kiriting: ");
// var belgi = (char) Console.Read();
// qayta:
// if (char.IsUpper(belgi))
//     Console.WriteLine($"{belgi} >> {char.ToLower(belgi)}");
// else if (char.IsLower(belgi)) 
//     Console.WriteLine($"{belgi} >> {char.ToUpper(belgi)}");
// else 
//     Console.WriteLine("none");

// using System.Numerics;

// public class Dars
// {
//     public static int CheckedAdd(int a, int b)
//     {
//         if (a >= int.MaxValue || b >= int.MaxValue) return -1; /// 215148484547
//         else return a + b;
//     }

//     public static BigInteger CleanNumber(string str) 
//     {
//         string result = "";
//         for(int i = 0; i < str.Length; i++)  // hello123 
//         {
//             if (char.IsDigit(str[i]))
//                 result += str[i];
//         }
//         return BigInteger.Parse(result);
//     }
//     public static void Main()
//     {
//         string son = Console.ReadLine();
//         System.Console.WriteLine(CleanNumber(son));
//     }
// }

// Console.Write("son: ");
// int son = int.Parse(Console.ReadLine());
// string toSatr = son.ToString();
// string natija = "";
// if (toSatr.Length < 5) 
//     natija = string.Join("0!", toSatr.ToCharArray());
// else 
//     natija = string.Join("!", toSatr.ToCharArray());
// Console.WriteLine(natija);


// using System.Numerics;
// public class Dars
// {
//     public static BigInteger AddTransections(string str1, string str2)
//     {
//         if (str1 == "" && str2 == "" || str1 == "\"\"" && str2 == "\"\"")
//             return 0;
//         else
//         {
//             BigInteger son = BigInteger.Parse(str1);
//             BigInteger son2 = BigInteger.Parse(str2);
//             BigInteger result = son + son2;
//             return result;
//         }
//     }
//     public static void Main()
//     {
//         string str = Console.ReadLine();
//         string str2 = Console.ReadLine();
//         Console.WriteLine(AddTransections(str, str2));
//     }
// }




// using System.Numerics;
// public class Dars
// {
//     public static BigInteger PredictPopulation(BigInteger initialPopulation, ref int growthRate, ref int years) 
//     {
//         return initialPopulation * BigInteger.Pow(1 + growthRate, years);
//     }
//     public static void Main() 
//     {
//         BigInteger initialPopulation = BigInteger.Parse(Console.ReadLine());
//         int growthRate = int.Parse(Console.ReadLine());
//         int years = int.Parse(Console.ReadLine());
//         Console.WriteLine(PredictPopulation(initialPopulation, ref growthRate, ref years));
//     }
// }





// using System.Formats.Tar;
// using System.Numerics;
// public class Dars
// {
//     public static BigInteger clearNumber(string str)
//     {
//         string result = "";
//         for(int i = 0; i < str.Length; i++)
//         {
//             if (char.IsDigit(str[i]))
//                 result += str[i];
//         }
//         return BigInteger.Parse(result);
//     }   
//     public static void Main() 
//     {
//        string str = Console.ReadLine();
//        Console.WriteLine(clearNumber(str));
//     }
// }



public class