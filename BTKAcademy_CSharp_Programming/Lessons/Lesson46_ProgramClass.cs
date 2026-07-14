namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson46_ProgramClass
    {
        public static void Run()
        {
            Console.WriteLine("Program Başladı");

            Student student = new Student();

            student.Name = "Celal";
            student.Age = 38;

            Console.WriteLine(
                $"""
                İsim: {student.Name}
                Yaş: {student.Age}
                """
            );
        }

        class Student
        {
            public string? Name;
            public int Age;
        }
    }
}