//Plantilla para crear estados. Estos heredaran esta clase.
public class BaseState
{
    public string m_StateName;

    //Contructor
    public BaseState(string name)
    {
        m_StateName = name;
    }


    public virtual void Enter() //Virtual significa que los hijos pueden hacer override
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
