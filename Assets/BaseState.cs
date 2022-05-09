using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Para todos los estados.Este no será usado. Solo sera como la plantilla de todos los otros estados que heredaran esta clase.
public class BaseState
{
    public string name;
    protected StateMachine stateMachine; //Protected significa que solo puede ser usado por  BaseState y sus hijos y no de otras clases

    //Contructor
    public BaseState(string name, StateMachine stateMachine) 
    {
        this.name = name;
        this.stateMachine = stateMachine;
    }


    public virtual void Enter() //Virtual significa que la implementación la haran los hijos y no BaseState
    { 
    }

    public virtual void UpdateLogic() 
    { 
    }

    public virtual void UpdatePhysics()
    {
    }

    public virtual void Exit()
    {
    }
}
