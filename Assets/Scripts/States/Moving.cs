using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : BaseState
{
    private float _HorizontalInput;

    //Constructor
    public Moving(MovementSM stateMachine) : base("Moving", stateMachine) 
    {
        // Pasamos al contructor "Idle" una variable de tipo "MovementSM" 
        // Llamamos (:) al constructor de BaseState y le pasamos el nombre de el estado y la variable tipo "MovementSM". Se la traga porque "MovementSM" hereda de StateMachine
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

        //Transition to "idle" if input == 0
        if (Mathf.Abs(_HorizontalInput) < Mathf.Epsilon) //Es como decir menor que 0
        {
            currentStateMachine.ChangeState(((MovementSM)currentStateMachine).idleState); //Cambiamos de estado Idle -> Moving
        }
    }
}
