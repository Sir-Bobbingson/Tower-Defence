using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Agent1 : MonoBehaviour
{
    [SerializeField] private GameObject homeBase;
 
    
    private NavMeshAgent agent;

    
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        if (homeBase)
        {
            agent.SetDestination(homeBase.transform.position);
        }
        
        
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Home")
        {
            //Decrease Health
            //Destroy Enemy GameObject
            Destroy(gameObject);
        }

    }






    // Update is called once per frame
    void Update()
    {
        
           
        
    }  
}
