using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggController : MonoBehaviour
{

    public void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            SceneController.instance.LoadScene("GameScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EasterText"))
        {
            SceneController.instance.LoadScene("GameScene");
        }
    }
}
