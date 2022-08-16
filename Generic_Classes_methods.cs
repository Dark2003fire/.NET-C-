using System ;
using System.Collection.Generics;

//Declare the generic class:-->
public class GenericList<T>{

    public void Add(T input){


    }
}
class TestGenericClass{

    private class ExampleClass{


    }

    static void Main(){

        GenericList<int>  List1 = new GenericList<int>();
        List1.Add(8865);//Declare a list of type int
        List1.Add(8864);

        GenericList<string> Names = new GenericList<string>();
        Names.Add("Hitesh");//Declare a list of type String
        Names.Add("Raji");
        Names.Add("Faizan");


        GenericList<float> Height = new GenericList<float>();
        Height.Add(163.5);// Declare a list of type float
        Height.Add(170.8);

        GenericList<ExampleClass> classmembers = new GenericList<ExampleClass>();
        classmembers.Add(new ExampleClass()); // Declare a list of type whole class


    }

}

//Let's create a simple generic linked list class for demonstration Purpose:->

public class GenericList<T>//type parameter T in angle brackets
{
    //The nested class is also generic on T.

    private class Node
    {
        //T is used in Non-Generic Constructor:->
        public Node(T t)
        {
            next = null;
            data = t;

        }
        private Node? next;
        public Node? Next;
        {
            get{retun next;}
            set{next = value;}

        }
        //T as private member data type
        private T data;
        //T as return type of property.
        public T Data
        {
            get {return data;}
            set {data = value;}

        }
    }
    private Node? head;

    //Constructor
    public GenericList()
    {
        head = null;

    }

    // T as Method parameter type;
    public void AddHead(T t)
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node> current = head;
        while(current!= null)
        {
            yield return current Data;
            current = current.Next;

        }
    }
}
class TestGenericList
{
    static void Main()
    {
        // int is the type of Argument
        GenericList<int> list = new GenericList<int>();
        for(int x = 0;x<10;x++)
        {
            list.AddHead(x);
        }
        foreach(int i in list)
        {
            Console.WriteLine(i +" ");

        }
        Console.WriteLine("\n Done");

    }
}

































































