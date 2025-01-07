using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [Header("UI Screens")]
    public GameObject testQuiz;
    public GameObject testQuestion;
    public GameObject testEnd;

    [Header("Question UI")]
    public TextMeshProUGUI questionText;
    public Button[] answerButtons;

    [Header("End Screen UI")]
    public TextMeshProUGUI endMessage;
    public GameObject coinImage; // Assign a coin image here.

    private int currentQuestionIndex = 0;
    private int score = 0;

    private string[] questions = {
        "What is the Tuna Academica's mascot?",
        "In which year was the IADE Tuna founded?",
        "What is the main instrument used in Tuna performances?"
    };

    private string[][] answers = {
        new string[] { "Lion", "Eagle", "Wolf", "Tuna Fish" },
        new string[] { "1995", "2000", "1985", "1990" },
        new string[] { "Guitar", "Drum", "Violin", "Accordion" }
    };

    private int[] correctAnswers = { 0, 2, 3 }; // Index of correct answers.

    void Start()
    {
        ShowTestQuiz();
    }

    public void StartQuiz()
    {
        score = 0;
        currentQuestionIndex = 0;
        ShowTestQuestion();
        LoadQuestion();
    }

    void LoadQuestion()
    {
        if (currentQuestionIndex < questions.Length)
        {
            questionText.text = questions[currentQuestionIndex];
            for (int i = 0; i < answerButtons.Length; i++)
            {
                answerButtons[i].GetComponentInChildren<Text>().text = answers[currentQuestionIndex][i];
                int index = i; // Capture index for lambda function.
                answerButtons[i].onClick.RemoveAllListeners();
                answerButtons[i].onClick.AddListener(() => CheckAnswer(index));
            }
        }
        else
        {
            ShowTestEnd();
        }
    }

    void CheckAnswer(int selectedIndex)
    {
        if (selectedIndex == correctAnswers[currentQuestionIndex])
        {
            score++;
        }
        currentQuestionIndex++;
        LoadQuestion();
    }

    void ShowTestQuiz()
    {
        testQuiz.SetActive(true);
        testQuestion.SetActive(false);
        testEnd.SetActive(false);
    }

    void ShowTestQuestion()
    {
        testQuiz.SetActive(false);
        testQuestion.SetActive(true);
        testEnd.SetActive(false);
    }

    void ShowTestEnd()
    {
        testQuiz.SetActive(false);
        testQuestion.SetActive(false);
        testEnd.SetActive(true);
        endMessage.text = "You answered " + score + " out of " + questions.Length + " correctly!";
        coinImage.SetActive(true); // Show the coin reward.
    }
}

