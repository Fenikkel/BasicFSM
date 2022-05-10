using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : BaseState
{
    private float _HorizontalInput;

    //Constructor
    public Idle(MovementSM stateMachine) : base("Idle", stateMachine) 
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

        //Transition to "Movement" if input != 0
        if (Mathf.Abs(_HorizontalInput) > Mathf.Epsilon) //Es como decir mayor que 0
        {
            /*
             - currentStateMachine lo tenemos gracias a lo que heredamos de BaseState
             - currentStateMachine es tipo StateMachine, con lo que tenemos que castearlo a MovementSM 
             (que es la state machine que usa este estado) para poder tener la variable "movingState" 
            */



            /*** Metodo 1 ***/
            //currentStateMachine.ChangeState(((MovementSM) currentStateMachine).movingState); //Cambiamos de estado Idle -> Moving

            /*** Metodo 2 ***/
            MovementSM movSM = (MovementSM)currentStateMachine;
            currentStateMachine.ChangeState(movSM.movingState); //Cambiamos de estado Idle -> Moving
        }
    }
}
