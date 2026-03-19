using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Rendering;

public class PlayerInventory : MonoBehaviour
{
    List<string> items = new List<string>() { "Pickaxe", "Sword", "Torch" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Inventory: " + string.Join(",", items));

        items.Remove("Torch");
        Debug.Log("Torch placed!");

        Debug.Log("Updated Inventory" + string.Join(",", items));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
