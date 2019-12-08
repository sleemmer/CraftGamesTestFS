using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Class managing all game configs
/// </summary>
public class LevelManager : IGameManager
{
    private static LevelManager instance = null;
    public static LevelManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LevelManager();
            }
            return instance;
        }
    }

    public LevelManager()
    {
        LevelRoot = new GameObject("LevelRoot");
        SetPathBuilder();
    }

    private GameObject LevelRoot = null;

    private IPathBuilder pathBuilder = null;
    public void SetPathBuilder()
    {
        pathBuilder = new PathBuilder();
    }

    private List<ILevelTile> tilePool = new List<ILevelTile>();

    public void Start()
    {
        string path = pathBuilder.GetLevelObjectsPath("LevelTile");
        Object levelTile = Resources.Load(path);

        if (levelTile != null)
        {
            CreateTiles(10, levelTile);
        }
    }

    private void CreateTiles(int poolSize, Object tileObj)
    {
        List<ILevelTile> tiles = new List<ILevelTile>();
        for (int i = 0; i < poolSize; i++)
        {
            var tileGO = GameObject.Instantiate(tileObj, Vector3.zero, Quaternion.identity) as GameObject;
            tileGO.transform.SetParent(LevelRoot.transform);
            if (i < 5)
            {
                tileGO.transform.localPosition = new Vector3(0, 0, i);
            }
            else
            {
                tileGO.transform.localPosition = new Vector3(i - 5, 0, 5);
            }
            LevelTile tile = new LevelTile(tileGO);
        }
    }

    public void Update()
    {

    }

    public void Dispose()
    {

    }
}