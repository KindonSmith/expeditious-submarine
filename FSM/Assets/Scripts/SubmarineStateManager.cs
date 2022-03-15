using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineStateManager : MonoBehaviour
{
    // Start is called before the first frame update

    SubmarineBaseState CurrentState;
    SubmarineHuntingState HuntingState = new SubmarineHuntingState();
    SubmarineIdleState IdleState = new SubmarineIdleState();

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
