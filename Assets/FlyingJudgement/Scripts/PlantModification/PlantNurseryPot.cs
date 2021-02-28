using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantNurseryPot : MonoBehaviour
{
    public bool emptyNurseryPot = true;
    public string seedID;
    // Start is called before the first frame update

    // if on trigger a mouse button up ask spawner if seed is true. if true a 
    //{seed dropped  and the pot is empty I need to mark bool false and store plant information.}
    //If false and pot is full or Item is not seed tell spawner do nothing.
    // it puts back items to its containers.
   public void PotIsFullOrEmpty(bool potstate)
   {
       emptyNurseryPot = potstate;
   }
   
   public void GrowSeed()
   {
       
   }

}
