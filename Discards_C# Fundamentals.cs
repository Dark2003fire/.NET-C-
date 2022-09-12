/*
 Discards :-->

       which are placeholder variables thatareintentionally unused in
       application code. Discards areequivalent to unassigned variables; they don't havea value.
       Discards make the intent of your code clear. A discard indicates that our code never uses thevariable.They
       enhance its readability and maintainability

 */


using System;
using namespace std ;

/*
 For example, thefollowing QueryCityDataForYears method returns a tuple with the name of a city, its
area,a year, the city's population for that year,a second year,and the city's population for that second year..

 */
public class Discards_Variables // This clas will give info about discards variables
{

    var(_ , _ , _ , pop1 , pop2) = QueryCityforYears("Newyork" , 1960  , 2010);

    Console.WriteLine($"Population is changing from 1960 to 2010: {pop2-pop1 :N0}");


/*


     The example shows the change in population between those two years. Of the data available from the tuple, we're
     unconcerned with the city area,and we know the city name and the two dates at design-time.
*/

    static(string , double , int  , int , int , int)QueryCityforYears(string name int year1 , int year2)
    {

        int Population1 = 0 , population= 2;
        double area = 0;

        if(name = "Newyork"){

            area = 466.86;

            if(year1==1960){

                population1 = 8869556;


            }
            if(year2 == 2010){

                population2 = 8956856;

            }
            return(name ,  area , year1 , population1  ,year2 ,  population2);



/*

 As a result, we're only interested in the two population values stored in the tuple,and can handle its remaining values as discards;
 */

        }

        return("" , 0 , 0 , 0 , 0 ,0);

    }

}
/*
  The deconstructed  method of a class structure or interface also allows you to retrieve and deconstruct a specific
  set of data from an object.



  The following example deconstructs a Person object into four strings (the first and last
  names, the city,and the state), but discards the last name and the state

 */

namespace discards
{
    public class Person
    {

        public FirstName {get;set;}
        public MiddleName{get;set;}
        public LastName{get;set;}
        public City{get;set;}
        public State{get;set;}



        public Person(string fname , string mname , string lname , string city , string state)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
            city = City;
            state = State;


        }

        //Returns  the first and last name
        public void  Deconstruct(out string fname  , out string lname)
        {

            fname = FirstName;
            lname = LastName;

        }
        public void Deconstruct(out string fname   , out string mname  , out string lname )
        {
            fanme = FirstName;
            mname = MiddleName;
            lname = LastName;


        }

        public void Deconstruct(out string fname  , out string lname  , out string city , out string state)
        {

            fname = FisrtName;
            lname = LastName;
            city = City;
            state = State;


        }
    }

    public class example
    {
        public static void Main(string[]args)
        {
            var p = new Person("Hitesh" , "Raji" ,"Asjad" , "Faizan" , "Zeeshan");
            // Deconstruct the Person object.

            var(fname , city , ) = p;
            Console.WriteLine($"Hello{fname} of {city}!");

        }
    }
}



/*
 The discard pattern can be used in pattern matching with the switch expression.Every expression, including
null ,always matches the discard pattern.
 */
object?[] objects = { CultureInfo.CurrentCulture,
                      CultureInfo.CurrentCulture.DateTimeFormat,
                      CultureInfo.CurrentCulture.NumberFormat,
                      new ArgumentException(), null };


foreach (var obj in objects)
    ProvidesFormatInfo(obj);

static void ProvidesFormatInfo(object? obj) =>
Console.WriteLine(obj switch
{
     IFormatProvider fmt => $"{fmt.GetType()} object",
     null => "A null object reference: Its use could result in a NullReferenceException",
     _ => "Some object type without format information"

});



/*
Calls to methods with out parameters:-->

The following example calls the DateTime.Try Parse(String, out DateTime) method to determine whether the
string representation of a dateis valid in the current culture.



 */


string[] dateStrings = {"05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
"2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
"5/01/2018 14:57:32.80 -07:00",
"1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
"Fri, 15 May 2018 20:10:57 GMT" };


foreach (string dateString in dateStrings)
{
    if (DateTime.TryParse(dateString, out _))
      Console.WriteLine($"'{dateString}': valid");
   else
     Console.WriteLine($"'{dateString}': invalid");
}



































