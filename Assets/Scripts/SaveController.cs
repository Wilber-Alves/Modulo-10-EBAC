using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    public Color colorPaddle_Player1 = Color.white;
    public Color colorPaddle_Player2 = Color.white;

    public static SaveController _instance;

    public string namePlayer1;
    public string namePlayer2;

    private string savedWinnerKey = "SavedWinner";

    public static SaveController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindFirstObjectByType<SaveController>();
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(SaveController).Name);
                    _instance = singletonObject.AddComponent<SaveController>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
    }

    public string GetName(bool isPlayer)
    {
        return isPlayer ? namePlayer1 : namePlayer2;
    }

    public void ResetNames()
    {
        namePlayer1 = "Player 1";
        namePlayer2 = "Player 2";
        colorPaddle_Player1 = Color.white;
        colorPaddle_Player2 = Color.white;
    }

    public void SaveWinner(string winner)
    { 
        PlayerPrefs.SetString(savedWinnerKey, winner);
    }
    public string GetLastWinner()
    {
        return PlayerPrefs.GetString(savedWinnerKey);
    }
    public void ClearSave()
    {
        PlayerPrefs.DeleteKey(savedWinnerKey);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
