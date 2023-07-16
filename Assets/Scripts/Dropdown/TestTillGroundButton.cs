using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTillGroundButton : MonoBehaviour
{
    public DropdownHandler dropdownHandler;

    public void OnTestTillGroundButtonClicked()
    {
        int currentIndex = dropdownHandler.manager.currentIndex;
        List<string> options = dropdownHandler.manager.options;

        if (options[currentIndex].ToLower().Equals("hoe"))
        {
            Debug.Log("If this was real ground, this would be tilled :3");
        }

    }
}
