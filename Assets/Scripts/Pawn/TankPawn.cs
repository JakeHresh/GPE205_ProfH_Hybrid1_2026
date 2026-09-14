using UnityEngine;

public class TankPawn : Pawn
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
    }

    public override void RotateClockwise()
    {
        Debug.Log("RotateClockwise");
    }

    public override void RotateCounterClockwise()
    {
        Debug.Log("Rotate Counter-Clockwise");
    }
}
