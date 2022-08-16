//Top- Level Statements :-->
/*
 You don't have to explicitly include Main method in Console Application project
 instead you can use Top-Level-Statements(TLS) to minimize the code you have to write .


 */
// Without Main Method to print Hello World E.g - (TLS)
using System.Text
StringBuilder builder = new();
builder.AppendLine("Hello");
builder.AppendLine("World");
Console.WriteLine("builder.ToString()");

//Namespace and Type definitions :-->
//A file with TLS also Contain the namespace and type definitions:-->
My_class.Test_Method();
namespace.My_Class.My_method();

public class My_class{


    public static void Test_Method(){

        Console.WriteLine("Hello My Method Class How are You?");
    }
}

namespace My_Namespace{

    public class My_Class{

        public static void My_method(){

            Console.WriteLine("Hello this is namespace.My_Class.My_method !");

        }
    }
}

//args :-->
/*   TLS can reference the args variable   to access any CL arguments that were entered
      The args variable is never null but it's length is zero when no CL argument is provided.

*/
if(args.Length>0){
    foreach(var arg in args){
        Console.WriteLine($"Argument={args}");

    }
}
else{
    Console.WriteLine("No arguments is provided");

}

//await :-->
// we can call the async method by using await:->
Console.WriteLine("Hello");
await Task.Delay(5000);
Console.WriteLine("World");




