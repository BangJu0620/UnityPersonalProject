using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingManager : MonoBehaviour
{
    public static RankingManager instance;

    public static int rankCount = 5;

    List<int> scoresList = new List<int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        for(int i = 0;  i < rankCount; i++)
        {
            scoresList.Add(0);
        }
    }

    public bool CheckHigh(int score)
    {
        bool isExist = false;
        for (int i = 0; i < rankCount; i++)
        {
            if(score > scoresList[i])
            {
                scoresList.Insert(i, score);
                isExist = true;
                break;
            }
        }
        if(scoresList.Count > rankCount)
        {
            scoresList.RemoveAt(rankCount);
        }
        return isExist;
    }

    public void AddRanking(bool isExist)
    {
        if (isExist)
        {
            for (int i = 0; i < rankCount; i++)
            {
                PlayerPrefs.SetInt(i.ToString(), scoresList[i]);
            }
        }
    }
}
