using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string playerName;
    
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }
    
    public void SetPlayerName(string playerNameText)
    {
        playerName = playerNameText;
    }
}
