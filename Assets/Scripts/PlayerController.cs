using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController controller; // Controls the Character Controller component of Player GO

    public Transform cam; // Controls x,y,z of camera while looking around
    public float lookSensitivity; // tbd
    public float minXRotation; // tbd
    public float maxXRotation; // tbd
    private float currXRotation; // tbd

    void Update()
    {
        Move();
        Look();
    }

    void Move()
    {
        
    }
    
    void Look()
    {
        float x = Input.GetAxis("Mouse X") * lookSensitivity; // Amount cam moved right/left, times lookSens
        float y = Input.GetAxis("Mouse Y") * lookSensitivity; // Amount cam moved up/down, times lookSens

        transform.eulerAngles += Vector3.up * x; // Rotate the Player object around the Y-axis by x degrees this frame
        currXRotation += y; // Keeps track of net vertical movement around x-axis
        currXRotation = Mathf.Clamp(currXRotation, minXRotation, maxXRotation); 
        // ^^ Sets a limit on looking up/down so you cant "break neck"
        
        
        cam.localEulerAngles = new Vector3(-currXRotation, 0.0f, 0.0f);
        // ^^ Rotate around cameras x-axis, not the worlds.
        // left/right => rotate around parent's y (transform.eulerAngles += Vector3.up * x)
        // up/down => rotate around camera's (child) x with a new vector
    }
}
