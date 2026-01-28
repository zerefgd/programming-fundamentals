using UnityEngine;

public class TrapTester : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public int Health = 100;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(moveX, 0, moveZ));
    }

    public void ApplyDamage(int amount)
    {
        Health -= amount;
        Debug.Log($"Took {amount} damage. Remaining health: {Health}");
    }
    public void ApplySlow(float slowAmount, float duration)
    {
        Debug.Log($"Slowed by {slowAmount * 100}% for {duration} seconds.");
        // Implement slow logic here
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Lesson11.Project.TrapBase>(out var trap))
        {
            trap.TriggerTrap(gameObject);
        }
    }
}
