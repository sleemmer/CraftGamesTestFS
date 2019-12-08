using UnityEngine;
/// <summary>
/// Tile of earth to build level
/// </summary>
public interface IActiveObject
{
    bool IsTriggerIn();

    bool IsTriggerOut();
}