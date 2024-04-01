using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        transform.Rotate(Vector3.up * 0.5f);
    }
}
