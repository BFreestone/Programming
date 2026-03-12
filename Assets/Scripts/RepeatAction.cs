using System.Threading;
using UnityEngine;

public class RepeatAction : MonoBehaviour
{
    public float timer = 0f;
    public float timeLimit = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer >= timeLimit)
        {
            Debug.Log("Action can be performed!");
            timer = 0f;
        }
    }
}
