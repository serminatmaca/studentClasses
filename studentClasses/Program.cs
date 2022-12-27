
internal class Program
{

    private static void Main(string[] args)
    {

        Student student = new Student();

        student.Name = " sermin ";
        student.SurName = " ATMACA ";
        student.Year = 29;
        student.Class = 8;
        student.Number = 456;
        student.Epsode = " ky ";

        Console.WriteLine(student.Name + " - " + student.SurName + " - " + student.Year + " - " + student.Class + " -" + student.Number + " - " + student.Epsode + " - ");

        Console.ReadKey();




    }

    public class Student
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public int Year { get; set; }

        public int Class { get; set; }

        public int Number { get; set; }

        public string Epsode { get; set; }









    }
}
