using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;                                    // target to aim for
        public zomTimeKeeper zomTimeKeeper;

        private GameObject[] tagged;
        private bool spedUp = false;

        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
            tagged = GameObject.FindGameObjectsWithTag("Player");
            target = tagged[0].transform;
            zomTimeKeeper = GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<zomTimeKeeper>();

	        agent.updateRotation = false;
	        agent.updatePosition = true;
            
        }


        private void Update()
        {
            if (target != null)
                agent.SetDestination(target.position);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity, false, false);
            else
                character.Move(Vector3.zero, false, false);

            if(Vector3.Distance(this.transform.position, target.transform.position) < 1.4f)
            {
                UnityEngine.Cursor.visible = true;
                SceneManager.LoadScene("defeat");
            }

            if( 100f > zomTimeKeeper.timeSinceBirth && zomTimeKeeper.timeSinceBirth > 50f )
            {
                Debug.Log("Adding speed 1.3");
                agent.speed = 1.3f;
                agent.angularSpeed = 130f;
            }
            if(150f > zomTimeKeeper.timeSinceBirth && zomTimeKeeper.timeSinceBirth >= 100f)
            {
                Debug.Log("Adding speed 1.5");
                agent.speed = 1.5f;
                agent.angularSpeed = 140f;
            }
            if (200f > zomTimeKeeper.timeSinceBirth && zomTimeKeeper.timeSinceBirth >= 150f)
            {
                Debug.Log("Adding speed 1.7");
                agent.speed = 1.7f;
                agent.angularSpeed = 150f;
            }
            if(zomTimeKeeper.timeSinceBirth >= 230f && zomTimeKeeper.timeSinceBirth < 285f)
            {
                Debug.Log("Adding speed 2.0");
                agent.speed = 2.0f;
                agent.angularSpeed = 175f;
            }
            if(zomTimeKeeper.timeSinceBirth >= 285f)
            {
                Debug.Log("Final speed");
                agent.speed = 2.5f;
                agent.angularSpeed = 200f;
            }
        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
