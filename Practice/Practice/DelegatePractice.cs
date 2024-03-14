


namespace Practice
{
    internal class DelegatePractice
    {
        ////public delegate bool SumOfNumber(int number);

        //public delegate int CalculateLength(string text, int num);

        //public bool CheckLength(string text)
        //{
        //    return text.Length < 6;
        //}

        //public bool CheckOdd(int num)
        //{
        //    return num%2 != 0;
        //}

        //public bool CheckEven(int num)
        //{
        //    return num%2 == 0;
        //}

        //public bool CheckNumber(int num)
        //{
        //    return num > 3;
        //}

        //public void StrToUpper(string text)
        //{
        //    Console.WriteLine(text.ToUpper());
        //}
        //public void StrToLower(string text)
        //{
        //    Console.WriteLine(text.ToLower());
        //}

        //public int GetLengthStr(string text, int num)
        //{
        //    return text.Length + num;
        //}

        //public bool CheckNums(int num1, int num2, int num3)
        //{
        //    return num1>1 || num2>1 || num3>1;
        //}

        public void Execute()
        {
            //List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            //SumOfOddNumbers(list, CheckOdd);
            //Console.WriteLine("-------");
            //SumOfOddNumbers(list, m => m % 2 != 0);
            //Console.WriteLine("===");
            //SumOfOddNumbers(list, CheckEven);
            //Console.WriteLine("-------");
            //SumOfOddNumbers(list, m => m % 2 == 0);
            //Console.WriteLine("===");
            //SumOfOddNumbers(list, CheckNumber);
            //Console.WriteLine("-------");
            //SumOfOddNumbers(list, m => m > 3);

            //Console.WriteLine("=======");
            //List<string> list1 = new List<string> { "salam", "sagol", "Azerbaycan" };
            //SumOfText(list1, CheckLength);
            //Console.WriteLine("-------");
            //SumOfText(list1, m => m.Length < 6);
            //Console.WriteLine("=======");


            //ShowText("Salam", StrToLower);
            //ShowText("Salam", StrToUpper);

            //Action<string> del1 = new Action<string>(StrToUpper);
            //del1("sagol");

            //GetLength("salam", GetLengthStr);

            //SumOfNumsByCondition(2,2,3,CheckNums);
        }

        //public void SumOfNumsByCondition(int num1,int num2, int num3, Func<int,int,int,bool> ex)
        //{
        //    if(ex(num1,num2,num3))
        //    {
        //        Console.WriteLine(num1+num2+num3);
        //    }
        //}

        //public void GetLength(string text, Func<string, int, int> length)
        //{
        //    Console.WriteLine(length(text,10));
        //}

        //public void ShowText(string text, Action<string> func)
        //{
        //    func(text);
        //}

        //public void SumOfOddNumbers(List<int> nums, Predicate<int> func)
        //{
        //    int sum = 0;

        //    foreach (int i in nums)
        //    {
        //        if(func(i))
        //        {
        //            sum += i;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

        //public void SumOfText(List<string> text, Predicate<string> function)
        //{
        //    List<string> strings = new();

        //    foreach (string i in text)
        //    {
        //        if (function(i))
        //        {
        //            strings.Add(i);
        //        }
        //    }
        //    foreach (string s in strings)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        ////public void SumOfEvenNumbers(List<int> nums)
        ////{
        ////    int sum = 0;

        ////    foreach (int i in nums)
        ////    {
        ////        if (i % 2 != 1)
        ////        {
        ////            sum += i;
        ////        }
        ////    }
        ////    Console.WriteLine(sum);
        ////}

        ////public void SumOfNumbers(List<int> nums)
        ////{
        ////    int sum = 0;

        ////    foreach (int i in nums)
        ////    {
        ////        if (i > 3)
        ////        {
        ////            sum += i;
        ////        }
        ////    }
        ////    Console.WriteLine(sum);
        ////}
    }
}
