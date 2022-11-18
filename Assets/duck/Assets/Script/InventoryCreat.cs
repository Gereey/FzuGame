using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Binventory", menuName = "Inventory/Binventory", order = 0)]
public class InventoryCreat : ScriptableObject {
    
    public List<BlessingCreat> list=new List<BlessingCreat>();
}
