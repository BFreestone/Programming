using UnityEngine;
using System;
using System.Globalization;
using Unity.VisualScripting;

public class Ifstatementchallenges : MonoBehaviour
{
    public int score = 80;
    public int playerHealth = 30;
    public int examScore = 85;
    public int playerSpeed = 10;
    public int enemySpeed = 12;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (examScore >= 90)
        {
            Debug.Log("You got an A");
        }

        else if (examScore >= 75)
        {
            Debug.Log("You got a B");
        }

        else
        {
            Debug.Log("You need to study harder");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
