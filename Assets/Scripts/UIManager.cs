using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image scoreImage;

    public Text bestScoreText;

    void Start()
    {
        if (GameManager.instance.isFirstPlayFlappyPlane == false)
        {
            // 점수 출력하는 UI 띄우기
            bestScoreText.text = "BestScore: " + GameManager.instance.bestScoreFlappyPlane.ToString();
            scoreImage.gameObject.SetActive(true);
        }
    }
}
