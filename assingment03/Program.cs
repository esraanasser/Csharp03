namespace assingment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            /*
             1- Write a program that takes a number from the user then print 
            yes if that number can be divided by 3 and 4 otherwise print no.
             */
            //Console.WriteLine("enter number");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number == 12)
            //{
            //    Console.WriteLine("yes");
            //}
            //else {
            //    Console.WriteLine("no");
            //}


            #endregion

            #region 02
            /*
             2- Write a program that allows the user to insert an integer
            then print negative if it is negative number otherwise print positive.
             */
            //Console.WriteLine("insert an integer");
            //int Integer = int.Parse(Console.ReadLine());
            //if (Integer < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}


            #endregion

            #region 03
            /*
             Write a program that takes 3 integers
            from the user then prints the max element and the min element.
             */

            //Console.WriteLine("enter integer one");
            //int One = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter integer two");
            //int Two = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter integer three");
            //int Three = int.Parse(Console.ReadLine());


            //int Max = One;
            //int Min = One;

            //if (Two > Max)
            //{
            //    Max = Two;
            //}
            //if (Three > Max) {
            //    Max = Three;
            //}


            //if (Two < Min)
            //{
            //    Min = Two;
            //}
            //if (Three < Min)
            //{
            //    Min = Three;
            //}

            //Console.WriteLine("max is :" + Max);
            //Console.WriteLine("min is :" + Min);





            #endregion

            #region 04
            /*
             - Write a program that allows the user to insert 
            an integer number then check If a number is even or odd.
             */

            //Console.WriteLine("enter integer ");
            //double Num = double.Parse(Console.ReadLine());

            //if (Num % 2 == 0)
            //{
            //    Console.WriteLine(" number is even");
            //}
            //else if (Num % 2 != 0)
            //{

            //    Console.WriteLine(" number is odd");
            //}





            #endregion

            #region 05

            /*
             - Write a program that takes character from the user then if it 
            is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
             */

            //Console.WriteLine("enter character ");
            //char Char = char.Parse(Console.ReadLine());

            //if (Char == 'a' || Char == 'e' || Char == 'i' || Char == 'o' || Char == 'u')
            //{

            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}



            #endregion

            #region 07
            /*
             Write a program that allows the user to insert an integer then 
            print a multiplication table up to 12.

             */

            //Console.WriteLine("enter integer ");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++) { 

            //    Console.WriteLine($"{Num} x {i} = {i * Num}");
            //}




            #endregion

            #region 09

            //Write a program that takes two integers then prints the power.

            //Console.WriteLine("enter integer one ");
            //int Int01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter integer two ");
            //int Int02 = int.Parse(Console.ReadLine());

            //long Result = 1;

            //for (int i = 0; i < Int02; i++)
            //{
            //    Result = Result * Int01;
            //}
            //Console.WriteLine(Result);




            #endregion

            #region 10
            /*
             Write a program to enter marks of five
            subjects and calculate total, average and percentage.
             */

            //Console.WriteLine("enter the mark of subject one ");
            //int One = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the mark of subject one  two ");
            //int Two = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the mark of subject one  three ");
            //int Three = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the mark of subject one  four ");
            //int Four = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the mark of subject one  five ");
            //int Five = int.Parse(Console.ReadLine());

            //double Total = One + Two + Three + Four + Five;
            //double Average = Total / 5;

            //double Percentage =(Total / 500) * 100;

            //Console.WriteLine($"the total is  {Total} and the average is {Average} the Percentage is  {Percentage} %");



            #endregion

            #region 11
            /*Write a program to input the month number and print
             * the number of days in that month.*/

            //    Console.WriteLine("enter the  month number  ");
            //    int M = int.Parse(Console.ReadLine());

            //    if (M == 1 || M == 3 || M == 5
            //|| M == 7 || M == 8 || M == 10
            //|| M == 12)
            //    {
            //        Console.WriteLine("the number of days in that month IS 31 ");
            //    }
            //    else if (M == 4 || M == 6
            //    || M == 9 || M == 11)
            //    {
            //        Console.WriteLine("the number of days in that month IS 30 "); 
            //    }
            //    else if (M == 2)
            //    {
            //        Console.WriteLine("the number of days in that month IS 30 ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("please enter only number from 1 to 12 ");
            //    }


            #endregion

            #region 17
            /*
             Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and 
            determines whether these points lie on a single straight line.
             */
            //Console.WriteLine("enter the  first point x1 , y1  ");
            //int X1 = int.Parse(Console.ReadLine());
            //int Y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the  first point x2 , y2  ");
            //int X2 = int.Parse(Console.ReadLine());
            //int Y2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the  first point x3 , y3  ");
            //int X3 = int.Parse(Console.ReadLine());
            //int Y3 = int.Parse(Console.ReadLine());


            //if ((Y3 - Y2) * (X2 - X1) == (Y2 - Y1) * (X3 - X2))
            //{

            //    Console.WriteLine(" points lie on a single straight line.");

            //}
            //else
            //{
            //    Console.WriteLine(" points do not lie on a single straight line.");
            //}
            #endregion

            #region 18
            //Console.WriteLine("enter the time  of complition  ");
            //double Time = double.Parse(Console.ReadLine());

            //if (Time >= 2 && Time <= 3) {

            //    Console.WriteLine(" considered highly efficient. ");
            //}
            //else if (Time > 3 && Time <= 4)
            //{

            //    Console.WriteLine(" increase your speed. ");
            //}
            //else if (Time > 4 && Time <= 5)
            //{
            //    Console.WriteLine("Provide training to enhance your speed.");
            //}
            //else if (Time > 5)
            //{
            //    Console.WriteLine("You are required to leave the company.");
            //}

            #endregion

            #region 21
            //int X = 5;
            //int Y = X;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            ////modifying the value 
            //X = 15;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            // after modifying the value  Y still has the same old value of x = 5
            // x has the updated value =15
            #endregion

            #region 22
            //Class1 P01;

            //P01 = new Class1();

            //Class1 P02 = new Class1(); // unreachable object
            //P02.x = 20;
            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);
            //Console.WriteLine(P02.x);
            //Console.WriteLine(P02.y);
            //P02 = P01; //Assigning

            //P01.x = 10;
            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);
            //Console.WriteLine(P02.x);
            //Console.WriteLine(P02.y);
            // p02 now see the p01 class1 so it reference the same object with the same values 
            //even after modify it and p02 first class now is unreachable can not be access
            #endregion

            #region 23
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //b)	A value 1 will be assigned to d.
            // because the condition will return false and not false is true
            // and true value = 1
            #endregion

            #region 24
            // Console.WriteLine(13 / 2 + " " + 13 % 2);
            //d)	6 1
            #endregion

            #region 25
            //int num = 1, z = 5;

           // if (!(num <= 0)) //condition will return true
               // Console.WriteLine(++num + z++ + " " + ++z); // this will excute
           // else
             //   Console.WriteLine(--num + z-- + " " + --z);

            //d)	7 7

            #endregion
            //
        }
    }
}
