using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{

    [SerializeField] private GroundDataTransmitter groundDataTransmitter;

    private void OnCollisionExit(Collision collision) //When ball exits from a ground object
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidBody();
        }
    }
}
