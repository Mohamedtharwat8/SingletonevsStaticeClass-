// See https://aka.ms/new-console-template for more information
using System.Text;

namespace Program
{
    class MyClass
    {

        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> PrintDetails(),
                ()=> PrintDetails()
                );
            Console.WriteLine("Hello, World!");

        }

        private static void PrintDetails()
            {
            Signleton n1 = Signleton.GetInstance;
            n1.Print();

        }
            //Signleton n1 = Signleton.GetInstance;
            //n1.Print();
            //Signleton n2 = Signleton.GetInstance;
            //n2.Print();

        


    }

    public sealed class Signleton
    {
        private static readonly Lazy<Signleton> InstanceLock = new Lazy<Signleton>(()=> new Signleton());
        //private static Signleton signleton = null;

        int counter = 0;
        public Signleton()
        {
            counter++;
            Console.WriteLine("Counter Objects Created  : {0}", counter);



        }


        public static Signleton GetInstance  
        {
            get
            {

                return InstanceLock.Value;  
                //if (signleton == null)
                //{
                //    signleton = new Signleton();



                //}

                //return signleton;
            }
        }

        public void Print()
        {
            Console.WriteLine(" objects crested one ");

        }
    }


}

//StringBuilder s1 = new StringBuilder("Yes");


//StringBuilder s2 = new StringBuilder("Yes");

//System.Console.WriteLine(s1==s2);
//System.Console.WriteLine(s1.Equals(s2));

//string[] strs = {
//"alpha",
//"beta"
//, "'gamma" };
//var chrs = from str in strs
//let chrArray = str.ToCharArray ()
//from ch in chrArray orderby ch select ch;
//Console.WriteLine("The individual characters in sorted order:"); foreach (char c in chrs)
//    Console.Write(c + "");
//    Console.WriteLine();
//Console.ReadLine();

//public class  myclas
//{
//    delegate void Printwr();

//       static void  (string[] args);  

//}


//try
//{
//	throw new NullReferenceException("C");
//	System.Console.WriteLine("A");
//}
//catch (Exception)
//{
//    System.Console.WriteLine("B");


//}

//System.Console.ReadLine();