using Unity.VisualScripting;
using UnityEngine;

public class StaminaAndSprinting : MonoBehaviour
{
    public bool sprinting = true;
    public float stamina = 50f;
    public float staminaMax = 100f;
    public float staminaDrain = 2f;
    public float staminaRecharge = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (stamina == 0)
            {
                sprinting = false;
                return;
            }
            else
            {
                stamina = stamina - staminaDrain;
                sprinting = true;

                if (stamina < 0)
                {
                    stamina = 0;
                }

            }

        }
        else
        {
            if (stamina < staminaMax)
            {
                stamina = stamina + staminaRecharge;
                if (stamina > staminaMax)
                {
                    stamina = staminaMax;
                }
            }
        }


    }
}
