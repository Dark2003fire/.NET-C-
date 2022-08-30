/*
 Polymorphism:-->
          Means many forms

 */

using System;
namespace std;
public class Shape{

    public  int X {get ; private set;}
    public int Y {get ; private set;}
    public int height {get;set;}
    public int width{get;set;}


    //Create a virtual method:->

    public virtual void Draw(){

        Console.WriteLine("I'm crating a virtual method to perform some tasks");

    }
}

public class Circle:Shape{


   public override void Draw(){

        //Code to draw a circle
        Console.WriteLine("Drawing a Circle");
        base.Draw();

   }
}

public class Rectangle : Shape{

    public override void Draw(){

        //Code to draw a Rectangle
         Console.WriteLine("Drawing a Rectangle");
         base.Draw();

    }

}

public class Triangle: Shape{

    public override void Draw(){

        // code to draw a triangle:->
        Console.WriteLine("Drawing a Triangle");
        base.Draw();

    }

}

// Polymorphism at work #1: a Rectangle, Triangle and Circle
// can all be used whereever a Shape is expected. No cast is
// required because an implicit conversion exists from a derived
// class to its base class.

var shapes = new List<Shape>{

    new Rectangle();
    new Triangle();
    new Circle();



};
// Polymorphism at work #2: the virtual method Draw is
// invoked on each of the derived classes, not the base class.

foreach(var Shape in shapes){

    base.Draw();

}

/* Virtual Members :->
        A derived class can override the base class only if base class is using the virtual or abstract methods
        The derived class must used override  keyword inorder to perform the virtual invocation.


 */
public class BaseClass{
    public virtual void doWork(){

        Console.WriteLine("Performing some  doWork task");

    }
    public virtual int workProperty(){
        Console.WriteLine("Performing Work property task");
        get {return 0;}



    }


}

public class DerivedClass: BaseClass{

    public override void doWork(){

        base.doWork();


    }

    public override int workProperty(){

        get{retun 0;}
        base.workProperty();



    }


}
public class TestClass{


    public static void Main(strinh[]args){


        DerivedClass DC = new DerivedClass();
        DC.doWork();
        BaseClass DC = BC;
        BC.doWork();


        DerivedClass Dc = new DerivedClass();
        Dc.workProperty();
        BaseClass Dc = Bc;
        Bc.workProperty();





    }
}



// Hides the base class with new members :-->
     /*

            We can use the same name in derived class which is in the base class the we have to use it new keyword in the dervied class inorder to hide the members of the base class.



      */

public class  BaseClass{


    public  void DoWork(){WorkField++}
    public int  WorkField;
    public int workProperty{

        get{return 0;}
    }

}
public DerivedClass : BaseClass{

    public new void DoWork{WorkField++}
    public new int WorkField;
    public new int workProperty{

        get{return 0;}
    }
}


public class TestBaseDerivedClass{

    public static void Main(string[]args){

            DerivedClass DC = new DerivedClass()
            DC.DoWork;

            BaseClass BC = (BaseClass)DC
            BC.DoWork;





    }
}





























