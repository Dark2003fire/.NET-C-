//General Skeleton of C# program :-->
using System;
namespace Your_Namespace
{
    class Your_class
    {

    }
    struct your_struct
    {

    }
    interface your_Interface
    {

    }
    delegate int Your_Delegate();

    enum Your_Enum
    {

    }
    namespace Your_Nested_Namespace
    {
        struct Your_Struct
        {

        }
    }

   public  class Program
    {
        public static void Main(string args[]){
            //Your Program Starts here now.....
            Console.WriteLine("Hello C#");

        }

    }


}



//When we can omit the Main method then we can write our Hello World Program like this

using System.Text
StringBuilder builder = new ();
builder.AppendLine("Hello");
builder.AppendLine("World");
Console.WriteLine(builder.ToString());



// Main Signatures:-->

public static void Main(){
    Console.WriteLine("Hello This is Main Method with void return type and no Command-Line Arguments");


}
public static int Main(){
    Console.WriteLine("Hello This is Main Method with int return type and no Command-Line Arguments");


}
public static void Main(string[] args){
      Console.WriteLine("Hello This is Main Method with void return type and with Command-Line Arguments");

}
public static int Main(string[]args){
     Console.WriteLine("Hello This is Main Method with int  return type and with Command-Line Arguments");

}
public static async Task Main(){

    Console.WriteLine("Hello This is Main Method with async modifier with Task and no Command Line Arguments"); //async is await asynchronous operations in Main.

}
public static async Task<int> Main(){
     Console.WriteLine("Hello This is Main Method with async modifier with Task<int> and no Command Line Arguments");

}
public static async Task Main(string[]args){
      Console.WriteLine("Hello This is Main Method with async modifier with Task and with Command Line Arguments");

}
public static async Task<int> Main(string[]args){
      Console.WriteLine("Hello This is Main Method with async modifier with Task<int> and with Command Line Arguments");


}

//The code below ensures that your program runs until the asynchronous opeartion is completed:-
public static  void Main(){

    AsyncConsoleWork().GerAwaiter().GetResult();

}
private static async Task<int>AsyncConsoleWork(){

    //Main Body will be here;
    return 0;

}
//The Boilerplate above is replaced by :->
static async Task<int> Main(string[]args){

    return await AsyncConsoleWork();
//An advantage of declaring the async as a Main is that Compiler always generates the correct code.


}




/*Now Let's the application takes one argument at runtime , Converts the argument and calculates the factorial of the number
 if no arguments are supplied , the application issues a message that expalins the correct usage of the program.

 */

public class Function{


    public static int Factorial(int n){

        //Test for Invalid input
        if((n<0)||(n>20)){
            return -1;

        }

        //Now calculate the factorial iteratively rather then recursively:-->
        long tempresult = 1;
        for(int i = 1;i<=n;i++){

            tempresult *=i;

        }
        return tempresult;

    }
}
class MainClass{

    static int Main(string[]args){

        //Test if Input arguments were supplied:->
        if(args.Length==0){
            Console.WriteLine("Please Ebter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }
        //Try to Convert the input arguments to a numbers this will
        //throw an exception if argument is noy number
        //num = int.Parse(args[0] , out num);

        int num;
        bool test = int.TryParse(args[0] , out num);
        if(!test){
            Console.WriteLine("please Enter a numeric Argument.");
            Console.WriteLine("Usage : Factorial <num>");
            return 1;

        }
        //calculate factorial.
        long result = Functions.Factorial(num);
        //print result.
        if(result==-1){
            Console.WriteLine("Input must be >=0 and <=20.");

        }
        else{
            Console.WriteLine($"The factorial of {num} is {result}.");

        }
        return 0;

    }
}
//output :--> If 3 is entered on Command Line , the ouput reads: The factorial of 3 is 6.





