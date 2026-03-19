using System.Runtime.CompilerServices;
using UnityEngine;

public class DoWhileLoopRandomNumber : MonoBehaviour
{
    private int j;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        
        do
        {
            j = Random.Range(1, 6);
            Debug.Log(j);
        }
        while (i != j);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
