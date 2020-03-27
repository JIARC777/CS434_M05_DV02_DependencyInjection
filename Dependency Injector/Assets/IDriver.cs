using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDriver
{
    void Control(Bike bike);
}

public class HumanDriver: IDriver
{
    private Bike bike;

    public void Control(Bike bikeToUse)
    {
        bike = bikeToUse;
        Debug.Log("A Human (Player) will control the bike");
    }
}

public class AIDriver : IDriver
{
    private Bike bike;

    public void Control(Bike bikeToUse)
    {
        bike = bikeToUse;
        Debug.Log("An AI (Computer) will control the bike");
    }
}
