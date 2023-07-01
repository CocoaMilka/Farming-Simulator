using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownHandler : MonoBehaviour
{

    // Called when a dropdown changed owo like the game
    public void dropdownChanged()
    {
        // parent of DropdownHandler is a TMP_Dropdown object
        TMP_Dropdown dropdown = gameObject.GetComponentInParent<TMP_Dropdown>();

        // the parent of the TMP_Dropdown objct is a TMP_Text object. This get's the text
        string name = dropdown.GetComponentInParent<TMP_Text>().text;

        // gets the options in the dropdown into a list
        List<TMP_Dropdown.OptionData> options = dropdown.options;

        // gets the value that the dropdown changed to
        int val = dropdown.value;

        // does stuff with the name and option
        Debug.Log(name + " changed to " + options[val].text);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
