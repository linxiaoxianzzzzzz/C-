using System;

namespace CH0101
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Salary = 1;
            employee1.Ename = "Test";
            employee1.ShowError();
            employee1.PrintData();










            // int i,j;
            // Console.WriteLine("請輸入兩次數字");
            // i= int.Parse(Console.ReadLine());
            //j = int.Parse(Console.ReadLine());

            // if (i < j) {
            //     for (int x =i+1 ; x < j; x++)
            //     {
            //         Console.WriteLine(x);
            //     }
            // } 
            //else {
            //     for (int x = j+1; x < i; x++)
            //     {
            //         Console.WriteLine(x);
            //     }
            // }

            //------------------


            //for (int i = 2; i < 300; i++)
            //{
            //    bool notTarget = false;
            //    for (int j = 1; j <Math.Sqrt(i) ; j++)
            //    {
            //        if (i % j == 0 && j!=1) { notTarget = true; }

            //        }
            //    if (notTarget ==  false)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

//-------------------------
            //  int count= 1;
            //for (int i = 4; i >0; i--)
            //{
            //    for (int j = 0; j <i ; j++) { Console.Write("0");      }
            //    for(int j = 0; j <count; j++) {  Console.Write("*"); }
            //    count=count+2;

            //  Console.Write("\n");
            //}

            //int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //string[] arr2 = new string[] { "A", "D", "F", "G" };
            //TwoDimClass c1 = new TwoDimClass(arr1);
            //TwoDimClass c2 = new TwoDimClass(arr2);

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.WriteLine(c1[i, j]);
            //    }

            //}

            //Console.WriteLine();
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(c2[i]);
            //}


            //    string[] arr1 = {"AA","BB", "CC" };
            //    int[] arr2 = {1,2,3};

            //    GenIndexers<string> ge1=new GenIndexers<string>(arr1);
            //    GenIndexers<int> ge2 = new GenIndexers<int>(arr2);

            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        Console.WriteLine(ge1[i]+"    ");           
            //        Console.WriteLine(ge2[i]+"    ");
            //    }
            //}

            //int time;
            //Console.WriteLine("出價次數");
            //time = int.Parse(Console.ReadLine());
            //try { 
            //    if (time > 10) { Console.WriteLine("次數過多"); }
            //}
            //catch (MyException ex) {
            //    Console.WriteLine("例外");
            //}
            //finally
            //{
            //    Console.WriteLine("例外處理結束");
            //}

        }

        //class TwoDimClass
        //{
        //    private int[,] arr1;
        //    private string[] arr2;
        //    public TwoDimClass(int[,] arr1)
        //    {
        //        this.arr1 = arr1;
        //    }
        //    public TwoDimClass(string[] arr2)
        //    {
        //        this.arr2 = arr2;
        //    }
        //    public int this[int pos1, int pos2]
        //    {
        //        get { return arr1[pos1, pos2]; }
        //        set { arr1[pos1, pos2] = value; }
        //    }
        //    public string this[int pos1]
        //    {
        //        get { return arr2[pos1]; }
        //        set { arr2[pos1] = value; }
        //    }
        //}

        //class GenIndexers<T>
        //{
        //    private T[] arr;
        //    public GenIndexers(T[] arr)
        //    {
        //        this.arr = arr;
        //    }

        //    public T this[int pos1]
        //    {
        //        get { return arr[pos1]; }
        //        set { arr[pos1] = value; }
        //    }
        //}
        //class MyException : Exception
        //{

        //    public MyException(string s) : base(s) {}
        //}
    }
}



