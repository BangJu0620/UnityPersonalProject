using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyPlaneManager : MonoBehaviour
{
    static FlappyPlaneManager flappyPlaneManager;
    public static FlappyPlaneManager Instance { get { return flappyPlaneManager; } }

    public int currentScore = 0;

    FlappyPlaneUIManager flappyPlaneUIManager;

    public FlappyPlaneUIManager UIManager { get { return flappyPlaneUIManager; } }

    private void Awake()
    {
        flappyPlaneManager = this;
        flappyPlaneUIManager = FindObjectOfType<FlappyPlaneUIManager>();
    }

    public void Start()
    {
        flappyPlaneUIManager.UpdateScore(0);
    }
    public void GameOver()
    {
        RankingManager.instance.AddRanking(RankingManager.instance.CheckHigh(currentScore));
        flappyPlaneUIManager.SetRestart();
    }

    public void AddScore(int score)
    {
        currentScore += score;
        flappyPlaneUIManager.UpdateScore(currentScore);
        if (flappyPlaneManager.currentScore >= GameManager.instance.bestScoreFlappyPlane)
        {
            GameManager.instance.bestScoreFlappyPlane = flappyPlaneManager.currentScore;
        }
    }
}
