/* A Public class that has a Auto-Implementated property a method , a Special Method called Constructors
*/
using System;
public class Person{

    // A  Constructor which takes no Argument:-
    public Person(){

        name = "unknown";

    }
    // A Constructor which takes one Argument:-
    public Person(string name){

        Name = name;

    }
    //Auto-Implementated ReadOnly property:-
    public string Name{get;}

    //Method that overrides the base System.object Implementation

    public override string ToString(){

        return Name;

    }
}
public class TestPerson{

    public static void Main(string[]args){

        // Call that Constructor that has a Parameter:-
        var Person1 = new Person();
        Console.WriteLine(Person1.Name);

        //Call that Constructor which takes one argument:-
        var Person2 = new Person("Hitesh Jha");
        Console.WriteLine(Person2);

        //Get the string represenation of the Person2 Instance:-
        Console.WriteLine(Person2);



    }
}

/*
E.g of  Record :-->
     A public record that uses Positional Parameters to declare and instantiate a record
     It prints type name and Property values:->

 */

public record Person(string FirstName  , string LastName);
public static void Main(){

     Person person = new Person("Hitesh" , " Jha");
     Console.WriteLine(Person);

}

//Below example demonstrates value Equality in records:->
public record PersonInfo(string Firstname ,  string lastname , string[] phonenos);
public static void Main(){

    PersonInfo pinfo = new PersonInfo("Hitesh" , "Jha", phonenos );
    PersonInfo pinfo2 = new PersonInfo("Hitesh" , "Jha" , phonenos);
    Console.WriteLine(pinfo);
    Console.WriteLine(pinfo2);
    Console.WriteLine(pinfo==pinfo2); // true;

    pinfo.phonenos[] = "8446049402";
    pinfo2.phonenos[] = "8446049402";
    Console.WriteLine(pinfo);
    Console.WriteLine(pinfo2);
    Console.WriteLine(pinfo == pinfo2);//True;


    Console.WriteLine(ReferenceEquals(pinfo , pinfo2));//False;


}



































































