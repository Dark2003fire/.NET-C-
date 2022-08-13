//List by using list method we can create and store nos item in the list
// List can be created of different datatypes;

var names = new List<string>{

    //"<name>",
    "Hitesh",
    "Siddhant",
    "Raji",
    "Asjad",
    "Faizan",
    "Arisha",

};
foreach(var name in names){

    Console.WriteLine($"Hello {name.ToUpper()}");
}

void PrintRoll_No(){
    var Roll_nos = new List<int>{

    12 , 10 , 13 , 8865 , 8801 , 8853 , 8840 , 8864,
};
foreach(var roll_no in Roll_nos){
    Console.WriteLine($"The Roll number is {roll_no}");
}
Console.WriteLine($"My name is {names[0]} and I've roll nos {Roll_nos[0]} ");

}
PrintRoll_No();
names.Add("Sufiyan");
names.Add("Hamza");
names.Add("Yasir");
names.Add("Unib");
names.Add("Zarekari");
names.Remove("Siddhant");
foreach(var name in names){
    Console.WriteLine($"Hello {name.ToLower()}");
}
Console.WriteLine($"The number of names in the list are {names.Count()} ");

void ListWithSearchMethod(){

    var names = new List<string>{

    //"<name>",
    "Hitesh",
    "Siddhant",
    "Raji",
    "Asjad",
    "Faizan",
    "Arisha",

};

foreach(var name in names){

    Console.WriteLine($"Hello {name.ToUpper()}");
}



    var nam = names.IndexOf("Hitesh");

        if(nam==-1){
            Console.WriteLine($"When an item is not found IndexOf returns {nam}");
        }
        else{
            Console.WriteLine($"The name {names[nam]}  is at index{nam}");
        }


    nam = names.IndexOf("Not found");

        if(nam==-1){
            Console.WriteLine($"When an item is not found IndexOf returns {nam}");

        }
        else{
            Console.WriteLine($"The names{names[nam]} is at index{nam}");

        }



    names.Sort();


    foreach(var name in names){
        Console.WriteLine($"Hello and Hi {name.ToUpper()}");




    }
}


ListWithSearchMethod();


//ProGram to create a fibonacci series:-->
/*
That creates a list of integers,and sets the first two integers to the value
FibonacciSequence,a sequence of numbers.Each next Fibonacci number is found by taking the sum of the previous two numbers.

*/


var fibonacciNumbers=new List<int>{1,1,2 ,3 ,5 , 8 , 13 , 21 , 34};
var previous =  fibonacciNumbers[fibonacciNumbers.Count-1];
var prevoius2 = fibonacciNumbers[fibonacciNumbers.Count-2];
fibonacciNumbers.Add(previous+prevoius2);
foreach(var item in fibonacciNumbers){
    Console.WriteLine(item);

}


// If I want to print the fibonacci series till 20 or may be 30 then see below code:->
void FibonacciNumbers(){

    var fibonaccinos = new List<int>{
        1,1,2,3,5
    };
    while(fibonaccinos.Count<20){
       var prev =  fibonaccinos[fibonaccinos.Count-1];
       var prev2 = fibonaccinos[fibonaccinos.Count-2];
       fibonaccinos.Add(prev+prev2);


    }
    foreach(var items in fibonaccinos){
        Console.WriteLine(items);
    }


}

FibonacciNumbers();


