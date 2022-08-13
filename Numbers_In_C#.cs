int a= 10;
int b = 20;
int c ;
c = a+b;
//Addition
Console.WriteLine(c);
//Subtraction
c = a -b;
Console.WriteLine(c);
//Multiplication
c = a*b;
Console.WriteLine(c);
//Division
c = a/b;
Console.WriteLine(c);


//Work with a Order Precdence:-->
void WorkwithInteger(){

    int a , b  , c ;
    a = 20;
    b = 30;
    c = 40;

    Console.WriteLine("This is a Integer method");
    //Addition
    c = a+b;
    Console.WriteLine(c);
    // Subtraction
    c = a-b;
    Console.WriteLine(c);
    //Multiplication
    c = a*b;
    Console.WriteLine(c);
    //Division
    c = a/b;
    Console.WriteLine(c);

}

void OrderofPrecedence(){

    int a = 10;
    int b = 20;
    int c = 30;
    int d = a+b*c;
    int e = a+b/c;
    int f = a+b%d;



    Console.WriteLine("This is a Order of Precdence method");
    Console.WriteLine(d);
    Console.WriteLine($"quotient is : {e}");
    Console.WriteLine($"Remainder is : {f}");




    d = (a+b)*c;
    Console.WriteLine(d);
    d = a+(b*c);
    Console.WriteLine(d);
    d = (a+b)*12-6*c;
    Console.WriteLine(d);

    int max = int.MaxValue;// This is used to find the ranges of Datatype;
    int min = int.MinValue;
    Console.WriteLine($"The range of the Integers is {min} to {max}");





}
WorkwithInteger();
OrderofPrecedence();

void RangeofAllDataTypes(){

    int MaxValue = int.MaxValue;
    int MinValue = int.MinValue;
    Console.WriteLine($"The range of intgers datatype is {MinValue}  to {MaxValue}");


    char MaxValue1 = char.MaxValue;
    char MinValue1 = char.MinValue;
    Console.WriteLine($"The range of character datatype is {MinValue1} to {MaxValue1}");


    float MaxValue2 = float.MaxValue;
    float MinValue2 = float.MinValue;
    Console.WriteLine($"The  range of floating point datatype is {MinValue2} to {MaxValue2}");


    double MaxValue3 = double.MaxValue;
    double MinValue3 = double.MinValue;
    Console.WriteLine($"The range of Double Datatype is {MinValue3} to {MaxValue3}");







}

RangeofAllDataTypes();







