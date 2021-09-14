using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class History : MonoBehaviour
{
    public List<Vector3> cubeMovementList;
    public Button restoreButton;
    public Transform player;


    private void Awake()
    {
        cubeMovementList = new List<Vector3>();
    }
    public void RestoreButton()
    {
        RestoreMovement(player.transform);
    }

    public void RecordMovement(Vector3 pos)
    {
        cubeMovementList.Add(pos);

        if (cubeMovementList.Count > 0)
        {
            restoreButton.image.color = Color.green;
            restoreButton.interactable = true;
        }
    }

    public Transform RestoreMovement(Transform restore)
    {
        if(cubeMovementList.Count >= 3)
        {
            restore.transform.position = cubeMovementList[cubeMovementList.Count() - 2];
            cubeMovementList.RemoveAt(cubeMovementList.Count() - 2);
        }
        else if(cubeMovementList.Count >= 2)
        {
            restore.transform.position = cubeMovementList[0];
            cubeMovementList.RemoveAt(1);
        }
        else if (cubeMovementList.Count == 1)
        {
            restoreButton.image.color = Color.red;
            restoreButton.interactable = false;
        }
        return restore;
    }
}
