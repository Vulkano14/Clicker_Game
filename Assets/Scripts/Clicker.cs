using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Clicker : MonoBehaviour
{
    //public ColorBlock cb;
    public Button tempButton;
    public Text textScore;
    public Text textHitPower;
    public Text textInfo;
    public Text timeScore;
    public Text timeScoreCurrent;
    public float hitPower;
    public float currentScore;
    public float scorePerSecond;
    public int x;
    public int amount1;
    public int amount2_timeScore;
    public int y; //Licznik x/s


    void Start()
    {
        currentScore = 0;
        hitPower = 1;
        x = 0;
        y = 0;
        amount1 = 25;
        amount2_timeScore = 500;
        scorePerSecond = 1;
        //cb = tempButton.colors;
        //cb.normalColor = Color.red;
        //tempButton.colors = cb;



    }

    void Update()
    {
        textScore.text = (int)currentScore + " $";
        textHitPower.text = hitPower + " power Hit";
        textInfo.text = "Buy power hit for: "+amount1+" $";
        timeScore.text = "Add Time Score "+(y + 1)+" /s: "+amount2_timeScore+" $";
        timeScoreCurrent.text = y +" $ per second";
        scorePerSecond = y * Time.deltaTime;
        currentScore = currentScore + scorePerSecond;
        

    }

    public void changeColorButton()
    {
        var color = tempButton.colors;
        color.normalColor = Color.red;
        tempButton.colors = color;

    }

    public void shop()
    {
        if(currentScore >= amount1)
        {
            currentScore -= amount1;
            hitPower = hitPower + 1;
            amount1 = amount1 * 2;
        }
    }

    public void clickerHit()
    {
        currentScore += hitPower;
    }

    public void timeScoreFunc()
    {
        if(currentScore >= amount2_timeScore)
        {
            currentScore -= amount2_timeScore;
            amount2_timeScore *= 2;
            y++;
        }
    }
}

