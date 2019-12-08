using UnityEngine;
/// <summary>
/// Tile of earth to build level
/// </summary>
public class LevelTile : ILevelTile
{
    private GameObject root = null;

    public LevelTile(GameObject rootObj)
    {
        root = rootObj;
    }

    public Vector3 GetTileSize()
    {
        return root.transform.localScale;
    }
}