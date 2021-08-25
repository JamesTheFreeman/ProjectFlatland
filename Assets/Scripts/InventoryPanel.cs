using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    // Private variables
    private bool invOpen;

    // Public variables
    public GameObject inventoryPanel;

    // Start is called before the first frame update
    void Start()
    {
        invOpen = false;
        inventoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !invOpen)
        {
            Debug.Log("Inv opened");

            invOpen = true;
            inventoryPanel.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.Tab) && invOpen)
        {
            Debug.Log("Inv closed");

            invOpen = false;
            inventoryPanel.SetActive(false);
        }
    }

    // For use with exit button
    public void CloseInv()
    {
        invOpen = false;
        inventoryPanel.SetActive(false);
    }
}
