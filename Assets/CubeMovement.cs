using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public History undoManager;

    private void Start()
    {
        undoManager.cubeMovementList.Add(this.transform.position);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            this.transform.position = this.transform.position + Vector3.forward * 25f * Time.deltaTime;
            undoManager.RecordMovement(this.transform.position);
        }
    }
}
