using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class RankingManager : MonoBehaviour
{
    public float delayInSeconds = 5f;
    public GameObject rankingPanel;
    public TextMeshProUGUI rankingText;
    
    private static string WinKeyPrefix = "SavedWinner";

   
    public static void AddWinToPlayer(string winner)
    {
        int currentWins = PlayerPrefs.GetInt(WinKeyPrefix + winner, 0);
        currentWins++;
        PlayerPrefs.SetInt(WinKeyPrefix + winner, currentWins);
        PlayerPrefs.Save();
    }

    void Start()
    {

        if (rankingPanel != null)
        {
            rankingPanel.SetActive(false);
        }

        StartCoroutine(ShowRankingWithDelay());
    }

    IEnumerator ShowRankingWithDelay()
    {

        yield return new WaitForSeconds(delayInSeconds);


        if (rankingPanel != null)
        {
            rankingPanel.SetActive(true);
            UpdateRankingUI();
        }
    }

    void UpdateRankingUI()
    {

        string rankingDisplay = $"Victories:\n";
   
        int winsPlayer1 = PlayerPrefs.GetInt(WinKeyPrefix + "Player 1", 0);
        rankingDisplay += $"Player 1: {winsPlayer1}\n";
        
        int winsPlayer2 = PlayerPrefs.GetInt(WinKeyPrefix + "Player 2", 0);
        rankingDisplay += $"Player 2: {winsPlayer2}\n";
        


        if (rankingText != null)
        {
            rankingText.text = rankingDisplay;
        }
    }
}
