using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class Session3Challenge : MonoBehaviour
{

    public int myInt1 = 15;
    public float myFloat1;
    public float myFloat2 = 17.4f;
    public int myInt2;
    public string myString = "250";
    public int myInt3;
    public string myString2;
    public float myFloat3;
    public string input = "600";
    public int result;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myFloat1 = myInt1;
        
        myInt2 = (int)myFloat2;
       
        myInt3 = Convert.ToInt32 (myString);
    
        myFloat3 = float.Parse(myString2);
      
        if (int.TryParse(input, out int tryResult))
        {
            Debug.Log(result);
            result = tryResult;
        }
        else
        {
            Debug.Log("Invalid number format");
        }


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(myFloat1);
        //Debug.Log(myInt1);

        //Debug.Log(myInt2);
        //Debug.Log(myFloat2);

        //Debug.Log(myInt3);
        //Debug.Log(myString);

        //Debug.Log(myFloat3);
    }

}
