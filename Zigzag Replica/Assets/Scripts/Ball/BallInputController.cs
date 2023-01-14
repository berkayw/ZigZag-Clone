using TMPro;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;

    private int scoreValue;
    
    [SerializeField] public TextMeshProUGUI score;
    
    void Start()
    {
        ballDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HandleBallInput();
        HandleScoreText();
    }

    private void HandleBallInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
            scoreValue++;
        }
    }

    private void HandleScoreText()
    {
        score.text = scoreValue.ToString();
    }

    private void ChangeBallDirection()
    {
        if(ballDirection.x == -1) // if ball is going left
        {
            ballDirection = Vector3.forward; // go forward
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
