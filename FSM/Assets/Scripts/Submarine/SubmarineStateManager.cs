using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SubmarineStateManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public SubmarineBaseState CurrentState;
    SubmarineHuntingState HuntingState = new SubmarineHuntingState();
    SubmarineIdleState IdleState = new SubmarineIdleState();
    public int detectionRadius = 5;
    public LayerMask lm;
    public NavMeshAgent agent;
    public Camera cam;
    void Start()
    {
        CurrentState = IdleState;
        CurrentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentState.UpdateState(this);
    }

    void SwitchState(SubmarineBaseState state)
    {
        CurrentState = state;
        state.EnterState(this);
    }
}
