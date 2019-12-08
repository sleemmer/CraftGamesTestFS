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
    }

    public void Start()
    {
    }

    public void Update()
    {

    }

    public void Dispose()
    {

    }
}