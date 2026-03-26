using UnityEngine;
using System.IO;

public class IOText : MonoBehaviour
{

    string filePath;
    public PlayerData data;

    [Header("Split")]
    public string[] splitData;
    public string[] posSplit;
    public string[] rotSplit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        filePath = $"{Application.dataPath}/log.txt";

       // SaveSetUp();
        SplitData(ReadTextFile());
    }

    void SaveSetUp()
    {
        data = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>().playerData;
        //make a string
        string dataToSave = $"{data.characterName}|{data.characterHealth}|{data.level}|{data.playerPosition}|{data.playerRotation}";
        //save the data
        WriteTextFile(dataToSave);
    }

    void WriteTextFile(string content)
    {
        File.WriteAllText(filePath, content);
    }
    string ReadTextFile()
    {
        return File.ReadAllText(filePath);
    }
    void SplitData(string content)
    {
        splitData = content.Split('|');
        data.characterName = splitData[0];
        data.characterHealth = float.Parse(splitData[1]);
        data.level = int.Parse(splitData[2]);
        posSplit = splitData[3].Split(',');
        for (int i = 0; i < posSplit.Length; i++)
        {
            posSplit[i] = posSplit[i].TrimStart('(', ' ');
            posSplit[i] = posSplit[i].TrimEnd(')', ' ');
        }
        data.playerPosition = new Vector3(float.Parse(posSplit[0]), float.Parse(posSplit[1]), float.Parse(posSplit[2]));
        rotSplit = splitData[4].Split(',');
        for (int i = 0; i < rotSplit.Length; i++)
        {
            rotSplit[i] = rotSplit[i].TrimStart('(', ' ');
            rotSplit[i] = rotSplit[i].TrimEnd(')', ' ');
        }
        data.playerRotation = new Vector3(float.Parse(rotSplit[0]), float.Parse(rotSplit[1]), float.Parse(rotSplit[2]));

        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>().playerData = data;
    }
}


//public string loadedText;

//WriteTextFile("Adventurer |100|5|25|1|62|0|90|0|");
//loadedText = ReadTextFile();