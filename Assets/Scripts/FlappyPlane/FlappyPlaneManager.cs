using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyPlaneManager : MonoBehaviour
{
    static FlappyPlaneManager flappyPlaneManager;
    public static FlappyPlaneManager Instance { get { return flappyPlaneManager; } }

    public int currentScore = 0;

    FlappyPlaneUIManager uiManager;

    public FlappyPlaneUIManager UIManager { get { return uiManager; } }

    private void Awake()
    {
        flappyPlaneManager = this;
        uiManager = FindObjectOfType<FlappyPlaneUIManager>();
    }

    public void Start()
    {
        uiManager.UpdateScore(0);
    }
    public void GameOver()
    {
        uiManager.SetRestart();
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        if (flappyPlaneManager.currentScore >= GameManager.instance.bestScoreFlappyPlane)
        {
            GameManager.instance.bestScoreFlappyPlane = flappyPlaneManager.currentScore;
        }
    }
}
