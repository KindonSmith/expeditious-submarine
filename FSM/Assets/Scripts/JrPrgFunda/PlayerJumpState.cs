
using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        player.playerRB.AddForce(Vector3.up * player.JumpForce, ForceMode.Impulse);
    }
    public override void UpdateState(PlayerController player)
    {

    }
    public override void OnCollisionEnter(PlayerController player, Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            player.SwitchState(player.idleState);
        }
    }
}
