using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfPlantingSpots : MonoBehaviour
{
    [SerializeField]List<GridSnaper> goodSoil;
    // Start is called before the first frame update
    void Start()
    {
        PrintPlantableAreaName();
    }

    private void PrintPlantableAreaName()
    {
        foreach (GridSnaper soil in goodSoil)
        {
            print(soil.name);
            print(soil.transform.position);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
