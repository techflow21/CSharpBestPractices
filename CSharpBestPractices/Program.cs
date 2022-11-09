// 15 C# Best Practices
// 1.Method argument and Local variables should always be in Camel Case  

// Correct Way
public class Student
{
    public void PrintDetails(int studentId, String firstName)
    {
        int totalFee = 200000;
        // ...
    }
}



//2.Avoid the use of underscore while naming identifiers  

// Correct Way
public DateTime fromDate;
public String firstName;


// Avoid this way
public DateTime from_Date;
public String first_Name;




//3.Class and Method names should always be in Pascal Case 

public class Student
{
    public Student GetDetails()
    {
        //...
    }
    public double GetFee()
    {
        //...
    }
}




//4.Do declare all member variables at the top of a class, with static variables at the very top.

public class Student
{
    Public static string studentType;
    Public string studentName { get; set; };
    Public int studentFees { get; set};
    Public Student()
    {
        //..
    }
}



//5.Always declare the variables as close as possible to their use.  

// Correct Way
String firstName = "Bello";
Console.WriteLine(firstName);
//--------------------------

// Avoid this Way
String firstName = "Bello";
//--------------------------
//--------------------------
//--------------------------
Console.WriteLine(firstName);



//6.Always declare the properties as private so as to achieve Encapsulation and ensure data hiding.  

// Correct
private int studentId { get; set; }

// Avoid
public int studentId { get; set; }




//7.Always separate the methods, different sections of program by one space.  

// Correct
class Student
{
    private int studentId { get; set; }

    public void PrintDetails()
    {
        //------------
    }
}

// Avoid
class Student
{

    private int studentId { get; set; }



    public void PrintDetails()
    {
        //------------
    }

}




//8.Constants should always be declared in UPPER_CASE.  

// Correct
public const int MIN_AGE = 18;
public const int MAX_AGE = 60;

// Avoid
public const int Min_Age = 18;
public const int Max_Age = 60;



//9.Avoid the use of System data types and prefer using the Predefined data types.

// Correct Way
int studentId;
string studentName;
bool isPresent;


// Avoid this Way
Int32 studentId;
String studentName;
Boolean isPresent;




//10.Always prefix an interface with letter I.

// Correct
public interface IEmployee
{
}
public interface IShape
{
}


// Avoid
public interface Employee
{
}
public interface Shape
{
}




//11.For better code indentation and readability always align the curly braces vertically.  

// Correct
class Student
{
    static void PrintDetails()
    {
    }
}

// Avoid
class Student
{
    static void PrintDetails()
    {
    }
}



//12.Do not suffix enum names with Enum.

Avoid this Way:
Public enum DirectionEnum
{
    //..
}




//13.To declare an empty method that only returns a view in the MVC, we should use the expression body.
Avoid:
Public ActionResult Login()
{
    return View();
}

Correct:
Public ActionResult Login () => View();




//14.To check for null or empty conditions, use the following:

Avoid:
var studentName =”testing”;
if (studentName != null && studentName !=””)
{
    //..
}
Correct:
var studentName =”testing”;
if (!string.IsNullOrEmpty(studentName))
{
    //..
}



//15.Do object initialization like below:
//Correct Way
var test = new Test
{
    Id = 1;
    Name =”value”;
};

//Avoid this Way
Test test = new Test();
test.id = 1;
test.name =”value”;

