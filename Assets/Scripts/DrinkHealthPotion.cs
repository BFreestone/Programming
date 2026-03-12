using UnityEngine;

public class DrinkHealthPotion : MonoBehaviour
{
    public float playerHealth = 100f;
    public float maxHealth = 500f;
    public float healAmount = 75f;
    public int potionCount = 3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (playerHealth == maxHealth)
            {
                Debug.Log("You're at full health!");
                return;
            }
            else if (potionCount == 0)
            {
                Debug.Log("You are out of potions!");
                return;
            }
            else if (maxHealth - playerHealth < healAmount)
            {
                playerHealth = maxHealth;
                potionCount--;
            }
            else
            {
                playerHealth = playerHealth + healAmount;
                potionCount--;
            }
        }
    }
}
