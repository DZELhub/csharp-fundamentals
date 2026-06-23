namespace MyFirstProject.Lessons {
public static class Lesson48_Methods{
public static void Run() {

Student1 stu1 = new Student1() { studentNumber = "302", fullName = "Ahmet Ozan", branchName = "9/C"};

Student1 stu2 = new Student1() { studentNumber = "545", fullName = "Ali Kardeş", branchName = "9/İ"};

Student1 stu3 = new Student1() { studentNumber = "603", fullName = "Fikret Güneş", branchName = "9/F"};

Student1[] students = {stu1, stu2, stu3};

foreach (Student1 student in students) {
Console.WriteLine(student.GetInfo());
}

}
}

class Student1 {

//* Property

public string studentNumber {get; set;} = "";
public string fullName {get; set;} = "";
public string branchName {get; set;} = "";

//* Methods

public string GetInfo() {
return $"{this.studentNumber} numaralı öğrencinin adı {this.fullName} ve şubesi {this.branchName}";
}
}

}