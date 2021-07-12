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
    public KeyCode ShiftUp = KeyCode.LeftShift;
    public KeyCode ShiftDown = KeyCode.LeftControl;
    public float sprintSpeed;
    public float maxSpeed;
    float sprint = 0.0f;
    public int sprintadd;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(ShiftUp))
        {
            sprintSpeed = sprintSpeed + sprintadd;
        }
        else if (Input.GetKeyDown(ShiftDown))
        {
            sprintSpeed = sprintSpeed - sprintadd;
        }
        if (Input.GetKey(MoveForwardKeyCode) && sprintSpeed <= 300)
        {
            PhysicBody.AddForce(transform.forward * Time.deltaTime * MoveForce);
            GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, maxSpeed + sprintSpeed);
            Debug.Log("Text: " + maxSpeed + sprintSpeed);
        }
        else if (Input.GetKey(MoveBackwardKeycode) && sprintSpeed >= 0)
        {
            PhysicBody.AddForce(-transform.forward * Time.deltaTime * MoveForce);
            GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, maxSpeed + sprintSpeed);
            Debug.Log("Text: " + maxSpeed + sprintSpeed);
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
