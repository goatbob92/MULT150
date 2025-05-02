using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange, chaos;
    private bool isGameOver = true;
    private bool isGameLost = false;
    [SerializeField] float elapsedTime = 0;
    public int timeLeft = 30;
    [SerializeField] TextMeshPro timerText;

    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
        if(timeLeft > 0 && !isGameOver)
        {
            elapsedTime += Time.deltaTime;
            if(elapsedTime >= 1)
            {
                elapsedTime %= 1;
                timeLeft -= 1;
                timerText.text = "0:" + timeLeft.ToString();
                if(timeLeft <= 15)
                {
                    if(timeLeft % 2 == 0)
                        timerText.color = Color.white;
                    else
                        timerText.color = Color.red;
                }
            }
        }
        else if(timeLeft <= 0)
        {
            isGameLost = true;
            isGameOver = true;
        }
        
    }

    void OnGUI()
    {
        if(isGameOver && !isGameLost)
        {
            Rect rect = new Rect (Screen.width / 2 - 100, Screen . height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "You Win!");
        }
        else if(isGameLost)
        {
            Rect rect = new Rect (Screen.width / 2 - 100, Screen . height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "You Lose!");
        }
    }
}
