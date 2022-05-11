using UnityEngine;

public class Walk : BaseState
{
    private float _HorizontalInput; 
    private MovementSM _MovementSM;

    //Constructor
    public Walk(MovementSM stateMachine) : base("Walk") // Llamamos (:) al constructor de BaseState y le pasamos el nombre de el estado
    {
        _MovementSM = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        _HorizontalInput = 0.0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        _HorizontalInput = Input.GetAxis("Horizontal"); //from 0.0f to 1.0f
        //_HorizontalInput = Input.GetAxisRaw("Horizontal"); //0.0f or 1.0f

        if (Mathf.Abs(_HorizontalInput) < Mathf.Epsilon) //Es como decir menor que 0
        {
            _MovementSM.ChangeState(_MovementSM.m_IdleState); //Usamos la funcion ChangeState que hereda de StateMachine
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();

        Vector3 newVel = _MovementSM.m_RigidBody.velocity;
        newVel.x = _HorizontalInput * _MovementSM.m_Speed;
        _MovementSM.m_RigidBody.velocity = newVel;

    }
}
