using JetBrains.Annotations;
using System;
using UnityEngine;

[Serializable]

public class PlayerData
{
    public string characterName;
    public float characterHealth;
    public int level;
    public Vector3 playerPosition;
    public Vector3 playerRotation;

}

//[Serializable]
//public class Inventory
//{
//    public Item[] items;
//    public int gold;
//}

//[Serializable]
//public class SaveAndLoadPlayer
//{
//    public playerData
//}

//[Serializable]
//public class Item
//{
//    public string name, description;
//    public int cost;
//}