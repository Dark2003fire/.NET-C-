/*
 The Example also shows how workItem overrides the virtual method Object.ToString and how
 the changeRequest class inherits the workItem implementation of the method:->


 */

using System;
using namespace std;
//workItem implicitly inherits form the object class.
public class WorkItem{

    //static field currentID stores the JobID of the last WorkItem that has been  created
    private static int currentID;

    //properties.
    protected int ID{get;set;}
    protected string Title{get;set;}
    protected string Description {get;set;}
    protected TimeSpan jobLength{get;set;}


    //Default  constructor . If a derived class does not  invoke a base class constructor
    //explicitly , the default constructor is called implicitly.

    public WorkItem(){

        ID = 0;
        Title = "Deafult title";
        Description = "Default description";
        jobLength = new TimeSpan();

    }

    // Instance constructor that has three Parameters;
    public WorkItem(string title ,  string desc , TimeSpan joblen){

        this.ID = GetNextID();
        this.Title = title;
        this.Description = desc;
        this.jobLength = joblen;


    }
    /*Static construtor to initialize the static members , currentID
     This constructor is called ine Time , automatically before any instance
     of workItem or changeRequest is created or currentID is referenced .

     */

    static WorkItem()=> currentID=0;

//currentID is a static field .It is incremented each time a new intance of WorkItem is created.

    protected int GetNextID ()=> ++currentID;

    //Method Update enables you to update the title and job length of an existing workItem Object.

    public void Update(string title  , TimeSpan joblen){

        this.Title = title;
        this.jobLength = joblen;

    }

    //Virtual method override of the ToString method that is inherited from System.Object

    public override string ToString()=>$"{this.ID}-{this.Title}";


}
//ChangeRequest derives from WorkItem and adds a property(originalItemID)and two construtor.
public class ChangeRequest : WorkItem{

    protected int originalItemID{get;set;}
    /*construtor becuz neither constructor calls a base-class
      constructor explicitly , the default constructor in the base class
     is called implicitly. The base class must contain a default constructor.*/

    // Default constructor for the derived class.
    public ChangeRequest(){

        // Instance construtor that has  four Parameters:->
        public changeRequest(string title , string desc , TimeSpan joblen , int originalItemID){

            //The following properties and GetNextID Method are inherited from WorkItem.

            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;


            //property originalItemID is members of changeRequest , but not of WorkItem.

            this.originalItemID = originalID;

        }
    }

    // Create an instance of WorkItem by using the constructor in the  base class that
    // three arguments.

    WorkItem item = new WorkItem("Fix bugs" ,
                                 "Fix all bugs in my code branch" ,
                                 new TimeSpan(3,4,,0,0));

    //create an instance of the ChangeRequest by using the constructor in the derived
    // class that takes four arguments.

    ChangeRequest change = new ChangeRequest("Change Base class Design ",
                                             "Add members to the class" ,
                                             new TimeSpan(4,0,0),1);

    //Use the ToString method defined in WorkItem.
    Console.WriteLine(item.ToString());

    // Use the inherited update method to change the title of the ChangeRequest Object.

    change.Update("Change the design of the Base Class" , new TimeSpan(4,0,0));

    //ChangeRequest inherits WorkItem's override of ToString.
    Console.WriteLine(change.ToString());

}
