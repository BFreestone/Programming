using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class IOJson : MonoBehaviour
{
    public string filePath = $"{Application.dataPath}/PlayerData.json";
    public PlayerData saveLoadPlayerData;

    void GetDataToSave()
    {
        saveLoadPlayerData = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>().playerData;
    }
    void SaveJsonFile(string path, PlayerData data)
    {
        string dataToSave = JsonUtility.ToJson(data);
        File.WriteAllText(path, dataToSave);
    }
    public void SavePlayer()
    {
        GetDataToSave();
        SaveJsonFile(filePath, saveLoadPlayerData);
    }

    private void Start()
    {
        //SavePlayer();
        LoadPlayer();
    }

    PlayerData LoadData()
    {
        string loadedData = File.ReadAllText(filePath);
        return JsonUtility.FromJson<PlayerData>(loadedData);
    }
    void SendLoadedDataToPlayer()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>().playerData = saveLoadPlayerData;
    }

    public void LoadPlayer()
    {
        saveLoadPlayerData = LoadData();//debug
        SendLoadedDataToPlayer();
    }
}
