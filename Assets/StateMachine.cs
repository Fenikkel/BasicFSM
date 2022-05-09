using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    BaseState currentState;

    void Start()
    {
        currentState = GetInitialState();

        if (currentState != null) 
        {
            currentState.Enter();
        }
    }


    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateLogic();
        }
    }

    private void LateUpdate()
    {
        if (currentState != null)
        {
            currentState.UpdatePhysics();
        }
    }

    public void ChangeState(BaseState newState) 
    {
        currentState.Exit(); //Salimos del estado actual
        currentState = newState; //Asignamos el nuevo estado
        currentState.Enter(); //Entramos al nuevo estado
    }

    protected virtual BaseState GetInitialState() 
    {
        return null;
    }

    private void OnGUI()
    {
        string content;

        if (currentState != null)
        {
            content = currentState.name;
        }
        else 
        {
            content = "(no current state)";
        }

        GUILayout.Label($"<color='black'><size = 40>{content}</size></color>");
    }
}
