using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingManager : MonoBehaviour
{
    public static RankingManager instance;

    public static int rankCount = 5;

    List<int> scoresList = new List<int>();

    int i = 0;

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
        while(PlayerPrefs.GetInt(i.ToString()) != 0)
        {
            CheckHigh(PlayerPrefs.GetInt(i.ToString()));
            i++;
        }
    }

    public void CheckHigh(int score)
    {
        //bool isExist = false;
        //for (int i = 0; i < rankCount; i++)
        //{
        //    if(score > scoresList[i])
        //    {
        //        scoresList.Insert(i, score);
        //        isExist = true;
        //        break;
        //    }
        //}
        scoresList.Add(score);
        scoresList.Sort();
        scoresList.Reverse();
        if(scoresList.Count > rankCount)
        {
            scoresList.RemoveAt(rankCount);
        }
        //return isExist;
    }

    public void AddRanking()
    {
        //if (isExist)
        //{
            for (int i = 0; i < scoresList.Count; i++)
            {
                PlayerPrefs.SetInt(i.ToString(), scoresList[i]);
            }
        //}
    }
}
