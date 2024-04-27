using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    public float xOffset = 0f;
    public float yOffset = 0f;

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position;
            Vector3 newPosition = new Vector3(targetPosition.x + xOffset, targetPosition.y + yOffset, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
        }
    }
}
