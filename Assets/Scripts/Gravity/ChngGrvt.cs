using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChngGrvt : MonoBehaviour
{
    public void Mars()
    {
        Physics.gravity = new Vector3(0f, -3.7278f, 0f);
    }
    public void No()
    {
        Physics.gravity = new Vector3(0f, 0f, 0f);
    }
    public void Moon()
    {
        Physics.gravity = new Vector3(0f, -1.6635f, 0f);
    }
    public void Earth()
    {
        Physics.gravity = new Vector3(0f, -9.81f, 0f);
    }
}
