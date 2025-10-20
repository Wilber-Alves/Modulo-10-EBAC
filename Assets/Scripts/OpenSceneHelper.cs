using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSceneHelper : MonoBehaviour
{
    public string sceneToOpen;
   
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneToOpen);
    }
    public void RankingScreen()
    {
        SceneManager.LoadScene("RankingScreen"); // Use o nome ou o índice da cena
    }
}
