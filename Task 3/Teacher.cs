namespace Task_3;

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        System.Console.WriteLine("Teacher teaches in English");
    }

    public void SalaryInfo()
    {
        System.Console.WriteLine("Salary information cannot be overridden.");
    }
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        System.Console.WriteLine("Teacher teaches in Nepali");
    }
}

public class EnglishTeacher : Teacher
{
    // Uses base Teaching() method
}