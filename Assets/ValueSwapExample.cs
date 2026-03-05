using UnityEngine;

public class ValueSwapExample : MonoBehaviour
{
    //variables
    public int value1 = 16;
    public int value2 = 16;
    public int result1;
    public int result2;
    public int result3;
    public int result4;
    public int result5;
    public int result6;
    public int result7;
    public int result8;
    public int x = 73;
    public int y = 18;
    public int inc = 5;
    public int one = 1;

    public int a = 5;
    public int b = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        result1 = value1 + value2;
        result2 = value1 - value2;
        result3 = value1 * value2;
        result4 = value1 / value2;
        result5 = x % y;
        result6 = inc += one;

        a = a + b;
        b = a - b;
        a = a - b;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
