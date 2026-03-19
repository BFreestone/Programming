using UnityEngine;

public class ArrayNPCDialogues : MonoBehaviour
{
    string[] lines = new string[3] { "Hello, traveler!", "Be careful out there.", "I heard there's a treasure nearby!" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < lines.Length; i++)
        {
            Debug.Log(lines[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
