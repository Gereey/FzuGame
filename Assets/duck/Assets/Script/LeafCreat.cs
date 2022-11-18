//挂在到荷叶上
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeafCreat : MonoBehaviour
{
    //目标点 private float Targety;
    private float Targety=-7f;
    private LeafManager lm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>=Targety) 
        {
             //Invoke("DestroyLeaf",5);
             return ;
        }
        transform.Translate(Vector3.up*Time.deltaTime);

    }
    // private void DestroyLeaf()
    // {
    //     Destroy(gameObject);
    // }
    public void InitLeaf(float creatY,float creatX,float creathight)
    {
        this.Targety=creathight;
        transform.position=new Vector3(creatX,creatY,transform.position.z);
    }
}