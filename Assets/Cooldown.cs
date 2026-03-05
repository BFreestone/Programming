using UnityEngine;

public class Cooldown : MonoBehaviour
{

    public bool isCoolingDown;
    public float coolDownTimer = 0f;
    public float coolDownDuration = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isCoolingDown == true)
            {
                return;
            }
            else
            {
                Debug.Log("Action is performed");
                coolDownTimer = coolDownDuration;
                isCoolingDown = true;

            }
        }

        if (isCoolingDown == true)
        {
            coolDownTimer -= Time.deltaTime;
            if (coolDownTimer <= 0f)
            {
                coolDownTimer = 0;
                isCoolingDown = false;
            }
        }

    }
}
