using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{

    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;

    [SerializeField] private float endYValue;

    private int groundDirection;


    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if(transform.position.y <= endYValue)
        {
            setRigidBodyValues();

            setGroundNewPosition();


        }
    }

    private void setGroundNewPosition()
    {
        groundDirection = Random.Range(0, 2); // 0 and 1
        if (groundDirection == 0) //Left
        {
            transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x - 1f, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z);
        }
        else //Forward
        {
            transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z + 1f);
        }
        groundSpawnController.lastGroundObject = gameObject;
    }

    private void setRigidBodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
