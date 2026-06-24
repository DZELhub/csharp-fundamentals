namespace MyFirstProject.Lessons {
public static class Lesson50_Constructors{
public static void Run()
        {
            Question question1 = new Question(1, "Hangisi programlama dili değildir", new string[5] {"Pyhton", "C#", "JavaScript", "Java", "HTML"},"HTML" );

            Question question2 = new Question(2,"Hangisi en popüler programlama dilidir?",new string[5] {"Pyhton", "C#", "JavaScript", "Java", "HTML"}, "C#");

            Question question3 = new Question(3, "Hangisi en popüler web programlama platfor mu değildir?",new string[5] {"Django", "Asp.net", "Spring", "Python", "HTML"},"Python");

        }
    }

    class Question
    {
        public Question(int questionId, string questionText, string[] options, string answers)
        {
            this.QuestionId = questionId;
            this.QuestionText = questionText;
            this.Options = options;
            this.Answers = answers;
        }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; } = "";
        public string[] Options { get; set; } = Array.Empty<string>();
        public string Answers { get; set; } = "";

        public bool answerControl(string answer)
        {
            return this.Answers.ToLower() == answer.ToLower();
        }
    }

}