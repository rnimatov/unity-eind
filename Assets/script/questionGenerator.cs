using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001;
    public GameObject visual002;


    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 31);

            if (questionNumber == 1)
            {
                
                QuestionDisplay.newQuestion = "how much could a chuck chuck if a wood could chuck wood?";
                QuestionDisplay.newA = "A. lot and lots of wood";
                QuestionDisplay.newB = "B. harldy any";
                QuestionDisplay.newC = "C. none";
                QuestionDisplay.newD = "D. a few";
                actualAnswer = "A";
            }
            if (questionNumber == 2)
            {
           
                QuestionDisplay.newQuestion = "who is better Ronaldo or Messi?";
                QuestionDisplay.newA = "A. Ronaldo";
                QuestionDisplay.newB = "B. Messi";
                QuestionDisplay.newC = "C. nobody";
                QuestionDisplay.newD = "D. both are equally good";
                actualAnswer = "A";
            }
            if (questionNumber == 3)
            {
                
                QuestionDisplay.newQuestion = "What is more fun to do?";
                QuestionDisplay.newA = "A. swimming";
                QuestionDisplay.newB = "B. football";
                QuestionDisplay.newC = "C. hockey";
                QuestionDisplay.newD = "D. basketball";
                actualAnswer = "B";
            }
            if (questionNumber == 4)
            {
               
                QuestionDisplay.newQuestion = "what is the name of luigi brother?";
                QuestionDisplay.newA = "A. D.K";
                QuestionDisplay.newB = "B. Toad";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                actualAnswer = "C";
            }

            if (questionNumber == 5)
            {

                QuestionDisplay.newQuestion = "Who is this person?";
                QuestionDisplay.newA = "A. Messi";
                QuestionDisplay.newB = "B. Hazard";
                QuestionDisplay.newC = "C. Dont know";
                QuestionDisplay.newD = "D. Ronaldo";
                visual001.SetActive(true);
                actualAnswer = "D";
            }

            if (questionNumber == 6)
            {

                QuestionDisplay.newQuestion = "What year is it?";
                QuestionDisplay.newA = "A. 2019";
                QuestionDisplay.newB = "B. 1995";
                QuestionDisplay.newC = "C. 2023";
                QuestionDisplay.newD = "D. 2050";
                actualAnswer = "C";
            }

            if (questionNumber == 7)
            {

                QuestionDisplay.newQuestion = "What game is the best?";
                QuestionDisplay.newA = "A. Fortnite";
                QuestionDisplay.newB = "B. warzone";
                QuestionDisplay.newC = "C. residant evil";
                QuestionDisplay.newD = "D. none";
                actualAnswer = "D";
            }

            if (questionNumber == 8)
            {

                QuestionDisplay.newQuestion = "Who is the current presidant of America?";
                QuestionDisplay.newA = "A. Joe Biden";
                QuestionDisplay.newB = "B. Donald Trump";
                QuestionDisplay.newC = "C. Obama";
                QuestionDisplay.newD = "D. Elizabeth";
                actualAnswer = "A";
            }


            if (questionNumber == 9)
            {

                QuestionDisplay.newQuestion = "which subject is the most fun?";
                QuestionDisplay.newA = "A. English";
                QuestionDisplay.newB = "B. Math";
                QuestionDisplay.newC = "C. Dutch";
                QuestionDisplay.newD = "D. None";
                actualAnswer = "D";
            }

            if (questionNumber == 10)
            {

                QuestionDisplay.newQuestion = "Where is China?";
                QuestionDisplay.newA = "A. Asia";
                QuestionDisplay.newB = "B. Eu";
                QuestionDisplay.newC = "C. US";
                QuestionDisplay.newD = "D. Africa";
                actualAnswer = "A";
            }

            if (questionNumber == 11)
            {

                QuestionDisplay.newQuestion = "Where is the Netherlands?";
                QuestionDisplay.newA = "A. US";
                QuestionDisplay.newB = "B. Eu";
                QuestionDisplay.newC = "C. Asia";
                QuestionDisplay.newD = "D. Africa";
                actualAnswer = "B";
            }

            if (questionNumber == 12)
            {

                QuestionDisplay.newQuestion = "12 + 12 = ?";
                QuestionDisplay.newA = "A. 12";
                QuestionDisplay.newB = "B. 34";
                QuestionDisplay.newC = "C. 24";
                QuestionDisplay.newD = "D. 26";
                actualAnswer = "C";
            }

            if (questionNumber == 13)
            {

                QuestionDisplay.newQuestion = "What school is this?";
                QuestionDisplay.newA = "A. Sintlucas";
                QuestionDisplay.newB = "B. Gilde";
                QuestionDisplay.newC = "C. Suma";
                QuestionDisplay.newD = "D. Valuas";
                actualAnswer = "A";
            }

            if (questionNumber == 14)
            {

                QuestionDisplay.newQuestion = "2 x 2 = ?";
                QuestionDisplay.newA = "A. 4";
                QuestionDisplay.newB = "B. 8";
                QuestionDisplay.newC = "C. 3";
                QuestionDisplay.newD = "D. 2";
                actualAnswer = "A";
            }

            if (questionNumber == 15)
            {

                QuestionDisplay.newQuestion = "What is this cup made out of?";
                QuestionDisplay.newA = "A. Sand";
                QuestionDisplay.newB = "B. Glass";
                QuestionDisplay.newC = "C. Paper";
                QuestionDisplay.newD = "D. Plastic";
                actualAnswer = "B";
            }

            if (questionNumber == 16)
            {

                QuestionDisplay.newQuestion = "What material is the strongest?";
                QuestionDisplay.newA = "A. Metal";
                QuestionDisplay.newB = "B. Sand";
                QuestionDisplay.newC = "C. wood";
                QuestionDisplay.newD = "D. Plastic";
                actualAnswer = "A";
            }

            if (questionNumber == 17)
            {

                QuestionDisplay.newQuestion = "Who is this person?";
                QuestionDisplay.newA = "A. Samed";
                QuestionDisplay.newB = "B. Jonny";
                QuestionDisplay.newC = "C. Andrew";
                QuestionDisplay.newD = "D. Jonathan";
                visual002.SetActive(true);
                actualAnswer = "A";
            }

            if (questionNumber == 18)
            {

                QuestionDisplay.newQuestion = "Waar komt Morta vandaan?";
                QuestionDisplay.newA = "A. Afghanistan";
                QuestionDisplay.newB = "B. kyrgyzie";
                QuestionDisplay.newC = "C. Netherlands";
                QuestionDisplay.newD = "D. Germany";
                actualAnswer = "A";
            }

            if (questionNumber == 19)
            {

                QuestionDisplay.newQuestion = "12 : 3 = ?";
                QuestionDisplay.newA = "A. 4";
                QuestionDisplay.newB = "B. 2";
                QuestionDisplay.newC = "C. 6";
                QuestionDisplay.newD = "D. 9";
                actualAnswer = "A";
            }

            if (questionNumber == 20)
            {

                QuestionDisplay.newQuestion = "9 + 9 = ?";
                QuestionDisplay.newA = "A. 18";
                QuestionDisplay.newB = "B. 16";
                QuestionDisplay.newC = "C. 19";
                QuestionDisplay.newD = "D. 17";
                actualAnswer = "A";
            }

            if (questionNumber == 21)
            {

                QuestionDisplay.newQuestion = "what does hgh mean?";
                QuestionDisplay.newA = "A. Het gaat hoog?";
                QuestionDisplay.newB = "B. Hecht gaat slecht";
                QuestionDisplay.newC = "C. Hoe gaat het?";
                QuestionDisplay.newD = "D. Alles Goed?";
                actualAnswer = "C";
            }

            if (questionNumber == 22)
            {

                QuestionDisplay.newQuestion = "What does LOL mean?";
                QuestionDisplay.newA = "A. Last of lost?";
                QuestionDisplay.newB = "B. How are you doin?";
                QuestionDisplay.newC = "C. I don't know";
                QuestionDisplay.newD = "D. Laugh out loud";
                actualAnswer = "D";
            }

            if (questionNumber == 23)
            {

                QuestionDisplay.newQuestion = "What does IDK mean?";
                QuestionDisplay.newA = "A. How are you??";
                QuestionDisplay.newB = "B. I don't know?";
                QuestionDisplay.newC = "C. You don't know";
                QuestionDisplay.newD = "D. Don't know";
                actualAnswer = "B";
            }

            if (questionNumber == 24)
            {

                QuestionDisplay.newQuestion = "What does TMI mean?";
                QuestionDisplay.newA = "A. Don't know?";
                QuestionDisplay.newB = "B. Laughing out loud";
                QuestionDisplay.newC = "C. Last of laugh";
                QuestionDisplay.newD = "D. Too much information";
                actualAnswer = "D";
            }

            if (questionNumber == 25)
            {

                QuestionDisplay.newQuestion = "What does NVM mean?";
                QuestionDisplay.newA = "A. Never mind?";
                QuestionDisplay.newB = "B. Do you mind?";
                QuestionDisplay.newC = "C. I don't know";
                QuestionDisplay.newD = "D. Lauging";
                actualAnswer = "A";
            }

            if (questionNumber == 26)  
            {

                QuestionDisplay.newQuestion = "What does LMK mean?";
                QuestionDisplay.newA = "A. Do not let me know?";
                QuestionDisplay.newB = "B. Let me know?";
                QuestionDisplay.newC = "C. I don't know";
                QuestionDisplay.newD = "D. As far as I know";
                actualAnswer = "B";
            }

            if (questionNumber == 27)
            {

                QuestionDisplay.newQuestion = "What does TL;DR mean?";
                QuestionDisplay.newA = "A. Let me know?";
                QuestionDisplay.newB = "B. Never mind?";
                QuestionDisplay.newC = "C. As far as I know";
                QuestionDisplay.newD = "D. Too long, didn't read";
                actualAnswer = "D";
            }

            if (questionNumber == 28)
            {

                QuestionDisplay.newQuestion = "What does FTW mean?";
                QuestionDisplay.newA = "A. For the win";
                QuestionDisplay.newB = "B. Too long, didn't read";
                QuestionDisplay.newC = "C. Let me know";
                QuestionDisplay.newD = "D. I don't know";
                actualAnswer = "A";
            }

            if (questionNumber == 29)
            {

                QuestionDisplay.newQuestion = "What does JK mean?";
                QuestionDisplay.newA = "A. I don't know";
                QuestionDisplay.newB = "B. Do you mind";
                QuestionDisplay.newC = "C. Never mind";
                QuestionDisplay.newD = "D. Just kidding";
                actualAnswer = "D";
            }

            if (questionNumber == 30)
            {

                QuestionDisplay.newQuestion = "What does JW mean";
                QuestionDisplay.newA = "A. Just kiddin";
                QuestionDisplay.newB = "B. I don't know";
                QuestionDisplay.newC = "C. Just wondering";
                QuestionDisplay.newD = "D. Do you mind";
                actualAnswer = "C";
            }


            // all quesitons co foo this line 
            QuestionDisplay.pleaseUpdate = false;    

        }
    }
}
