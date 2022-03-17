using UnityEngine;

public abstract class SharkBaseState
{
    public abstract void EnterState(SubmarineStateManager submarine);
    public abstract void UpdateState(SubmarineStateManager submarine);
    public abstract void OnCollisionEnter(SubmarineStateManager submarine);
}
