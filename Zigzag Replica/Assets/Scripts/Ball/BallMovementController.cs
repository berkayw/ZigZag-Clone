using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovementController : MonoBehaviour
{

    [SerializeField] private BallDataTransmitter ballDataTransmitter;

    [SerializeField] private float ballMoveSpeed;

    [SerializeField ] private float checkBallSpeedPoint = 10f;
    
    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += ballDataTransmitter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
        IncreaseBallSpeed();
        if (transform.position.y < -6)
        {
            restartGame();
        }
    }

    private void IncreaseBallSpeed()
    {
        if (transform.position.x < -checkBallSpeedPoint || transform.position.z > checkBallSpeedPoint)
        {
            ballMoveSpeed+= 0.3f;
            checkBallSpeedPoint += 10;
        }
    }

    private void restartGame()
    {
        SceneManager.LoadScene(0);
        
    }
}
