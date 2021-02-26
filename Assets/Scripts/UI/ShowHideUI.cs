using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryExample.UI
{
    public class ShowHideUI : MonoBehaviour
    {
        [SerializeField] KeyCode inventoryKey = KeyCode.Escape;
        //[SerializeField] KeyCode characterKey = KeyCode.Escape;
       // [SerializeField] KeyCode readPanelKey = KeyCode.Escape;

        [SerializeField] GameObject uiContainer = null;

        // Start is called before the first frame update
        void Start()
        {
            uiContainer.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(inventoryKey))
            {
                //toDo Get child component Inventory
                uiContainer.SetActive(!uiContainer.activeSelf);
            }
           /* if (Input.GetKeyDown(characterKey))
            {
                //toDo Get child component character
                uiContainer.SetActive(!uiContainer.activeSelf);
            }
            if (Input.GetKeyDown(readPanelKey))
            {
                // toDo Get component ReadPanel
                uiContainer.SetActive(!uiContainer.activeSelf);
            }
            else return;*/
        }
    }
}