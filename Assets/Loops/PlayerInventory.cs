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
        if (Input.GetKeyDown(KeyCode.F))
        {
           
            Debug.Log("Torch placed!");
            items.Remove("torch");
            Debug.Log("Updated Inventory" + )
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
