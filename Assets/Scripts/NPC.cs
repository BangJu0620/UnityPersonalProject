using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : InteractableObjectManager
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if ((levelCollisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            // NPC ��ȣ�ۿ�
            Debug.Log("NPC ��ȣ�ۿ�");
        }
    }
}
