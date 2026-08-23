namespace SS01
{
    public class Student
    {
        private string name;
        private double score;
        private static int totalStudents = 0;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudents++;
        }

        // TODO: write instance methods here
		public string GetName()
        {
            return name;
        }
        public double GetScore()
        {
            return score;
        }
		public bool IsPassed() 
		{ 
			return score >= 5.0; 
		}
        public string GetClassification()
        {
            if (score >= 8.0)
            {
                return "Excellent";
            }
            else if (score >= 6.5)
            {
                return "Good";
            }
            else if (score >= 5.0)
            {
                return "Average";

            }
            else
            {
                return "Weak";
            }
        }

        // TODO: write static methods here
        public static int GetTotalStudents()
        {
            return totalStudents;
        }
        public static Student FindTopStudent(Student[] students)
        {
            Student topStudent = students[0];
            foreach (Student student in students)
            {
                if (student.score > GetHighestScore())
                {
                    highestScore = student.score;
                    topStudent = student;
                }
            }
            return topStudent;
        }

        private static object GetHighestScore()
        {
            return highestScore;
        }

        public static double CalculateAverageScore(Student[] students)
        {
            double totalScore = 0;
            foreach (Student student in students)
            {
                totalScore += student.score;
            }
            return totalScore / students.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: create array of Student objects
            //câu 1
            Student[] students = {
                new Student("Alice", 9.0),
                new Student("Bob", 7.5),
                new Student("Charlie", 6.0),
                new Student("David", 4.5),
                new Student("Eve", 8.5)
             };

            // TODO: call static and instance methods as required
            //câu 2
            Console.WriteLine("Total Students: " + Student.GetTotalStudents());

            //câu 3
            Console.WriteLine("Student List:");
            foreach (Student student in students)
            {
               Console.WriteLine($"Name: {student.GetName()}, " +
                    $"Score: {student.GetScore()}, " +
                    $"Classification: {student.GetClassification()}" +
                    $"Status:{(student.IsPassed() ? "Passed" : "Failed")}");
            }

            //câu 4
            Student topStudent = Student.FindTopStudent(students);
            Console.WriteLine("Top Student: " + topStudent.GetName() + "Score: "+ topStudent.GetScore());

            //câu 5
            double averageScore = Student.CalculateAverageScore(students);
            Console.WriteLine("Average Score: " + averageScore);
        }
    }

}
namespace SS02
{


}