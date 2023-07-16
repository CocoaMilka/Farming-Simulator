using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownHandler : MonoBehaviour
{
    private DropdownManager manager;
    private TMP_Dropdown dropdown;
    public string dropdownName;
    public List<string> options;
    public List<Sprite> sprites;


    // Called when a dropdown changed owo like the game
    public void dropdownChanged()
    {
        // Get the selected option's index from the dropdown
        int selectedOptionIndex = dropdown.value;

        // Get the name of the selected option
        string selectedOptionName = dropdown.options[selectedOptionIndex].text;

        // Get the name of the dropdown
        string name = manager.name;

        // Set the current tool index in the DropdownManager
        manager.currentIndex = selectedOptionIndex;

        // Perform any other actions or logic related to the dropdown change

        Debug.Log(name + " option changed: " + selectedOptionName);
    }

    // Start is called before the first frame update
    void Start()
    {
        // parent of DropdownHandler is a TMP_Dropdown object
        dropdown = gameObject.GetComponentInParent<TMP_Dropdown>();

        manager = new DropdownManager(dropdownName,options, sprites);
        dropdown.AddOptions(options);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
