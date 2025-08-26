using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class Questions : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";

    public string GetQuestion()
    {
        return question;
    }
}

public class Test
{
    Questions questionSO;

    void TestA()
    {
        string questionText = questionSO.GetQuestion();
    }
}
