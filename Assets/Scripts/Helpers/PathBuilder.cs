/// <summary>
/// Class managing all game configs
/// </summary>
public class PathBuilder : IPathBuilder
{
    public string GetLevelObjectsPath(string objName)
    {
        return string.Format("Gameplay/LevelObjects/{0}", objName);
    }
}