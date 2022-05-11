using UnityEngine;

public class MovementSM : StateMachine
{
    [HideInInspector]
    public Idle m_IdleState;

    [HideInInspector]
    public Walk m_WalkState;

    /* Custom variables here */
    public Rigidbody m_RigidBody;
    public float m_Speed = 4.0f;

    private void Awake()
    {
        //Initialize the states
        m_IdleState = new Idle(this); // this = referencia de este script "MovementSM"
        m_WalkState = new Walk(this);
    }

    protected override BaseState GetInitialState() //Cogemos el estado en que empezamos
    {
        return m_IdleState;
    }

}
