// if-else statements examples
int a = 6;
int b = 6;
int c = 8;
if(a+b*c>100){

    Console.WriteLine("The answer is greater then 100");

}
else{
    Console.WriteLine("The answer is less then 100");
}
if((a+b+c>10)&&(a==b)){
    Console.WriteLine("The answer is greater then 10");
    Console.WriteLine("The value of a is equal to b");


}
else{

    Console.WriteLine("The answer is less then b");
    Console.WriteLine("The value of a is not equal to b");

}
 void Exploreif_else(){
    int a = 6;
    int b = 6;
    int c = 10;
    if(a+b*c>100){

        Console.WriteLine("The answer is greater then 100");

}
    else{
        Console.WriteLine("The answer is less then 100");
}
    if((a+b+c>10)&&(a==b)){
        Console.WriteLine("The answer is greater then 10");
        Console.WriteLine("The value of a is equal to b");


}
    else{

        Console.WriteLine("The answer is less then b");
        Console.WriteLine("The value of a is not equal to b");

}
    if((a+b+c>100)||(a==b)){
        Console.WriteLine("The answer is greater then 10");
        Console.WriteLine("The value of a is equal to b");


}
    else{

        Console.WriteLine("The answer is less then b");
        Console.WriteLine("The value of a is not equal to b");

}


}

Exploreif_else();

 void WhileLoops(){

    int counter = 0;
    while(counter<10){

        Console.WriteLine($"Hello C# ! The Counter is {counter}");
        counter++;

    }

}
 void DoWhileLoops(){


    int count = 0;
    do{
        Console.WriteLine($"Helo World ! The Counter is {count}");
    count++;
    }while(count<=20);

}
WhileLoops();
DoWhileLoops();

 void ExploreLoops(){
    for(int row = 1; row<=11;row++){
        for(char coloumn = 'a'; coloumn<'k';coloumn++){

            Console.WriteLine($"The cell is {row} and {coloumn}");

        }
    }
}
ExploreLoops();
