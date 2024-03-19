using UnityEngine;


public class CameraFollow : MonoBehaviour {

  
    public Transform target;

    
    public float smoothSpeed = 0.125f;

    
    public Vector3 offset;

    
    private Vector3 currentVelocity;
    
    void LateUpdate() {

        
        Vector3 desiredPosition = target.position + offset.x * transform.right + offset.y * transform.up - offset.z * target.forward;

        
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothSpeed);

        
        transform.position = smoothedPosition;

        
        transform.LookAt(target);
    }

}