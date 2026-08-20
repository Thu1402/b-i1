namespace OOP_Prog.Session_01
{
public class Student 
	{
	public string id;
	public string name;
	public void DisplayStudentInfo() 
		{
		Console.Writeline($"Student ID: {id}, Name: {name}");
		}
	}
	public class UT1
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student();
			Student s2 = new Student();
			
			s1.id = "33254020040";
			s1.name = "Thu";
			
			s2.id = "33254020041";
			s2.name = "Nhi";
			
			s1.DisplayStudentInfo();
			s2.DisplayStudentInfo();
		}
	}
}
