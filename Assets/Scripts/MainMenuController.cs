using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    public void goToLevel()
    {
        SceneManager.LoadScene("Level");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
