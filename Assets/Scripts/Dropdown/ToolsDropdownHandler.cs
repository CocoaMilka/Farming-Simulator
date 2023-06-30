using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToolsDropdownHandler : MonoBehaviour
{

    // Called when the tools dropdown changed owo like the game
    public void dropdownChanged()
    {
        int val = gameObject.GetComponentInParent<TMP_Dropdown>().value;
        Debug.Log("Tools Changed to " + val);
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
