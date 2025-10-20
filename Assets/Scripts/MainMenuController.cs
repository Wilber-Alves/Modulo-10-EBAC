using UnityEngine;
using TMPro;

public class MainMenuController : MonoBehaviour
{

    public TextMeshProUGUI uiWinner;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SaveController.Instance.ResetNames();
        string lastWinner = SaveController.Instance.GetLastWinner();

        if (lastWinner != "")
        {
            uiWinner.text = lastWinner;
        }
        else
        {
            uiWinner.text = "";
        }
    }

}
