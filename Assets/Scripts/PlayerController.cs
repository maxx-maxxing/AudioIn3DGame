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
        float x = Input.GetAxis("Mouse X") * lookSensitivity;
        float y = Input.GetAxis("Mouse Y") * lookSensitivity;

        transform.eulerAngles += Vector3.up * x; // rotates player around y axis
    }
}
