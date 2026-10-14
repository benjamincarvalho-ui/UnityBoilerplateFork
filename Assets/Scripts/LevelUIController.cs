using UnityEngine;
using TMPro;

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
}
