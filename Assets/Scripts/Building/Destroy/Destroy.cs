using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject MainObject;
    public GameObject DestryedObject;
    public Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            pos = MainObject.transform.position;
            DestryedObject.transform.position = pos; 
            Instantiate(DestryedObject, pos, transform.rotation);
            Rigidbody desRb = DestryedObject.GetComponent<Rigidbody>();
            desRb.AddForce(DestryedObject.transform.forward * 10f);
            Destroy(gameObject);
        }
    }
}
