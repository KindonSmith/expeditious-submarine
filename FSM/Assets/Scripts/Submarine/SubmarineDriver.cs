using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SubmarineDriver : MonoBehaviour
{

    public float detectionRadius = 10f;
    [SerializeField] LayerMask lm;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Camera cam;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {

        Ray areaRay = new Ray(transform.position, transform.forward);
        for(int i = -1; i < 2; i++)
        {
            for(int j = -1; j < 2; j++)
            {
                var vec = new Vector3(i, 0, j);
                areaRay = new Ray(transform.position, vec);
                if (Physics.Raycast(areaRay, out RaycastHit hitinfo, detectionRadius, lm))
                {
                    agent.SetDestination(hitinfo.point);
                    /*
                    Debug.DrawRay(transform.position, vec * hitinfo.distance, Color.green);
                    Debug.Log("Hit");*/

                }
                else
                {
                    /*
                    Debug.DrawRay(transform.position, vec * 20f, Color.red);
                    */
                }
            }
        }
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }*/
    }
}
