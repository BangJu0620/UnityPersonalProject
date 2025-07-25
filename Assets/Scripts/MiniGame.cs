using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : InteractableObjectManager
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if ((levelCollisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            // �̴ϰ��� ����
            Debug.Log("�̴ϰ��� ����");
        }
    }
}
