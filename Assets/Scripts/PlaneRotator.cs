using UnityEngine;

public class PlaneRotator : MonoBehaviour
{
    public Vector3 axis;
    public float speed;

    void Update ()
    {
        transform.Rotate(axis, speed * Time.deltaTime);
    }
}
