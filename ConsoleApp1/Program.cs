using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region static / partial Class exmaple
    public static class MyCollege
    {
        #region static class
        //In C#, a static class is a class that cannot be instantiated. The main purpose of using static classes in C# is
        //to provide blueprints of its inherited classes

        //static fields
        public static string CollegeName;
        public static string Address;

        //static constructor
        static MyCollege()
        {
            CollegeName = "ABC College of Technology";
            Address = "Hyderabad";
        }
        #endregion Partial class

        #region partial class
        //A partial class is a special feature of C#. It provides a special ability to implement the functionality of a single class
        //into multiple files and all these files are combined into a single class file when the application is compiled. 
        //This keyword is also useful to split the functionality of methods, interfaces, or structure into multiple files.
        #endregion
    }
    #endregion

    #region abstract class example
    // Abstract class: is a restricted class that cannot be used to 
    //create objects(to access it, it must be inherited from another class).
    abstract class Name
    {
        public abstract void Fname(); 
    }

    class FullName : Name
    {
        public override void Fname()
        {
            Console.WriteLine("Ajay Yadav");
        }
    }
    #endregion

    #region sealed class Example
    //A sealed class, in C#, is a class that cannot be inherited by any class but can be instantiated.
    sealed class Getname
    {
        public void getfname()
        {
            Console.WriteLine("Ajay");
        }
    }

    class getFl //:Getname
    {

    }
    #endregion

    #region main function
    class Program
    {
        static void Main(string[] args)
        {
            #region static class
            //Console.WriteLine(MyCollege.CollegeName);
            //Console.WriteLine(MyCollege.Address);
            //Console.Read();
            #endregion

            #region partial class
            //Geeks c = new Geeks("ajay",18);
            //c.Display();
            //Console.Read();
            #endregion

            #region abstract class example
            //FullName f = new FullName();
            //f.Fname();
            //Console.Read();
            #endregion
        }
    }
    #endregion
}
