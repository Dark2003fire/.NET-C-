/*
 A class or struct definition is likea blueprint that specifies what the type  can do. An object is basically a block of memory that has been allocated and configured according to the blueprint. A program may create many objects
of thesameclass. Objects are also called instances,and they can be  stored in either  a named variable or in an
array or collection


 */
//Below Example is the class instances:->

using System;
public class Person{

    public string Name{get;set;}
    public int  Age{get;set;}

    public Person(string Name , Age int){

        Name = Name;
        Age = Age;

    }
}
class TestPerson{

    public static void Main(){

        Person person1 = new Person("Hitesh Jha" ,19);
        Console.WriteLine("Name = {0} and Age {1}" , person1.Name , person1.Age);

        Person person2 = person1;
        person2.Name = "Hitesh Jha";
        person2.Age = 19;

        Console.WriteLine($"The name of the person is {Name} and Age is {Age}" , person2.Name , Person2.Age);



    }
}
//Struct Instances:-->
namespace Example;
public struct Car{

    public string Car_Name{get;set;}
    public int Car_Mileage{get;set;}
    public int Car_Nos{get;set;}


    public Car(string Car_Name , int Car_Mileage , int Car_Nos){

        Car_Name = Car_Name;
        Car_Mileage = Car_Mileage;
        Car_Nos = Car_Nos;

    }
}

public class TestCar{

    public static void Main(){


        // Create struct instance and initialize by using new operator;
        //Memory is allocated on thread stack;

        Car car1 = new Car("Range Rover" , 25 , 34003);
        Console.WriteLine($"Name of  the car is {Car_Name} and Mileage is{Car_Mileage} and Car nos is {Car_Nos}" ,car1.Car_Name , car1.Car_Mileage , car1.Car_Nos);

        Car car2 = car1;
        car2.Car_Name = "Lambhorghini";
        car2.Car_Mileage = 25;
        car2.Car_Nos = 342003;

        Console.WriteLine("Name = {0}  Mileage = {1} and Car Number = {2}" car2.Car_Name , car2.Car_Mileage , car2.Car_Nos);


        if(car2.Equals(car1)){
            Console.WriteLine("The values of Car1 and car2 are Equal");

        }





    }
}


