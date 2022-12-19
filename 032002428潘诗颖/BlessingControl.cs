using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlessingControl : MonoBehaviour
{
    public Text text;
    public InventoryCreat blessingInventory;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
        Scene scene=SceneManager.GetActiveScene();
        if(scene.name=="duckScene"){
        num=Random.Range(0,5);
        text.GetComponent<Text>().text="<size=50>"+blessingInventory.list[num].blessingInfo+"</size>";
        text.color=new Color(103 / 255f, 44 / 255f, 44 / 255f, 255 / 255f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
