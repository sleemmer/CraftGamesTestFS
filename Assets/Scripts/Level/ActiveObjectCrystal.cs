using UnityEngine;
/// <summary>
/// Tile of earth to build level
/// </summary>
public class ActiveObjectCrystal : IActiveObject
{
    private GameObject root = null;
    public ActiveObjectCrystal(GameObject rootObj)
    {
        root = rootObj;
    }

    public bool IsTriggerIn()
    {
        return false;
    }

    public bool IsTriggerOut()
    {
        return false;
    }
}