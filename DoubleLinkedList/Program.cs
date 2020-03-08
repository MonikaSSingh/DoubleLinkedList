using System;

public class Program
{
    public static void Main()
    {
        Customer Cust1 = new Customer()
        {
            FirstName = "Rocky",
            LastName = "Sampson",
            DOB = new DateTime(1980, 10, 10),
            NextPointer = null
        };

        Customer Cust2 = new Customer()
        {
            FirstName = "Sonia",
            LastName = "Jackson",
            DOB = new DateTime(1985, 1, 1),
            NextPointer = null,
            PreviousPointer = Cust1
        };

        Customer Cust3 = new Customer()
        {
            FirstName = "Robert",
            LastName = "Cullen",
            DOB = new DateTime(1990, 12, 10),
            NextPointer = null,
            PreviousPointer = Cust2
        };
        Customer Cust4 = new Customer()
        {
            FirstName = "Anubhav",
            LastName = "Sinha",
            DOB = new DateTime(1995, 7, 30),
            NextPointer = null,
            PreviousPointer = Cust3
        };

        Cust1.NextPointer = Cust2;
        Cust2.NextPointer = Cust3;
        Cust3.NextPointer = Cust4;

        Customer HeaderNode = Cust1;

        while (HeaderNode != null)
        {

            Console.WriteLine("Full Name : {0} {1} and Age : {2}", HeaderNode.FirstName, HeaderNode.LastName, HeaderNode.CalculateAge());
            HeaderNode = HeaderNode.NextPointer;
        }
        Console.WriteLine("After Reversing : -");
        Customer TailNode = Cust4;
        while (TailNode != null)
        {
            Console.WriteLine("Full Name : {0} {1} and Age : {2}", TailNode.FirstName, TailNode.LastName, TailNode.CalculateAge());
            TailNode = TailNode.PreviousPointer;
        }
        Console.ReadLine();
    }
    class Customer
    {
        public string FirstName;
        public string LastName;
        public DateTime DOB;

        public Customer NextPointer;
        public Customer PreviousPointer;

        public int CalculateAge()
        {
           TimeSpan Age = (DateTime.Now - DOB);
           int Days = Age.Days;
           int Years = Days / 365;

            //int Years = new DateTime((DateTime.Now - DOB).Ticks).Year;
            return Years;
        }
    }

}