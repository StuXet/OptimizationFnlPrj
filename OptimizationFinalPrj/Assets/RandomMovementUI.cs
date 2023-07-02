using UnityEngine;
using UnityEngine.UI;

public class RandomMovementUI : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 xRange = new Vector2(-10, 10);
    public Vector2 yRange = new Vector2(-10, 10);
    public float rotationSpeed = 50f;

    private Vector3 targetPosition;

    private void Start()
    {
        SetNewTarget();
    }

    private void Update()
    {
        MoveAndRotateTowardsTarget();
    }

    private void SetNewTarget()
    {
        float randomX = Random.Range(xRange.x, xRange.y);
        float randomY = Random.Range(yRange.x, yRange.y);
        targetPosition = new Vector3(randomX, randomY, 0f);
    }

    private void MoveAndRotateTowardsTarget()
    {
        // Move towards target
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);

        // Rotate over time
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.localPosition, targetPosition) < 0.01f)
        {
            SetNewTarget();
        }
    }
}