using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    public Text Label;
    public GameObject GameOverScene;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        Score++;
        Label.text = Score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        this.GameOverScene.SetActive(true);
    }
}
