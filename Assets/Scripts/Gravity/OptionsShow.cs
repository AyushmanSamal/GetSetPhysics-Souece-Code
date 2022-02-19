using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsShow : MonoBehaviour
{
    public GameObject opts;
    public GameObject opt;
    public GameObject player;
    public GameObject MenuCam;
    public bool shown = false;
    public bool optShow = false;

    // Update is called once per frame
    void Update()
    {
        if (shown == false)
        {
            opts.SetActive(false);
            opt.SetActive(false);
            MenuCam.SetActive(false);
        }
        if (Input.GetKey(KeyCode.L) && shown == false)
        {
            opts.SetActive(true);
            player.SetActive(false);
            MenuCam.SetActive(true);
            opt.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            shown = true;
        }
        if (Input.GetKey(KeyCode.K) && shown == true)
        {
            opts.SetActive(false);
            player.SetActive(true);
            MenuCam.SetActive(false);
            opt.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            shown = false;
        }

    }
    public void Show()
    {
        if(optShow == false)
        {
            optShow = true;
            opt.SetActive(true);
        }
        else if(optShow == true)
        {
            optShow = false;
            opt.SetActive(false);
        }
    }
}
