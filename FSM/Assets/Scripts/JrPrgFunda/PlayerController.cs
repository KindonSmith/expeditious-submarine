using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody playerRB;
    private float jumpForce = 10f;
    private float gravityModifier = 5.0f;
    public float JumpForce
    {
        get { return jumpForce;  }
        set {; }
    }
    public PlayerBaseState jumpState = new PlayerJumpState();
    public PlayerBaseState idleState = new PlayerIdleState();
    PlayerBaseState currentState;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerRB = GetComponent<Rigidbody>();
        currentState = idleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
