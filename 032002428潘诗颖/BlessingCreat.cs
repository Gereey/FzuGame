using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Blessing", menuName = "Inventory/Blessing", order = 0)]
public class BlessingCreat : ScriptableObject {
    
    public string blessingInfo;//祝福语
    public int id;//祝福语序号
}
