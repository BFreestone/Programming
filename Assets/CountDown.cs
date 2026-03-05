using UnityEngine;

public class CountDown : MonoBehaviour
{
    public bool countDown = true;
    public float timer = 10f;
    public float waitTime = 1.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (timer == 0)
        //{
        //   return;
        //}
        //else if (timer > 0)
        //{
        //   timer -= Time.deltaTime;
        //}
        //else
        //{
        //   timer = 0;
        //}

        if (timer == 0)
        {
            return;
        }
        else 
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
            }
        }
       
    }
}
