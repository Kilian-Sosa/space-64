using System;
using UnityEngine;

public class HUDActions : MonoBehaviour {

    public void Restart() {
        SceneController.instance.LoadScene("GameScene");
    }

    public void GotToMenu() {
        SceneController.instance.LoadScene("MenuScene");
    }
}
