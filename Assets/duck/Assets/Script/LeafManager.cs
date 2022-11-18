//挂载到空物体上吧
//荷叶弄成预制体？？---Leaf
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeafManager : MonoBehaviour
{

    //荷叶预制体
    public GameObject Prefab_leaf;
    private  LeafCreat leaf;
    //生成荷叶的左右范围 private float
    private float left=-4.18f;
    private float right=1.96f;
    //生成荷叶的高度范围 private float
    private float up=-10.2f;
    private float down=-11.2f;
    //生成的高度 下到上 creathight
    private float creathight1=-6.14f;
    private float creathight2=-7.23f;
    //在此范围内随机


    public int num=0;
    // Start is called before the first frame update
     void Awake() {
        
       // Prefab_leaf=Resources.Load<GameObject>("Leaf2");//荷叶名称 
    }
    void Start()
    {  
         //void Invoke(string methodName,float time,float delayTime)  ： 意思是在等待time之后，再调用方法methodName方法，并且每隔delayTime再去调用methodN
         //InvokeRepeating("CreatLeaf",3,3);
    }

    // Update is called once per frame
    void Update()
    {
       if(num<=5)
       {
            Invoke("CreatLeaf",Time.deltaTime*600);
            num++;
       }

    }

    void CreatLeaf()
    {
        leaf=GameObject.Instantiate<GameObject>(Prefab_leaf,Vector3.zero,Quaternion.identity).GetComponent<LeafCreat>();
        //float creatY=Random.Range(范围); 上下
        float creatY=Random.Range(down,up);
        //float creatX=Random.Range(范围); 左右
        float creatX=Random.Range(left,right);
        float creathight=Random.Range(creathight2,creathight1);
        //leaf.InitLeaf(downY,downX,creathight);
        leaf.InitLeaf(creatY,creatX,creathight);


    }
   
}

