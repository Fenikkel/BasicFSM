using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [HideInInspector]
    public Idle idleState;

    [HideInInspector]
    public Moving movingState;

    private void Awake()
    {
        //Initialize the states
        idleState = new Idle(this); // le pasamos a su constructor esta clase "MovementSM"
        movingState = new Moving(this);
    }

    protected override BaseState GetInitialState() //Cogemos el estado en que empezamos
    {
        return idleState;
    }

}
