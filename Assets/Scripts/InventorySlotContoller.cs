using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotContoller : MonoBehaviour
{
    public Item item;

    private void Start()
    {
        updateInfo();
    }

    public void updateInfo()
    {
        Text displayText = transform.Find("Text").GetComponent<Text>();
        Image displayImage = transform.Find("Image").GetComponent<Image>();

        if (item)
        {
            displayText.text = item.itemName;
            displayImage.sprite = item.icon;
            displayImage.color = Color.white;
        }
        else
        {
            displayText.text = "";
            displayImage.sprite = null;
            displayImage.color = Color.clear;
        }
    }

    public void Use()
    {
        if (item) {
            Debug.Log("Clicked With item");
        } else
        {
            Debug.Log("Clicked Without Item");
        }
    }
}
