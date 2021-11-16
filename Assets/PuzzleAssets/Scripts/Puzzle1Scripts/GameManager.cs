using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PuzzleGame.Puzeel1
{
    public class GameManager : MonoBehaviour
    {
        public static bool endCheck = false;
        [SerializeField] private CubeCollider[] cubeColliders;

        [SerializeField] private GameObject cube;
        [SerializeField] private Transform spawnPoint;

        float timer = 1.0f;

        bool hasCompleted;

        private void Update()
        {
            if (hasCompleted) //If has completed is true freeze time and load the main scene
            {
                timer -= Time.deltaTime;
                Debug.Log(timer);
                if(timer < 0)
                {
                    Time.timeScale = 0f;
                    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
                    endCheck = true;
                }

            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                ResetScene();                
            }
        }
        public void CubeLanded() //When the cube has landed see if the CubeCollider script has been activated than set has completed true
        {
            foreach (CubeCollider cc in cubeColliders)
            {
                if (cc.HasBeenActivated)
                {
                    hasCompleted = true;
                }
            }
            SpawnNewCube();
        }


        private void ResetScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void SpawnNewCube()
        {
            Instantiate(cube, spawnPoint.position, Quaternion.identity);
        }

        private void OnGUI()
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 30;

            if (hasCompleted)
            {
                GUI.Label(new Rect(750, 350, 350, 50), "You have completed the puzzle", style); //Creates a new GUI label in the left corner of the screen to tell the player they have completed the puzzle
            }
        }
    }
}
