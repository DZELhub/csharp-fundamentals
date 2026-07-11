namespace MyFirstProject.Lessons
{
    public static class Lesson50_Constructors
    {
        public static void Run()
        {
            Question question1 = new Question(
                1,
                "Hangisi programlama dili değildir?",
                new string[] { "Python", "C#", "JavaScript", "Java", "HTML" },
                "HTML"
            );

            Question question2 = new Question(
                2,
                "Hangisi en popüler programlama dilidir?",
                new string[] { "Python", "C#", "JavaScript", "Java", "HTML" },
                "C#"
            );

            Question question3 = new Question(
                3,
                "Hangisi web platformu değildir?",
                new string[] { "Django", "Asp.net", "Spring", "Python", "HTML" },
                "Python"
            );

            Question[] questions = { question1, question2, question3 };

            foreach (var question in questions)
            {
                Console.WriteLine($"\n{question.QuestionText}");

                foreach (var option in question.Options)
                {
                    Console.WriteLine(option);
                }

                Console.Write("Cevabınız: ");
                string answer = Console.ReadLine() ?? "";

                if (question.CheckAnswer(answer))
                {
                    Console.WriteLine("Doğru ✅");
                }
                else
                {
                    Console.WriteLine("Yanlış ❌");
                }
            }
        }
    }

    class Question
    {
        public Question(int questionId, string questionText, string[] options, string correctAnswer)
        {
            QuestionId = questionId;
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; } = "";
        public string[] Options { get; set; } = Array.Empty<string>();
        public string CorrectAnswer { get; set; } = "";

        public bool CheckAnswer(string answer)
        {
            return CorrectAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase);
        }
    }
}