using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovementController : MonoBehaviour
{

    [SerializeField] private BallDataTransmitter ballDataTransmitter;

    [SerializeField] private float ballMoveSpeed;
    

    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += ballDataTransmitter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
        restartGame();
    }


    private void restartGame()
    {
        if (transform.position.y < -6)
        {
            SceneManager.LoadScene(0);
        }
    }
}
