namespace C__Advanced_03
{

    #region Delegate Ex01
    public delegate int StringFuncDelegate(string s);
    // New Delegate(Class): Reference (Pointer) Can Refer To Function or More (Pointer of Function)
    // These Function Must Be Have The SAme Signature Of The Delegate : int(string)
    // Regardless Function Name, Parameters Names Or, Access Modifiers 
    #endregion


    internal class Program
    {

        #region Delegate Ex02
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T t in values)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();

        }
        #endregion

        public static List<T> FindElements<T>(List<T> list, Func<T, bool> reference)
        {
            List<T> Result = new List<T>();
            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                        Result.Add(list[i]);
                }



            }
            return Result;
        }

        //public static List<int> FindElements(List<int> list , ConditionFuncDelegate reference)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //                Result.Add(list[i]);

        //        }



        //    }
        //    return Result;
        //}

        //public static List<string> FindElements(List<string> list, ConditionFuncDelegateV02 reference)
        //{
        //    List<string> Result = new List<string>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //                Result.Add(list[i]);
        //        }



        //    }
        //    return Result;
        //}

        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionFunction.CheckOdd(list[i]))
        //                Result.Add(i);
        //        }



        //    }
        //    return Result;
        //}

        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionFunction.CheckEven(list[i]))
        //                Result.Add(i);
        //        }



        //    }
        //    return Result;
        //}

        //public static List<int> FindDivsibleBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionFunction.CheckDivisableBy4(list[i]))
        //                Result.Add(i);
        //        }



        //    }
        //    return Result;
        //}

        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 != 0)
        //                Result.Add(i);
        //        }



        //    }
        //    return Result;
        //}

        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //                Result.Add(i);
        //        }



        //    }
        //    return Result;
        //}

        //public static List<int> FindDivsibleBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0)
        //                Result.Add(i);
        //        }



        //    }
        //    return Result;
        //}



        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T t in values)
            {
                Console.Write($"{t} ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            #region Delegate Ex01
            //// Step 2 : Use Delegate

            ////StringFuncDelegate X;
            ////X = StringFunctions.GetCountOfUpperCaseChars;
            //// X.


            //// StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars);

            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar

            //X = StringFunctions.GetCountOfLowerCaseChars;

            ////  int Count = X.Invoke("Hello World");

            //int Count = X("Hello World");

            //Console.WriteLine(Count);
            #endregion

            #region Delegate Ex02
            //// int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };

            //// PrintArray(Numbers);

            //// // SortingAlgorithms.BubbleSortAscending(Numbers);
            //// // SortingAlgorithms.BubbleSortDescending(Numbers);

            //// SortingFuncDelegate X = SortingConditions.CompareGtr;

            ////// SortingAlgorithms.BubbleSort(Numbers, X);

            //// SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareGtr);


            //// PrintArray(Numbers);

            //string[] Names = { "Ahmed", "Ali", "Mariam", "Mahmoud", "Amr", "Mona", "Khaled" };

            //PrintArray(Names);

            //SortingAlgorithms.BubbleSort(Names, SortingConditions.CompareGtr);

            //PrintArray(Names); 
            #endregion

            #region Delegate Ex03
            ////List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //////List<int> OddNumbers = FindOddNumbers(Numbers);
            //////List<int> EvenNumbers = FindEvenNumbers(Numbers);
            //////List<int> DivisableBy4Numbers = FindDivsibleBy4Numbers(Numbers);

            ////List<int> OddNumbers = FindElements(Numbers , ConditionFunction.CheckOdd);
            ////List<int> EvenNumbers = FindElements(Numbers , ConditionFunction.CheckEven);
            ////List<int> DivisableBy4Numbers = FindElements(Numbers , ConditionFunction.CheckDivisableBy4);


            ////PrintList(DivisableBy4Numbers);

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mariam", "Mahmoud", "Amr", "Mona", "Khaled" } ;

            //List<string> Result = FindElements(Names, ConditionFunction.CheckLengthGtr4);

            //PrintList(Result); 
            #endregion

            #region Built-in Delegate
            //// Built-im Delegate

            //// Predicate, Func, Action

            //// Predicate

            //// ConditionFuncDelegate<int> X = ConditionFunction.CheckEven;

            ////Predicate<int> predicate = ConditionFunction.CheckEven;

            ////bool r = predicate.Invoke(1);

            ////Console.WriteLine(r);

            ////Func<int> func = Fun01;
            ////Func<int, string> func1 = Fun02;

            ////Func<int, bool> predicate = ConditionFunction.CheckEven;


            //Action<string> action = Print;

            ////action.Invoke();

            ////action(); 
            #endregion

            #region Anonymous Method & Lambda Expression

            //////Func<int , bool> func = ConditionFunction.CheckEven;

            //////func(1);    

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////// Anonymous Method
            ////// C# 2.0 2005

            ////Func<int, bool> func = delegate (int X) { return X % 2 == 0; }; // Anonymous Method

            ////// FindElements(Numbers, func);

            ////FindElements(Numbers, delegate (int X) { return X % 2 == 0; });

            //// Lambda Expression [Recommended]
            //// C# 3.0 2007

            //Func<int , bool> func = X => X % 2 == 0; // Lambda Expression

            ////FindElements(Numbers, delegate (int X) { return X % 2 == 0; });

            //FindElements(Numbers, N => N % 2 == 0);
            //FindElements(Numbers, N => N % 2 != 0);

            //Enumerable.Where(Numbers, ConditionFunction.CheckOdd);
            //Enumerable.Where(Numbers, delegate (int N) { return N % 2 != 0; });

            //Enumerable.Where(Numbers, N => N % 2 != 0); 
            #endregion

            #region Var
            //// C# Keyword
            //// C# 3.0
            //// var

            //var X = "Hello";

            //var predicate = ConditionFunction.CheckDivisableBy4; 
            #endregion

            #region Func return Func
            //var action = Fun01();

            //action.Invoke();

            //Fun01()(); 
            #endregion




        }

        public static Action Fun01()
        {
            //   Action action = Print;

            // Action action = delegate () { Console.WriteLine("Hello World")};

            Action action = () => Console.WriteLine("Hello World");

            return action;

        }

        //public static void Print(string X)
        //{ 
        //    Console.WriteLine(X);
        //}

        //public static int Fun01()
        //{
        //    return 1;

        //}

        //public static string Fun02(int X)
        //{
        //    return $"{X}";

        //}

    }
}
