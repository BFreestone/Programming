using UnityEngine;

public class LevelAndExp : MonoBehaviour
{
    public int playerExp;
    public int playerLevel = 0;
    public int expGain = 100;
    public int maxLevel = 50;
    public int levelUpAmount = 1000;
    public int levelUpIncrement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelUpIncrement = (int)(levelUpAmount * 1.5f);

    }    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerExp += expGain;

            if (playerLevel == maxLevel)
            {
                return;
            }
            else if (playerExp >= levelUpAmount)
            {
                playerExp -= levelUpAmount;
                playerLevel++;
                levelUpAmount += levelUpIncrement;
                if (playerLevel == maxLevel)
                {
                    playerExp = 0;
                }
            }
        }
    }
}
