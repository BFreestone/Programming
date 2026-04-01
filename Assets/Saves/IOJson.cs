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

    public void SavePlayer(string path)
    {
        GetDataToSave();
        SaveJsonFile(path, saveLoadPlayerData);
    }

    PlayerData LoadData(string path)
    {
        string loadedData = File.ReadAllText(path);
        return JsonUtility.FromJson<PlayerData>(loadedData);
    }

    void SendLoadedDataToPlayer()
    {
        PlayerHandler handler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>();
        handler.playerData = saveLoadPlayerData;
        handler.ApplyPlayerData();
    }

    public void LoadPlayer(string path)
    {
        saveLoadPlayerData = LoadData(path);
        SendLoadedDataToPlayer();
    }

    string GetSlotPath(int slot)
    {
        return $"{Application.dataPath}/PlayerData{slot}.json";
    }
    public void Save1()
    {
        SavePlayer(GetSlotPath(1));
    }

    public void Save2()
    {
        SavePlayer(GetSlotPath(2));
    }

    public void Save3()
    {
        SavePlayer(GetSlotPath(3));
    }

    public void Load1()
    {
        LoadPlayer(GetSlotPath(1));
    }

    public void Load2()
    {
        LoadPlayer(GetSlotPath(2));
    }

    public void Load3()
    {
        LoadPlayer(GetSlotPath(3));
    }

    //public void SavePlayer()
    //{
    //    GetDataToSave();
    //    SaveJsonFile(filePath, saveLoadPlayerData);
    //}

    //PlayerData LoadData()
    //{
    //    string loadedData = File.ReadAllText(filePath);
    //    return JsonUtility.FromJson<PlayerData>(loadedData);
    //}

    //void SendLoadedDataToPlayer()
    //{
    //    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>().playerData = saveLoadPlayerData;

    //}
    

    //public void LoadPlayer()
    //{
    //    saveLoadPlayerData = LoadData();//debug
    //    SendLoadedDataToPlayer();
    //}
}
