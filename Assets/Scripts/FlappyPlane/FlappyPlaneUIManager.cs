using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlappyPlaneUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Button startButton;
    public Button exitButton;
    public Button restartButton;
    public Image image;

    FlappyPlaneManager flappyPlaneManager;
    Player player;
    FlappyPlaneUIManager flappyPlaneUIManager;

    void Start()
    {
        flappyPlaneManager = FlappyPlaneManager.Instance;
        player = Player.Instance;
        flappyPlaneUIManager = GetComponent<FlappyPlaneUIManager>();

        if (GameManager.instance.isFirstPlayFlappyPlane)
        {
            // 첫 시작때 킬것들
            image.gameObject.SetActive(true);
            startButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
        }
        else
        {
            // 재시작때 킬것들
            OnClickStartButton();
        }
        // 상관없이 적용할 것들
        GameManager.instance.isFirstPlayFlappyPlane = false;
        flappyPlaneUIManager.UpdateScore(0);
    }

    public void SetRestart()
    {
        restartButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void OnClickStartButton()
    {
        player._rigidbody.simulated = true;
        scoreText.gameObject.SetActive(true);
        Time.timeScale = 1f;
        startButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    public void OnClickRestartButton()
    {
        SceneManager.LoadScene("FlappyPlaneScene");
    }

    public void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
