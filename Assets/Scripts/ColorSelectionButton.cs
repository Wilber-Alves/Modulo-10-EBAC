using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer = true;

    public void OnButtonClick()
    { 
        paddleReference.color = uiButton.colors.normalColor;

        if (isColorPlayer)
        {
           SaveController.Instance.colorPaddle_Player1 = paddleReference.color;
        }
        else
        {
           SaveController.Instance.colorPaddle_Player2 = paddleReference.color;
        }


    }

}
