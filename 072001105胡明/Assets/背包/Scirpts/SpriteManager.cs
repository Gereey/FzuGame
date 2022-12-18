using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager 
{
    public static Dictionary<Food, Sprite> dict = new Dictionary<Food, Sprite>();
    public static Sprite GetSprite(Food food)
    {
        if (!dict.ContainsKey(food))
        {
            dict.Add(food, Resources.Load<Sprite>("Food/" + food.ToString()));
        }
        return dict[food];
    
    }
}
