using UnityEngine;
using TMPro;

public class InputName : MonoBehaviour
{
    public bool isPlayer;
    public TMP_InputField inputField;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputField.onValueChanged.AddListener(UpdateName);
    }

    // Update is called once per frame
    void UpdateName(string name)
    {
        if (isPlayer)
            SaveController.Instance.namePlayer1 = name;
        else
            SaveController.Instance.namePlayer2 = name;
    }
}
