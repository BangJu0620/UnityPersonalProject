using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame : InteractableObjectManager
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if ((levelCollisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            // 미니게임 입장
            GameManager.instance.isFirstPlayFlappyPlane = true;
            SceneManager.LoadScene("FlappyPlaneScene");
        }
    }
}
