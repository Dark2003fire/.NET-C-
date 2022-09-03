/*
 Pattern Matching :-->
        Pattern matching is a technique where you test an expression to determine whether it has an some characteristics The is expression is used to test the expression

 */

//The below code is a declaration pattern to test thetype of the variable,and assign it to a new variable.
using System;
public class TestExpression{

    int? maybe= 15;
    if(maybe is int number){
        Console.WriteLine($"The nullable   int  is maybe a value {number}");
    }
    else{

        Console.WriteLine("The nullable int value does'nt hold any value");

    }

    string? message = "This is not the null string";
    if(message is not null){
        Console.WriteLine(message);

    }
}
/*
Type Test:--
The following code tests if a variable  is non-null and implements the System.Collections.Generic.IList<T> interface. If
it does, it uses theICollection<T>.Count property on that list to find the middle index.

 */
public static T MidPoint<T>(IEnumerable <T> sequence){

    if(sequence is IList<T> list){
        return list[list.count/2];

    }
    else if (sequence is null){

        throw new ArgumentNullException(nameof(sequence) , "Sequence can't be null. ");
    }

    else{
        int halflength = sequence.Count()/2-1;
        if(halflength<0)halflength=0;
        return sequence.Skip(halflength).First();

    }
}
/*
 * The same tests can be applied in a switch expression to test a variable against multiple different types. You can use that information to create better algorithms based on the specific run-time type.

 */
public State PerformOperation(Operation command)=>
    command  switch
    {
        Operation.SystemTest => RunDiagnostics(),
        Operation.Start => StartSystem(),
        Operation.Stop => StopSystem(),
        Operation.Reset => ResetToReady(),
           _ => throw new ArgumentNullException("Invalid enum value for command nameof(command)");
    };

//. At run time, the switch expression throws an exception if the object being examined doesn't  match any of theswitch arms.
    public State PerformOperation(string command) =>
command switch
{
"SystemTest" => RunDiagnostics(),
"Start" => StartSystem(),
"Stop" => StopSystem(),
"Reset" => ResetToReady(),
_ => throw new ArgumentException("Invalid string value for command", nameof(command)),
};

/*
Relational Patterns :-->
  We can use relational patterns to test how a value compares to constants.For example, the following code returns the state of water based on the temperature in Fahrenheit:
 */
string WaterState(int tempInFahrenheit)=>
    tempInFahrenheit switch{

        (>32) and (<212)=>"liquid",
        <32 => "solid",
        >212 => "gas",
        32 => "Solid/liquid transition",
        212 => "liquid/gas transition",

};
// Another way to write the same expression could be:-->
string WaterState2(int tempInFahrenheit) =>
tempInFahrenheit switch
{

< 32 => "solid",
32 => "solid/liquid transition",
< 212 => "liquid",
212 => "liquid / gas transition",
_ => "gas",

};

//Multiple Inputs :-->
public record Order(int Items, decimal Cost);
public decimal CalculateDiscount(Order order) =>
order switch
{
    (Items: > 10, Cost: > 1000.00m) => 0.10m,
    (Items: > 5, Cost: > 500.00m) => 0.05m,
    Order { Cost: > 250.00m } => 0.02m,
    null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
    var someObject => 0m,
};

/*
 List Patterns :-->
 A list pattern provides a means to apply a pattern
to any element of a sequence. In
 */

public void MatchElements(int[]array){

    if(array is [0,1]){
        Console.WriteLine("Binary Digits");
    }
    else if(array is [1,1,2,3,5,8,....]){

        Console.WriteLine("Array looks like a Fibonacci Series";

        )
        else{

            Console.WriteLine("Array shape not recognised");

        }
    }
}



