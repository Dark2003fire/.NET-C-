//Below examples tells about Implementation of IEquatable<T> Interfaces
/*
 An interface is like an abstract base class with only abstract members. A class
or struct that implements the interface must implement all its members.
 */

public class Car : IEquatable<Car>{

    public string? Make {get;set;}
    public string? Model {get;set;}
    public string? Year {get;set;}

    //Implementation of IEquatable<T> interfaces
    public bool Equals(Car? , car){

        return (this.Make , this.Model , this.Year)==(Car?.Make ,Car?.Model , Car?.Year);

    }
}
