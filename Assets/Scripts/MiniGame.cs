using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : InteractableObjectManager
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if ((levelCollisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            // 미니게임 입장
            Debug.Log("미니게임 입장");
        }
    }
}
