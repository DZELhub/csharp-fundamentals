namespace MyFirstProject.Lessons
{
    public static class Lesson47_ClassExercise
    {
        public static void Run()
        {
            Console.WriteLine("Welcome D.Z.E.L. System...");

            Student student1 = new Student
            {
                studentNumber = "302",
                fullName = "Ahmet Ozan",
                branchName = "9/C"
            };

            Student student2 = new Student
            {
                studentNumber = "545",
                fullName = "Ali Kardeş",
                branchName = "9/İ"
            };

            Student student3 = new Student
            {
                studentNumber = "603",
                fullName = "Fikret Güneş",
                branchName = "9/F"
            };

            Student[] students = {student1, student2, student3};

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"{student.studentNumber} numaralı öğrencinin adı {student.fullName} ve şubesi {student.branchName}"
                );
            }
            
        }
    }
    class Student
    {
        public string studentNumber {get; set;} = "";
        public string fullName {get; set;} = "";
        public string branchName {get; set;} = "";
    }
}