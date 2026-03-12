using UnityEngine;

public class ForEachLoopItemCollection : MonoBehaviour
{
    private object fruit;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
             Debug.Log(fruit);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
