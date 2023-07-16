using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownManager
{
    public string name;
    public List<string> options;
    public List<Sprite> sprites;
    public int currentIndex;

    public DropdownManager(string name, List<string> options, List<Sprite> sprites)
    {
        this.name = name;
        this.options = options;
        this.sprites = sprites;
        this.currentIndex = 0;
    }


    public void AddAtIndex(string name, Sprite sprite, int index)
    {
        if (index >= 0 && index <= options.Count)
        {
            options.Insert(index, name);
            sprites.Insert(index, sprite);
        }
        else
        {
            Debug.Log("Throwing exception");
            throw new System.IndexOutOfRangeException();
        }
    }
}
