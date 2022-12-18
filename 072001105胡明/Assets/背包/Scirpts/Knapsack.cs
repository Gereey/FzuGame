using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knapsack : MonoBehaviour
{
    Slot[] slots;
    public List<Item> items= new List<Item>();
    Item selected;
    public Text tip;
    // Start is called before the first frame update
    void Start()
    {
        slots = GetComponentsInChildren<Slot>();
        tip.gameObject.SetActive(false);
    }

    public void PlaceItem(int foodId)
    {
        //已存在
        if (items.Find((a) => { return a.type == (Food)foodId; }))
        {
            return;
        }
        var slot = FindNullSlot();
        if (slot != null)
        {
            Item it = slot.Place((Food)foodId);
            it.Bind(OnSelected);
            items.Add(it);

        }

    }
    public void PlaceItem(Food food)
    {
        //已存在
        if (items.Find((a) => { return a.type == food; }))
        {
            return;
        }
        var slot = FindNullSlot();
        if (slot != null)
        {
            Item it = slot.Place(food);
            it.Bind(OnSelected);
            items.Add(it);
           
        }

    }

    public void UseItem()
    {
        Food food = selected.type;
        items.Remove(selected);
        Destroy(selected.gameObject);
        tip.gameObject.SetActive(false);
        selected = null;
        tip.text = "";
        switch (food)
        { 
            case Food.Cake:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
            case Food.Drinks:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
            case Food.Hamburger:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
            case Food.IceCream:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
            case Food.Milk:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
            case Food.Pizza:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
            case Food.Tea:
                Debug.Log(food.ToString() + "  效果 " + (int)food);
                break;
        }

    }
    public void OnSelected(Item item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].UnSelected();
        }
        selected = item;
        tip.gameObject.SetActive(true);
        tip.text = TextInfo.texts[(int)item.type];
    }
    Slot FindNullSlot()
    {
        foreach (Slot slot in slots)
        {
            if (slot.transform.childCount == 0)
                return slot;
        }
        return null;
    }
}
