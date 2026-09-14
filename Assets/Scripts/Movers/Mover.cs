using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public abstract void Start();

    public abstract void Move(Vector3 direction, float speed);

    public abstract void Rotate(float turnSpeed);
}
