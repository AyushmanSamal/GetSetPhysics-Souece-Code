using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
    // Start is called before the first frame update
    public float throwForce = 100f;
    public GameObject grenadePrefab;
    public Camera playerCam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            throwGrenade();
        }
    }
    void throwGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(playerCam.transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
