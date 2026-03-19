using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        while (i<=5)
        {
            Debug.Log(i);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
