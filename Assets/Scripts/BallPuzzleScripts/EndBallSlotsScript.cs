using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBallSlotsScript : MonoBehaviour
{
    public GameObject colouredBall;
    public static int ballCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == colouredBall)
        {
            ballCount += 1;
        }
    }

}
