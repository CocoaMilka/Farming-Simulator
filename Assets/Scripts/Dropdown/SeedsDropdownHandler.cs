using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeedsDropdownHandler : MonoBehaviour
{

    // Called when the seeds dropdown changed uwu like the game
    public void dropdownChanged()
    {
        int val = gameObject.GetComponentInParent<TMP_Dropdown>().value;
        Debug.Log("Seeds Changed to " + val);
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
