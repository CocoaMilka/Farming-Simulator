using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownHandler : MonoBehaviour
{
    public ListManager manager;
    public TMP_Dropdown dropdown;
    public string dropdownName;
    public List<string> options;
    public List<Sprite> sprites;


    // Called when a dropdown changed owo like the game
    public void dropdownChanged()
    {
        // Set the current tool index in the DropdownManager
        manager.currentIndex = dropdown.value;

        // Get the selected option's index from the dropdown
        int selectedOptionIndex = manager.currentIndex;

        // Get the name of the selected option
        string selectedOptionName = manager.options[selectedOptionIndex];

        // Get the name of the dropdown
        string name = manager.name;

        // Perform any other actions or logic related to the dropdown change

        Debug.Log(name + " option changed: " + selectedOptionName);
    }

    // Start is called before the first frame update
    void Start()
    {
        // parent of DropdownHandler is a TMP_Dropdown object
        dropdown = gameObject.GetComponentInParent<TMP_Dropdown>();

        // clears the default options
        dropdown.ClearOptions();

        manager = new ListManager(dropdownName, options, sprites);

        // adds the elements of options and sprites
        List<TMP_Dropdown.OptionData> optionData = new List<TMP_Dropdown.OptionData>();
        for (int i = 0; i < options.Count; i++)
        {
            optionData.Add(new TMP_Dropdown.OptionData(options[i], sprites[i]));
        }
        dropdown.AddOptions(optionData);
    }
}
