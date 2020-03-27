using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IEngine
{
    void StartEngine();
}
public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine Started");
    }
    private void ActivateJetStream()
    {
        Debug.Log("The Jet Stream is Activated");
    }
}

public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine Started");
    }
    private void OpenNitroValve()
    {
        Debug.Log("The nitro valve is open");
    }
}
public class WarpEngine : IEngine
{
    public void StartEngine()
    {
        GoToWarp();
        Debug.Log("Engine Started");
    }
    private void GoToWarp()
    {
        Debug.Log("Warp Core initialized");
    }
}
public class Hyperdrive : IEngine
{
    public void StartEngine()
    {
        EnterHyperspace();
        Debug.Log("Engine Started");
    }
    private void EnterHyperspace()
    {
        Debug.Log("Hyperdrive initialized");
    }
}