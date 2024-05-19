using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnMouseDown() // This also works with a touch on touchscreen devices.
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp(); // Calls the ScoreUp function when the ball is clicked
        Destroy(gameObject); // Destroys the ball
    }
}
