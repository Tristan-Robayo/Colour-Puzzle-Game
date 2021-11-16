using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlaneScript : MonoBehaviour
{
    public GameObject pOrigin;

    public GameObject rBallOrigin;
    public GameObject oBallOrigin;
    public GameObject yBallOrigin;
    public GameObject gBallOrigin;
    public GameObject bBallOrigin;
    public GameObject iBallOrigin;
    public GameObject vBallOrigin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            other.transform.position = pOrigin.transform.position;
            Debug.Log("Should reset position!");
        }

        if (other.gameObject == GameObject.Find("RedBall"))
        {
            other.transform.position = rBallOrigin.transform.position;           
        }
        if (other.gameObject == GameObject.Find("OrangeBall"))
        {
            other.transform.position = oBallOrigin.transform.position;
        }
        if (other.gameObject == GameObject.Find("YellowBall"))
        {
            other.transform.position = yBallOrigin.transform.position;
        }
        if (other.gameObject == GameObject.Find("GreenBall"))
        {
            other.transform.position = gBallOrigin.transform.position;
        }
        if (other.gameObject == GameObject.Find("BlueBall"))
        {
            other.transform.position = bBallOrigin.transform.position;
        }
        if (other.gameObject == GameObject.Find("IndigoBall"))
        {
            other.transform.position = iBallOrigin.transform.position;
        }
        if (other.gameObject == GameObject.Find("VioletBall"))
        {
            other.transform.position = vBallOrigin.transform.position;
        }
    }
}

