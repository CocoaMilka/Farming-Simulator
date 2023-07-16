using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListManager
{
    public string name;
    public List<string> options;
    public List<Sprite> sprites;
    public int currentIndex;

    public ListManager(string name, List<string> options, List<Sprite> sprites)
    {
        this.name = name;
        this.options = options;
        this.sprites = sprites;
        this.currentIndex = 0;
    }

    public void AddAtIndex(string name, Sprite sprite, int index)
    {
        // Checks if the index in in range
        if (index >= 0 && index <= options.Count)
        {
            options.Insert(index, name);
            sprites.Insert(index, sprite);

            if (currentIndex > index)
            {
                currentIndex++;
            }
        }
        else
        {
            Debug.Log("Throwing exception");
            throw new System.IndexOutOfRangeException();
        }
    }

    public void RemoveAtIndex(int index)
    {
        if (index >= 0 && index <= options.Count)
        {
            options.RemoveAt(index);
            sprites.RemoveAt(index);

            if (currentIndex > index)
            {
                currentIndex--;
            }
        }
        else
        {
            Debug.Log("Throwing exception");
            throw new System.IndexOutOfRangeException();
        }

    }
}
