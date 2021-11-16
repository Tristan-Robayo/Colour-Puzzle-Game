using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSlotScript : MonoBehaviour
{
    public GameObject colouredBall;
    public GameObject spawnGroup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == colouredBall)
        {
            spawnGroup.SetActive(true);
        }
    }
}