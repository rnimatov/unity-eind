using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAblackBlue; // blue is waiting
    public GameObject answerAblackGreen; // green is correct
    public GameObject answerAblackRed; // red is wrong

    public GameObject answerBblackBlue; // blue is waiting
    public GameObject answerBblackGreen; // green is correct
    public GameObject answerBblackRed; // red is wrong

    public GameObject answerCblackBlue; // blue is waiting
    public GameObject answerCblackGreen; // green is correct
    public GameObject answerCblackRed; // red is wrong

    public GameObject answerDblackBlue; // blue is waiting
    public GameObject answerDblackGreen; // green is correct
    public GameObject answerDblackRed; // red is wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;

    public GameObject visual001;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "Best: " + bestScore;
    }

    void Update()
    {
        currentScore.GetComponent<Text>().text = "score: " + scoreValue; 
    }


    public void AnswerA()
    {
        if (questionGenerator.actualAnswer == "A")
        {
            answerAblackGreen.SetActive(true);
            answerAblackRed.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerAblackRed.SetActive(true);
            answerAblackBlue.SetActive(false);
            scoreValue += -5;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }

    public void AnswerB()
    {
        if (questionGenerator.actualAnswer == "B")
        {
            answerBblackGreen.SetActive(true);
            answerBblackRed.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerBblackRed.SetActive(true);
            answerBblackBlue.SetActive(false);
            scoreValue += -5;
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (questionGenerator.actualAnswer == "C")
        {
            answerCblackGreen.SetActive(true);
            answerCblackRed.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerCblackRed.SetActive(true);
            answerCblackBlue.SetActive(false);
            scoreValue += -5;
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (questionGenerator.actualAnswer == "D")
        {
            answerDblackGreen.SetActive(true);
            answerDblackRed.SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answerDblackRed.SetActive(true);
            answerDblackBlue.SetActive(false);
            scoreValue += -5;
        }

        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = " best: " + scoreValue;  
        }
        yield return new WaitForSeconds(1);

        visual001.SetActive(false);

        answerAblackGreen.SetActive(false);
        answerBblackGreen.SetActive(false);
        answerCblackGreen.SetActive(false);
        answerDblackGreen.SetActive(false);

        answerAblackRed.SetActive(false);
        answerBblackRed.SetActive(false);
        answerCblackRed.SetActive(false);
        answerDblackRed.SetActive(false);

        answerAblackBlue.SetActive(true);
        answerBblackBlue.SetActive(true);
        answerCblackBlue.SetActive(true);
        answerDblackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        questionGenerator.displayingQuestion = false; 
    }
}
