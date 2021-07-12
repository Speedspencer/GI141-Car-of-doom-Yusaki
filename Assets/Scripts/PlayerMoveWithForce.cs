using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveWithForce : MonoBehaviour
{
    public Rigidbody PhysicBody;
    public float MoveForce = 100000.0f;
    public float TurnSpeed = 20.0f;
    public KeyCode MoveForwardKeyCode = KeyCode.W;
    public KeyCode MoveBackwardKeycode = KeyCode.S;
    public KeyCode TurnRightKeyCode = KeyCode.D;
    public KeyCode TurnLeftKeyCode = KeyCode.A;
    public float MaxSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveForwardKeyCode))
        {
            PhysicBody.AddForce(transform.forward * (MaxSpeed / Time.deltaTime) * MoveForce);
        }
        else if (Input.GetKey(MoveBackwardKeycode))
        {
            PhysicBody.AddForce(-transform.forward * (MaxSpeed / Time.deltaTime) * MoveForce);
        }

        if (Input.GetKey(TurnRightKeyCode))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed);
        }
        else if (Input.GetKey(TurnLeftKeyCode))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * -TurnSpeed);
        }
    }
}
