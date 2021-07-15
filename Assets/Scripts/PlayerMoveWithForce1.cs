using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveWithForce1 : MonoBehaviour
{
    public Rigidbody PhysicBody;
    public float MoveForce = 100000.0f;
    public float TurnSpeed = 20.0f;
    public KeyCode MoveForwardKeyCode = KeyCode.W;
    public KeyCode MoveBackwardKeycode = KeyCode.S;
    public KeyCode TurnRightKeyCode = KeyCode.D;
    public KeyCode TurnLeftKeyCode = KeyCode.A;
    public float maxSpeed;
    public bool Broken = false;
    public ScoreMan ScoreMann;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Broken == false)
        {


            if (Input.GetKey(MoveBackwardKeycode))
            {
                PhysicBody.AddForce(-transform.forward * Time.deltaTime * MoveForce);
                GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, maxSpeed);
                ScoreMann.score -= (Time.deltaTime*2);
            }
            else
            {
                PhysicBody.AddForce(transform.forward * Time.deltaTime * MoveForce);
                GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, maxSpeed);
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
}
