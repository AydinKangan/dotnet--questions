public class Add
{
    public static QuestionAnswer AddQuestion(string question, string answer)
    {
        QuestionAnswer newQuestion = new QuestionAnswer();
        newQuestion.question = question;
        newQuestion.answer = answer;

        return newQuestion;

    }
}
