using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    // This is the speed that will be used by all objects
    public float speed = 5f;

    // Static variable to be accessed globally
    public static float Speed { get; private set; }

    private void Awake()
    {
        Speed = speed;  // Initialize the static speed
    }

    private void Update()
    {
        Speed = speed;
    }

    // Method to update speed during runtime
    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
        Speed = speed; 
    }
}