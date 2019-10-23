using System;
using static System.Console;

class Employee : IComparable                //needed for comparing arrays in objects.
{
    private int idNumber;
    public int IdNumber
    {
        get
        {
            return idNumber;
        }
        set
        {
            idNumber = value;
        }
    }
    public double Salary { get; set; }
    public Employee()      //this is a default constructor  
    {
        idNumber = 9;
    }
    

    public Employee(int A)      //when user input is only one int, it goes here     //constructor  
    {
        IdNumber = A;
        Salary = 0;
        WriteLine("Employee object {0} created", IdNumber);
    }

    public Employee(int B, double money)  //overloaded parameter              //constructor  
    {
        IdNumber = B;
        Salary = money;
        WriteLine("Employee object {0} created with salary of {1}", IdNumber, Salary.ToString("C"));
    }

    ~Employee()       //this is a destructor dont know how to call it tho
    {
        WriteLine("The destructor is here. Employee{0} is shut down", IdNumber);
    }

    int IComparable.CompareTo(Object o)      //needed to sort arrays in Objects.  //if you want to compare more values, you should add more to Comparable eg; salary
    {
        int returnVal;
        Employee temp = (Employee)o;
        if (this.IdNumber > temp.IdNumber)
            returnVal = 1;
        else
            if (this.IdNumber < temp.IdNumber)
            returnVal = -1;
        else
            returnVal = 0;
        return returnVal;
    }


}

class retard
{
    static void Main()
    {
        Employee idiot = new Employee { IdNumber = 90 };
        Employee[] worker = new Employee[3];                 //this statement will only create/reserve memory for 3 workers but does not create the object.
        for (int x = 0; x < worker.Length; ++x)
        {
            worker[x] = new Employee();                          // this will create the objects.
        }
        worker[0].IdNumber = 100;
        worker[1].IdNumber = 69;
        worker[2].IdNumber = 70;
        Employee seek = new Employee();
        seek.IdNumber = 69;
        Array.Sort(worker);
        WriteLine("Sorted Employees: ");
        for (int i = 0; i < worker.Length; ++i)
        {
            WriteLine("Employee number{0}: {1} {2}", i, worker[i].IdNumber, worker[i].Salary.ToString("C"));
        }
        int z = Array.BinarySearch(worker, seek);
        WriteLine(z);

        Employee sampleobjectcreated = new Employee (1, 22.2);
        Employee aWorker = new Employee(201);

        // int answer = worker[1].CompareTo(worker[2]);                       // wont work idk y



        //WriteLine("Hey {0}", idiot.IdNumber);
        //WriteLine("Hey {0}", idiot.Salary);
    }
}
