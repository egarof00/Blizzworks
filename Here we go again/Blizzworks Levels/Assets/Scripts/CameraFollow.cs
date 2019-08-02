using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void LateUpdate() {
      transform.position = target.position + offset;
    }
}
