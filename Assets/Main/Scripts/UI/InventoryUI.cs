﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public GameObject itemButton;
    public GameObject inventoryContent;
    public PlayerManager pm;
    TextMeshPro infoTest;
    
    
    
    
    void Start()
    {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        int count = 0;
        foreach (InventorySlot square in inventoryContent.GetComponentsInChildren<InventorySlot>())
        {
            square.InitalizeSelf(count, pm);
            count++;
        }
    }

    public void UpdateAllSquares()
    {
        foreach (InventorySlot square in inventoryContent.GetComponentsInChildren<InventorySlot>())
        {
            square.UpdateSelf(pm);
        }
    }
}
