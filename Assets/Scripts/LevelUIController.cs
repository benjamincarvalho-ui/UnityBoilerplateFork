using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelUIController : MonoBehaviour
{
    public int lives, score;
    public float totalTime;
    public TextMeshProUGUI LivesLabel, ScoreLabel, TimeLabel;


    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        LivesLabel.text = "Lives: " + lives;
        ScoreLabel.text = "Score: " + score;
        TimeLabel.text = "Time: " + totalTime.ToString(format:"0.0###")+"s";
    }

    public void Kill()
    {
        lives--;
        if (lives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Collect()
    {
        score++;
        if (score == 100)
        {
            lives++;
        }
    }
}
