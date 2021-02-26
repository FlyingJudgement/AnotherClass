using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
[SelectionBase]
public class GridSnaper : MonoBehaviour
{
    TextMesh textMesh;
    [Range(0.5f, 10)] [SerializeField] float gridSize;
    Vector3 snapPos;
    void Update()
    {
        SnapPlanesByIncrement();
        WritePositionOnObjectAndName();
    }

    private void SnapPlanesByIncrement()
    {
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.y = Mathf.RoundToInt(transform.position.y / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, snapPos.y, snapPos.z);
    }

    private void WritePositionOnObjectAndName()
    {
        textMesh = GetComponentInChildren<TextMesh>();
        string cordinates =
            (snapPos.x / gridSize + "."
            + snapPos.z / gridSize +
            System.Environment.NewLine + snapPos.y / gridSize);
        textMesh.text = cordinates;
        gameObject.name = cordinates;
    }
}
