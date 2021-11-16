using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PuzzleGame.Puzeel1;
using UnityEngine.SceneManagement;

public class EndCheckScript : MonoBehaviour
{
    [SerializeField] private GameObject wall1, wall2;

    bool endSpawnCheckA = false;
    bool endSpawnCheckB = false;
    // Update is called once per frame
    void Update()
    {
        if(EndBallSlotsScript.ballCount == 7)
        {
            endSpawnCheckA = true;
            wall1.SetActive(false);
            Debug.Log("Change boolian!");
        }

        if(GameManager.endCheck == true)
        {
            endSpawnCheckB = true;
            wall2.SetActive(false);
            Debug.Log("Change bool!");
        }

        //if (endSpawnCheckA == true && endSpawnCheckB == true)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        //}
    }
}
