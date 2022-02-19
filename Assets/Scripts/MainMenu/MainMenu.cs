using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void  CamMode(){
        SceneManager.LoadScene("SampleScene");
    }
    public void  PersonMode(){
        SceneManager.LoadScene("PersonMode");
    }
}
