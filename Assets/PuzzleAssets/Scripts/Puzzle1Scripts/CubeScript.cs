using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PuzzleGame.Puzeel1
{
    public class CubeScript : MonoBehaviour
    {
        [SerializeField] private float speed = 15f;
        [SerializeField] private Material[] materials;
        private MeshRenderer renderer;
    

        private void Start()
        {
            renderer = GetComponent<MeshRenderer>();

            renderer.material = SetRandomMaterial(); //Sets a random material to the renderer
        }

        private Material SetRandomMaterial() // returns random material
        {
            Material mat = materials[Random.Range(0, materials.Length)];
            return mat;
        }

        private void Update()
        {
            PlayerMovement();
        }

        private void PlayerMovement()
        {
            Vector3 pos = transform.position;

            if (Input.GetKey(KeyCode.A))
            {
                pos.z -= speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                pos.z += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                pos.x -= speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                pos.x += speed * Time.deltaTime;
            }

            transform.position = pos;
        }
    }
}
