using NUnit.Framework;
using Unity.Multiplayer.Center.Common;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class FunctionsScript : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintPlayerHealth();
        MultiplyNumbers(10, 5);
        IsEvenNumber(14);
        GetAgeCategory(15);
        CalculateAverage(14f, 72f);
        GetFirstLetter("Braden");
    }

    void PrintPlayerHealth()
    {
        int PlayerHealth = 100;
        Debug.Log("Player Health " + PlayerHealth);
    }

    void MultiplyNumbers(int number1, int number2)
    {
        int result;
        result = number1 * number2;
        Debug.Log("Result " + result);
    }

    void IsEvenNumber(int number1) // use bool IsEvenNumber()
    {
        
        if (number1 % 2 == 0)
        {
            
            Debug.Log("is even");
        }
        else
        {
            
            Debug.Log("is odd");
        }



    }

    void GetAgeCategory(int age)
    {

        if (age < 13)
        {
            Debug.Log("Age Category: Child");
        }

        else if (age >= 13 && age < 19)
        {
            Debug.Log("Age Category: Teen");
        }

        else if (age > 19)
        {
            Debug.Log("Age Category: Adult");
        }
    }

    void CalculateAverage(float number1, float number2)
    {
        float result = number1 / number2;
        Debug.Log("Average: " + result);
    }

    void GetFirstLetter(string name)
    {
        char[] letters = name.ToCharArray();

      // List<char> characters = new List<string>() {name};
        Debug.Log(letters[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
