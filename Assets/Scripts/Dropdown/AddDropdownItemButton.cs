using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class AddDropdownItemButton : MonoBehaviour
{
    public TMP_InputField itemNameInput;
    public TMP_InputField itemIndexInput;
    public Sprite itemSprite;
    public DropdownHandler dropdownHandler;

    public void OnAddButtonClick()
    {
        // Get the name of the item to be added
        string itemName = itemNameInput.text;

        // Get the index of the item  to be added
        int itemIndex = Int32.Parse(itemIndexInput.text);

        // Add the new item to the dropdown using the DropdownHandler
        dropdownHandler.manager.AddAtIndex(itemName, itemSprite, itemIndex);

        // Create a new OptionData for the new item
        TMP_Dropdown.OptionData newOptionData = new TMP_Dropdown.OptionData(dropdownHandler.manager.options[itemIndex], dropdownHandler.manager.sprites[itemIndex]);


        // Add the new item to the dropdown UI
        dropdownHandler.dropdown.options.Insert(itemIndex, newOptionData);

        // Update the dropdown UI display
        dropdownHandler.dropdown.RefreshShownValue();
    }
}