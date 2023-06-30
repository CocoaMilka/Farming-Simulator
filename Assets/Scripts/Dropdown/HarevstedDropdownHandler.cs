using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HarevstedDropdownHandler : MonoBehaviour
{

    // Called when the harvested dropdown changed :3 like the game
    public void dropdownChanged()
    {
        int val = gameObject.GetComponentInParent<TMP_Dropdown>().value;
        Debug.Log("Harevsted Changed to " + val);
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
