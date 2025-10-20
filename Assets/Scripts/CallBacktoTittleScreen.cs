using UnityEngine;
using UnityEngine.SceneManagement;

public class CallBacktoTittleScreen : MonoBehaviour

{
    public float timeForComeback = 5f;
    private float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeForComeback)
        {
            ReturnToTittleScreen();
        }
    }

    void ReturnToTittleScreen()
    {
        SceneManager.LoadScene("MenuScreen"); // Use o nome ou o índice da cena
    }
}
