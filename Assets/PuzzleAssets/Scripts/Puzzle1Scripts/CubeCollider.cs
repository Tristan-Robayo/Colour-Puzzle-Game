using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Vector3Extension;

namespace PuzzleGame.Puzeel1
{
    public class CubeCollider : MonoBehaviour
    {

        public bool HasBeenActivated
        {
            get;
            set;
        }

        [SerializeField] private float walkRange;
        [SerializeField] private ParticleSystem particle;
        private MeshRenderer renderer;
        private bool hasBeenActivated;
        private NavMeshAgent agent;

        GameManager manager;

        private void Start()
        {
            renderer = GetComponent<MeshRenderer>();
            manager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
            agent = GetComponent<NavMeshAgent>();
            HasBeenActivated = false;
            hasBeenActivated = HasBeenActivated;
            Move();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(IsSameColour(other))
            {
                Debug.Log("It worked");
                other.GetComponent<CubeScript>().enabled = false;
                HasBeenActivated = true;
                manager.CubeLanded();
                Instantiate(particle, other.transform.position, Quaternion.identity);
                Destroy(other.gameObject);
            }
            else
            {
                other.GetComponent<CubeScript>().enabled = false;
            }
        }

        public bool IsSameColour(Collider other)
        {
            if (renderer.sharedMaterial == other.gameObject.GetComponent<MeshRenderer>().sharedMaterial)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Move()
        {
            Vector3 pos;
            pos = new Vector3().RandomVector3Position(-walkRange, walkRange);
            agent.SetDestination(pos);
        }
    }
}
