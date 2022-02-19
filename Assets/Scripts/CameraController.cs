using UnityEngine;

public class CameraController : MonoBehaviour
{
    public int speed;
    public GameObject player;
    void Update(){
        if(Input.GetKey(KeyCode.W)){
            player.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
        if(Input.GetKey(KeyCode.S)){
                player.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.A)){
                player.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if(Input.GetKey(KeyCode.D)){
                player.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.PageUp)){
                player.transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.PageDown)){
                player.transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    

    }

}
