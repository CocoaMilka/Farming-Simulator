using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGroundButton : MonoBehaviour
{
    public DropdownHandler seedsDropdownHandler;
    public DropdownHandler toolsDropdownHandler;
    public DropdownHandler harvestedDropdownHandler;
    public UnityEngine.UI.Slider slider;

    public void OnTestGroundButtonClicked()
    {
        int seedsIndex = seedsDropdownHandler.manager.currentIndex;
        List<string> seedsOptions = seedsDropdownHandler.manager.options;

        int toolsIndex = toolsDropdownHandler.manager.currentIndex;
        List<string> toolsOptions = toolsDropdownHandler.manager.options;

        int harvestedIndex = harvestedDropdownHandler.manager.currentIndex;
        List<string> harvestedOptions = harvestedDropdownHandler.manager.options;

        List<List<string>> allLists = new List<List<string>>();
        
        allLists.Add(seedsOptions);
        allLists.Add(toolsOptions);
        allLists.Add(harvestedOptions);

        if (slider.value == 0 && allLists[0][seedsIndex].ToLower().Equals("potato"))
        {
            Debug.Log("If this was real ground and if it was tilled, this would be planted :3");
        }
        if (slider.value == 1 && allLists[1][toolsIndex].ToLower().Equals("hoe"))
        {
            Debug.Log("If this was real ground, this would be tilled :3");
        }
        if (slider.value == 2 && allLists[2][harvestedIndex].ToLower().Equals("plant"))
        {
            Debug.Log("If this was real ground, this wouldn't do much I guess");
        } 
    }
}
