namespace MyFirstProject.Lessons
{
    public static class Lesson51_AccessModifiers
    {
        public static void Run()
        {
            Question51 question1 = new Question51(1,"Soru 1",new string[] {"A Şıkkı","B Şıkkı","C Şıkkı","D Şıkkı"},"A Şıkkı");
            Question51 question2 = new Question51(2,"Soru 2",new string[] {"A Şıkkı","B Şıkkı","C Şıkkı","D Şıkkı"},"B Şıkkı");
            Question51 question3 = new Question51(3,"Soru 3",new string[] {"A Şıkkı","B Şıkkı","C Şıkkı","D Şıkkı"},"C Şıkkı"); 
 
            Console.WriteLine(question1.WriteQuestion());
            Console.WriteLine(question1.CheckAnswer("A Şıkkı"));

            Console.WriteLine(question2.WriteQuestion());
            Console.WriteLine(question2.CheckAnswer("C Şıkkı"));

            Console.WriteLine(question3.WriteQuestion());
            Console.WriteLine(question3.CheckAnswer("C Şıkkı"));

        }
    }

    class Question51
    {
        public Question51(int questionId, string questionText, string[] options, string correctAnswer)
        {
            QuestionId = questionId;
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
        private int QuestionId{get; set;}
        private string QuestionText{get; set;} = "";
        private string[] Options{get; set;} = Array.Empty<string>();
        public string CorrectAnswer{get; set;} = "";

        public string WriteQuestion()
        {
            string question = "";

            question += this.QuestionText + "\n";

            foreach(var options in this.Options)
            {
                question += options + "\n";
            }
            return question;
        }

        public bool CheckAnswer(string answer)
        {
            return CorrectAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase);
        }
    }
}