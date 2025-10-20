using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;
    
    public BallController ballController;

    public int playerScore = 0;
    public int enemyScore = 0;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI enemyScoreText;

    public int winPoints = 3;

    public GameObject screenGameOver;

    public TextMeshProUGUI textEndGame;

    public static bool pauseGame = false;
    public GameObject uiPauseMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseGame();
        }
    }

    public void ResetGame()
    {
        playerPaddle.position = new Vector3(playerPaddle.position.x, 0, 0);
        enemyPaddle.position = new Vector3(enemyPaddle.position.x, 0, 0);
        ballController.ResetBall();
        playerScore = 0;
        enemyScore = 0;
        playerScoreText.text = playerScore.ToString();
        enemyScoreText.text = enemyScore.ToString();
        screenGameOver.SetActive(false);
    }

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        CheckWin();
    }

    public void EnemyScores()
    {
        enemyScore++;
        enemyScoreText.text = enemyScore.ToString();
        CheckWin();
    }
    public void CheckWin()
    {
        if (enemyScore >= winPoints || playerScore >= winPoints)
        {
            EndGame(); 
        }
    }

    public void EndGame()
    {
        screenGameOver.SetActive(true);
        string winner = SaveController.Instance.GetName(playerScore > enemyScore);
        textEndGame.text = "The Winner is, " + winner + " !";
        SaveController.Instance.SaveWinner(winner);
        
        RankingManager.AddWinToPlayer(winner);
        
        Invoke(nameof(LoadMenu), 3f);

    }
    private void LoadMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }



    public void TogglePauseGame()
    {
        pauseGame = !pauseGame;
        if (pauseGame)
        {
            Time.timeScale = 0f;
            uiPauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            uiPauseMenu.SetActive(false);
        }
    }

    public void ToggleContinueGame()
    {
        Time.timeScale = 1f;
        uiPauseMenu.SetActive(false);
        pauseGame = false;

    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        uiPauseMenu.SetActive(false);
        pauseGame = false;
        ResetGame();
    }

    public void ExitMatch()
    {
        Time.timeScale = 1f;
        uiPauseMenu.SetActive(false);
        pauseGame = false;
        SceneManager.LoadScene("MenuScreen_BattleMode");
    }
}
