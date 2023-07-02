using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 xRange = new Vector2(-10, 10);
    public Vector2 zRange = new Vector2(-10, 10);

    private Vector3 targetPosition;

    private void Start()
    {
        SetNewTarget();
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void SetNewTarget()
    {
        float randomX = Random.Range(xRange.x, xRange.y);
        float randomZ = Random.Range(zRange.x, zRange.y);
        targetPosition = new Vector3(randomX, transform.position.y, randomZ);
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            SetNewTarget();
        }
    }
}