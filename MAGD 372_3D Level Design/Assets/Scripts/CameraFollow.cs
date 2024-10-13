using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    [SerializeField] private Vector3 offset;

    [SerializeField] [Range(0f, 1f)]
    private float smoothSpeed = 0.125f;

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
    }
}
