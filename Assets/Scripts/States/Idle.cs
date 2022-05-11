using UnityEngine;

public class Idle : BaseState
{
    private float _HorizontalInput;
    private MovementSM _MovementSM;

    //Constructor
    public Idle(MovementSM stateMachine) : base("Idle") // Llamamos (:) al constructor de BaseState y le pasamos el nombre de el estado.
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
        _HorizontalInput = Input.GetAxis("Horizontal");
        //_HorizontalInput = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(_HorizontalInput) > Mathf.Epsilon) //Es como decir mayor que 0
        {
            _MovementSM.ChangeState(_MovementSM.m_WalkState); //Usamos la funcion ChangeState que hereda de StateMachine
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }
}
