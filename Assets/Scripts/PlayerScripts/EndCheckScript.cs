using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheckScript : MonoBehaviour
{
    int endSpawnCheck = 0;
    // Update is called once per frame
    void Update()
    {
        if(EndBallSlotsScript.ballCount == 7)
        {
            endSpawnCheck += 1;
            Debug.Log("End value increased!");
        }
    }
}
