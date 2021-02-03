using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]

public class GridSnaper : MonoBehaviour
{
    Vector3 snapPos;
    void Update()
    {
        snapPos.x = Mathf.RoundToInt(transform.position.x / 10)*10f;
        snapPos.y = 0;
        snapPos.z = Mathf.RoundToInt(transform.position.y / 10)*10f;

        transform.position = new Vector3(snapPos.x, snapPos.y, snapPos.z);

    }
}
