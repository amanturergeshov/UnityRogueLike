using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] Vector2 minMaxXY;

    private void LateUpdate()
    {
        if (Target == null)
        {
            Debug.LogWarning("Target of Camera is null");
            return;
        }
        Vector3 TargetPosition = Target.position;
        TargetPosition.z = -10;

        TargetPosition.x = Mathf.Clamp(TargetPosition.x, -minMaxXY.x, minMaxXY.x);
        TargetPosition.y = Mathf.Clamp(TargetPosition.y, -minMaxXY.y, minMaxXY.y);

        transform.position = TargetPosition;
    }
}
