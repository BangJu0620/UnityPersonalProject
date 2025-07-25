using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjectManager : MonoBehaviour
{
    [SerializeField] protected LayerMask levelCollisionLayer;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {

    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
