using UnityEngine;

public class TankMover : Mover
{
    // Variable to hold the Rigidbody Component
    private Rigidbody rb;

    // Variable to hold the Transform Component
    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();

        tf = GetComponent<Transform>();
    }

    public override void Move(Vector3 direction, float speed)
    {
        Vector3 moveVector = direction * speed * Time.deltaTime;
        
        if (rb != null)
        {
            rb.MovePosition(rb.position + moveVector);
        }
    }

    public override void Rotate(float turnSpeed)
    {
        tf.Rotate(0, turnSpeed * Time.deltaTime, 0);
    }
}
