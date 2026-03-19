using UnityEngine;
using System.Collections.Generic;

public class PlayerStatsDictionary : MonoBehaviour
{

    Dictionary<string, int> playerStats = new Dictionary<string, int>()
    {
        { "Health", 100 },
        { "Mana", 50 },
        { "Attack Power", 20 }
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (KeyValuePair<string, int> stat in playerStats)
        {
            Debug.Log(stat.Key + ": " + stat.Value);
        }

        playerStats["Health"] -= 20;

        Debug.Log("Player took damage! New Health: " + playerStats["Health"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
