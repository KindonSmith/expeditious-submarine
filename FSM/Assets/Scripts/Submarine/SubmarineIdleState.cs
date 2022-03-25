using UnityEngine;
using System;
using System.Collections;
using UnityEngine.AI;

public class SubmarineIdleState : SubmarineBaseState
{
    public override void EnterState(SubmarineStateManager submarine) {
        submarine.agent.speed = 2f;
    }
    public override void UpdateState(SubmarineStateManager submarine) {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = submarine.cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                submarine.agent.SetDestination(hit.point);
            }
        }

    }
    public override void OnCollisionEnter(SubmarineStateManager submarine) { }

}
