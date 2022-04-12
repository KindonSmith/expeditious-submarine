using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {

    }
    public override void UpdateState(PlayerController player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SwitchState(player.jumpState);
        }
    }
    public override void OnCollisionEnter(PlayerController player, Collision collision)
    {

    }
}
