
using UnityEngine;

public class SubmarineHuntingState : SubmarineBaseState
{
    public override void EnterState(SubmarineStateManager submarine) {
        submarine.agent.speed = 5f;
    }
    public override void UpdateState(SubmarineStateManager submarine) {
        Ray areaRay = new Ray(submarine.transform.position, submarine.transform.forward);
        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                var vec = new Vector3(i, 0, j);
                areaRay = new Ray(submarine.transform.position, vec);
                if (Physics.Raycast(areaRay, out RaycastHit hitinfo, submarine.detectionRadius, submarine.lm))
                {
                    submarine.agent.SetDestination(hitinfo.point);
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
    }
    public override void OnCollisionEnter(SubmarineStateManager submarine) { }
}
