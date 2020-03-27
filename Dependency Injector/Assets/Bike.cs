using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    private IEngine engine;
    private IDriver driver;

    // Setter injection
    public void SetEngine(IEngine engineToUse)
    {
        engine = engineToUse;
    }
    public void SetDriver(IDriver driverToUse)
    {
        driver = driverToUse;
    }
    public void StartEngine()
    {
        engine.StartEngine();
        driver.Control(this);
    }
    
    public void TurnLeft()
    {
        Debug.Log("The bike is turning left");
    }
    public void TurnRight()
    {
        Debug.Log("The bike is turning Right");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
