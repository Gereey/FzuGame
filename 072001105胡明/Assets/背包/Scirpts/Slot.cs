using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Item item;
    // Start is called before the first frame update
   

    public Item Place(Food food)
    {
        Item it= GameObject.Instantiate(item,transform .position ,transform .rotation);
        it.transform.SetParent(transform );
        it.transform.localScale = Vector3.one;
        it.type = food;
        return it;
    }
    public void UnPlace()
    {
        if(transform.GetChild(0))
        Destroy(transform.GetChild(0));
    
    }
}
