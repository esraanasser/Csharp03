namespace demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region value type casting
            #region implicit casting 
            //int X = 4;
            //long Y = (long)X;

            #endregion

            #region explicit casting
            // long X = 1010101010101010;// 8byte
            //int Y;
            //checked
            //{
            //    Y = (int)X;

            //}
            //Console.WriteLine(Y);
            //int X = 88;
            //double Y = (double)X;
            //double X = 88.8;
            //int Y = (int)X;
            //Console.WriteLine(Y);

            #endregion

            #region parse
            // int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter data user");
            //Console.WriteLine("Enter Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.Write("Enter salary : ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Name :" + Name + "Age : " + Age + "salary : " + salary);
            #endregion

            #region convert

            //Console.WriteLine("Enter data user");
            //Console.WriteLine("Enter Name : ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter salary : ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Name :" + Name + "Age : " + Age + "salary : " + salary);

            #endregion

            #region operators
            #region unary operators [++ , --]
            //int X = 5;
            // x++
            //++x
            // Console.WriteLine(++x);
            //Console.WriteLine(x++);
            //Console.WriteLine(--x);
            //Console.WriteLine(X--);


            #endregion

            #region binary operators
            //int Sum, Mul, Sub, Div, Mod;
            //int A = 10;
            //int B = 5;

            //Sum = A+ B; 

            //Sub = B - A;
            //Div = A/B;
            //Mod = A%B;
            //Mul = A * B;

            //Console.WriteLine(Sum);


            #endregion

            #region assignment operators

            //int X = 10;

            //X += 10;

            #endregion

            #region relational
            //int A = 10;
            //int B = 5;
            // Console.WriteLine(A < B);

            #endregion

            #region logiacal
            //Console.WriteLine(!true);
            //Console.WriteLine(true && false);
            // true && true => true
            // true && false => false
            // false && false => false
            // false && true => false





            //Console.WriteLine(true || false);
            // true || true => true
            // true || false => true
            // false || false => false
            // false || true => true

            #endregion

            #region bitwise
            //Console.WriteLine(true & false);
            // true & true => true
            // true & false => false
            // false & false => false
            // false & true => false





            //Console.WriteLine(true | false);
            // true | true => true
            // true | false => true
            // false | false => false
            // false | true => true

            #endregion

            #region ternary operator
            //int X = 4;

            //string Massege = X > 4 ? "greater than 4" : "less than or = 4";
            //Console.WriteLine(Massege);
            #endregion


            #region operators priority
            /*
             1.unary operators
            2.()
            3. * / %
            4. + - 
             
             */

            //int A = 20;
            //int B = 15;
            //int C = 10;
            //int D = 5;

            //int Result;

            //Result = (A + B) * C / D;
            //Result = A++ * C;
            //Result = A * C;
            //Console.WriteLine(Result);


            #endregion
            #endregion

            #region string formating
            // Equation = X + Y = Result
            // Equation = 10 + 5 = 15

            //int X = 5;
            //int Y = 10;
            //int Result = X + Y;
            //Console.WriteLine("Equation : " + X + "+"  + Y + "=" + Result);
            // string => immutable datatype

            //string Name = "Ahmed";
            //Console.WriteLine(Name);
            //Name = "Ali";
            #region composite formate
            //string Message = string.Format("Equation = {0} + {1} = {2}", X, Y, Result);
            //Console.WriteLine(Message);
            //Console.WriteLine("Equation = {0} + {1} = {2}", X, Y, Result);
            #endregion

            #region string manpilation
            // string interpolation
            // Console.WriteLine($"Equation : {X} + {Y} = {Result}");

            #endregion
            #endregion

            #region if else switch case
            //Console.WriteLine("Enter Month Number ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            // 1 => month is jan
            // 2 => month is feb
            // 3 => month is mar
            // invalid input

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("month is jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("month is feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("month is mar");
            //}
            //else {
            //    Console.WriteLine("invalid input");
            //}

            //switch (MonthNumber) {
            //case 1:
            //        Console.WriteLine("month is jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("month is feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("month is mar");
            //        break;
            //    default:
            //        Console.WriteLine("invalid input");
            //        break;
            //}

            //Console.WriteLine("enter name");
            //string Name = Console.ReadLine();

            //if (Name == "mostafa") {
            //    Console.WriteLine("hello mostfa");
            //}
            //else if (Name == "esraa")
            //{
            //    Console.WriteLine("hello esraa");
            //}
            //else if (Name == "ahmed")
            //{
            //    Console.WriteLine("hello ahmed");
            //}

            //switch (Name) {
            //    case "mostafa":
            //        Console.WriteLine("hello mostfa");
            //        break;

            //    case "esraa":
            //        Console.WriteLine("hello esraa");
            //        break;
            //    case "ahmed":
            //        Console.WriteLine("hello ahmed");
            //        break;
            //}

            #endregion

            #region goto
            // Console.WriteLine("enter option ");
            // 3000 => "option 01" , "option 02" , "option 03"
            // 2000 => "option 01" , "option 02"
            // 1000 => "option 01" 

            //int Option = int.Parse(Console.ReadLine());

            //switch (Option) {
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;




            //}

            #endregion

            #region evaluation of switch
            #region #06
            //Console.WriteLine("enter age");
            //int Age = int.Parse(Console.ReadLine());

            //switch (Age) {
            //    case > 22:
            //        Console.WriteLine("Age greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Age less than 22");
            //        break;

            //    default:
            //        Console.WriteLine("Age = 22");
            //        break;


            //}
            #endregion

            #region #07
            //object obj = new object();
            //obj = "Mostafa";
            //obj = 10;
            //obj = true;

            //switch (obj) {
            //    case int Number:
            //        Console.WriteLine($"{Number} is int");
            //        break;

            //    case string Name:
            //        Console.WriteLine($"{Name} is string");
            //        break;
            //    case bool Flag:
            //        Console.WriteLine($"{Flag} is bool");
            //        break;
            //}


            #endregion

            #region #08
            #region ex01
            //Console.WriteLine("Enter Option");
            //int Option = int.Parse(Console.ReadLine());

            //string Message = Option switch
            //{
            //    1 => "option 01",//Constant pattern
            //    2 => "option 02",
            //    3 => "option 03",
            //    _ => "Invalid",//Discard pattern

            //};
            //Console.WriteLine(Message);

            #endregion
            #region ex02
            //Employee E01 = new Employee();
            //E01.Name = "Ali";
            //E01.Id = 10;
            //E01.Age = 22;

            //string Message = E01 switch
            //{
            //    // proparty pattern
            //    { Id: 10, Name: "Alaa", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { Id: 10, Name: "Ali", Age: 22 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { Id: 10, Name: "Mona", Age: 20 } => $"{E01.Id} : {E01.Name} : {E01.Age}",

            //};

            #endregion
            #endregion

            #region #09
            //Employee E01 = new Employee();
            //E01.Name = "Ali";
            //E01.Id = 10;
            //E01.Age = 22;

            //string Message = E01 switch
            //{
            //    // proparty pattern
            //    {  Age: > 22 and < 25 } => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    { Age: 22  or 23} => $"{E01.Id} : {E01.Name} : {E01.Age}",
            //    {  Age: 20 } => $"{E01.Id} : {E01.Name} : {E01.Age}",

            //};
            #endregion

            #endregion
            #endregion
        }
    }
}
