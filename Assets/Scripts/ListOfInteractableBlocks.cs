using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfInteractableBlocks : MonoBehaviour
{
    [SerializeField]List<GridSnaper> interactableAreas;
    // Start is called before the first frame update
    void Start()
    {
        PrintPlantableAreaName();
    }

    private void PrintPlantableAreaName()
    {
        foreach (GridSnaper IndividualBlock in interactableAreas)
        {
            print(IndividualBlock.name);
            print(IndividualBlock.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
