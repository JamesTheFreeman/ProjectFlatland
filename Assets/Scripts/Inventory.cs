using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static int invSize = 20;
    public static Inventory instance;

    public GameObject player;
    public GameObject inventoryPanel;
    public List<Item> inventory = new List<Item>();

    private void updatePanelSlots()
    {
        int index = 0;
        foreach (Transform child in inventoryPanel.transform)
        {
            InventorySlotContoller slot = child.GetComponent<InventorySlotContoller>();

            if (index < inventory.Count)
            {
                slot.item = inventory[index];
            }else { slot.item = null; }
            slot.updateInfo();
            index++;
        }
    }

    public void Add(Item item)
    {
        if (inventory.Count < invSize)
        {
            inventory.Add(item);
        }
        updatePanelSlots();
    }

    public void Remove(Item item)
    {
        if (inventory.Count < invSize)
        {
            inventory.Remove(item);
        }
        updatePanelSlots();
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        updatePanelSlots();
    }
}
