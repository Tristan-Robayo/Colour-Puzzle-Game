using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PuzzleGame.Puzeel1
{
    public class ColliderScript : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<CubeScript>().enabled = false;
            }
        }
    }
}
