using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject blockObject;

    public GameObject cube;
    public GameObject cone;

     private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0)){
            blockObject = cube;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1)){
            blockObject = cone;
        }

        if (Input.GetMouseButtonDown(1))
        {
            BuildBlock(blockObject);
        }
    }
     void BuildBlock(GameObject block)
    {
        if(Physics.Raycast(shootingPoint.position, shootingPoint.forward, out RaycastHit hitInfo))
        {
 
            if(hitInfo.transform.tag == "Block")
            {
                Vector3 spawnPosition = new Vector3(Mathf.RoundToInt(hitInfo.point.x + hitInfo.normal.x/2), Mathf.RoundToInt(hitInfo.point.y + hitInfo.normal.y / 2), Mathf.RoundToInt(hitInfo.point.z + hitInfo.normal.z /2));
                Instantiate(block, spawnPosition, Quaternion.identity);
            }
            else
            {
                Vector3 spawnPosition = new Vector3(Mathf.RoundToInt(hitInfo.point.x), Mathf.RoundToInt(hitInfo.point.y), Mathf.RoundToInt(hitInfo.point.z));
                Instantiate(block, spawnPosition, Quaternion.identity);
            }
        }
    }
}