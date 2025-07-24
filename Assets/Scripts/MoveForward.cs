using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float modifier = 1f;
    private void Update()
    {
        // Get the speed from the SpeedManager
        float speed = SpeedManager.Speed;

        // Apply movement to the object using that speed
        transform.Translate(Vector3.forward * speed * modifier * Time.deltaTime);
    }
}
