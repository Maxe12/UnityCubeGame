using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransformObj;
    public Vector3 cameraOffset;

    private void Update()
    {
        transform.position = playerTransformObj.position + cameraOffset;
    }
}
