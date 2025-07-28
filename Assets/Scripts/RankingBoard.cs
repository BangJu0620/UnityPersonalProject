using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingBoard : MonoBehaviour
{
    public Image rankingBoard;
    public Text rankingScoreText;

    void Start()
    {
        WriteRanking(RankingManager.rankCount);
    }

    public void WriteRanking(int rankCount)
    {
        rankingScoreText.text = string.Empty;
        for (int i = 0; i < rankCount; i++)
        {
            rankingScoreText.text += $"{i + 1}\t\t{PlayerPrefs.GetInt(i.ToString(), 0)}";
            if (i < rankCount - 1)
                rankingScoreText.text += "\n";
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        WriteRanking(RankingManager.rankCount);
    }
}
