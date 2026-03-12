using UnityEngine;

public class VariableExample : MonoBehaviour
{
    //Variable
    public int integer = 5;

    // [SerializeField] makes private visable to inspecter
    [SerializeField] private int _secret = 7;
    public float floaty = 1.33f;
    public string character = "Bob";
    public bool taskComplete = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug
        Debug.Log("Int "+integer);
        Debug.Log("Secret "+_secret);
        Debug.Log("Float "+floaty);
        Debug.Log("String "+character);
        Debug.Log("Bool "+taskComplete);
        Debug.Log("int/priv " + (integer / _secret));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
