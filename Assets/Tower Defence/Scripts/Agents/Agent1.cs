using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Agent1 : MonoBehaviour
{
    [SerializeField] private GameObject homeBase;

    private Waypoint enemyWaypoint;


    private NavMeshAgent agent;

    
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        //if (homeBase)
        //{
        //    agent.SetDestination(homeBase.transform.position);
        //}
        enemyWaypoint = FindObjectOfType<Waypoint>();

        //agent.SetDestination(enemyWaypoint.Position);

    }

    //// OnTriggerEnter is called when the Collider other enters the trigger
    //private void OnTriggerEnter(Collider collider)
    //{
    //    if(collider.tag == "Home")
    //    {
    //        //Decrease Health
    //        //Destroy Enemy GameObject
    //        Destroy(gameObject);
    //    }

    //}



    // Update is called once per frame                                          
    void Update()
    {

        //if (!agent.pathPending && agent.remainingDistance < 0.1f)
        //{
        //    if (homeBase)
        //    {
        //        agent.SetDestination(homeBase.transform.position);
        //    }

        //}

        if (!agent.pathPending && !agent.hasPath )
        {
            agent.SetDestination(enemyWaypoint.Position);
        }    
            
    }  
}
