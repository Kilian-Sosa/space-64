using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipController : MonoBehaviour {
    public bool throttle = false;
    public float pitchPower, rollPower, yawPower, enginePower;
    float activeRoll, activePitch, activeYaw;

    [SerializeField] InputActionReference moveAction;
    [SerializeField] InputActionReference moveActionYaw;
    [SerializeField] InputActionReference accelAction;

    bool firstTime = true;

    void Update() {
        Vector2 moveDirection = moveAction.action.ReadValue<Vector2>();
        Vector2 moveDirectionYaw = moveActionYaw.action.ReadValue<Vector2>();

        bool isButtonPressed = (accelAction.action.ReadValue<float>() == 1);

        if (isButtonPressed && firstTime) {
            firstTime = false;
            throttle = !throttle;
        }

        if (throttle) {
            transform.position += transform.forward * enginePower * Time.deltaTime;
            activePitch = moveDirection.y * pitchPower * Time.deltaTime;
            activeRoll = moveDirection.x * rollPower * Time.deltaTime;
            activeYaw = moveDirectionYaw.x * yawPower * Time.deltaTime;

            transform.Rotate(activePitch * pitchPower * Time.deltaTime, 
                activeYaw * yawPower * Time.deltaTime, 
                -activeRoll * rollPower * Time.deltaTime, 
                Space.Self);

        }
    }
}