using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkStateManager : MonoBehaviour
{
    SharkBaseState CurrentState;
    // Start is called before the first frame update
    void Start()
    {
        /*
        CurrentState = HuntingState;
        CurrentState.EnterState(this);*/
    }

    // Update is called once per frame
    void Update()
    {
        // CurrentState.UpdateState(this);
    }

    void SwitchState(SubmarineBaseState state)
    {
        //CurrentState = state;
        //state.EnterState(this);
    }
}
