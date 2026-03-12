using UnityEngine;

public class HealthRegen : MonoBehaviour
{
    public bool canRegenHealth;
    public float playerHealth = 50f;
    public float healthMax = 100;
    public float healthRechargeAmount = 2f;
    public float rechargeTicks = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (canRegenHealth == false)
        //{
        //    return;
        //}
        //else if (playerHealth == healthMax)
        //{
        //    canRegenHealth = false;
        //    return;
        //}
        //else
        //{
        //    if (rechargeTicks > 0)
        //    {
        //        canRegenHealth = true;
        //        rechargeTicks--;
        //    }
        //    playerHealth = playerHealth + healthRechargeAmount;
        //        if (playerHealth > healthMax)
        //        {
        //            playerHealth = healthMax;
        //        }
        //    else
        //    {
        //        canRegenHealth = false;
        //    }
        //}
        if (playerHealth < healthMax)
        {
            canRegenHealth = true;
        }

        if (!canRegenHealth)
        {
            return;
        }
        else
        {
            if (playerHealth >= healthMax)
            {
                playerHealth = healthMax;
                canRegenHealth = false;
                return;
            }
            else
            {
                playerHealth += healthRechargeAmount * Time.deltaTime;
               // playerHealth = playerHealth + healthRechargeAmount; 

            }
        }


     
    }
}
