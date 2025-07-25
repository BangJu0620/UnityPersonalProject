using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target == null) return;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(target.position.x, -6f, 6f);
        pos.y = Mathf.Clamp(target.position.y, -4.9f, 5.2f);
        transform.position = pos;
    }
}
