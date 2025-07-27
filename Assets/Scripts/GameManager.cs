using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private FlappyPlaneUIManager uiManager;

    public PlayerController player { get; private set; }

    public bool isFirstPlayFlappyPlane = true;

    public int bestScoreFlappyPlane = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        player = FindObjectOfType<PlayerController>();
        uiManager = FindObjectOfType<FlappyPlaneUIManager>();
    }

    private void Start()
    {
        
    }
}
