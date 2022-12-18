using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    Food mType;
    bool inited = false;

    public Action<Item> onClick;
    public Food type { 
        get { return mType; } 
        set {
            if (!inited)
            {
                inited = true;
                Init();
            }
            mType = value;
            image.sprite = SpriteManager. GetSprite(mType);
        }
    }

    public void Bind(Action<Item> onclip)
    {
        if (!inited)
        {
            inited = true;
            Init();
        }
        onClick =onclip;
    }
    public int amount;
    Image image;
    Button button;
    Image selected;
    // Start is called before the first frame update
    void Init()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        selected=transform .Find("Selected").GetComponent<Image>();
        selected.gameObject.SetActive(false);
    }

    public void UnSelected()
    {
        selected.gameObject.SetActive(false);
    }
    public void OnClick()
    {
        onClick?.Invoke(this);
        selected.gameObject.SetActive(true);
    }
   
}
