namespace Applogic;
public class Person
{
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static string FullName()
    {
        System.Console.WriteLine("What is your first name?");
        string fname1 = Console.ReadLine();
        System.Console.WriteLine("Second name?");
        string sname2 = Console.ReadLine();
        return fname1 + " " + sname2;
    }
}
