using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    public float spawnRate = 1.0f;
    public float xOffset = 5.0f;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObject();
            timer = 0;
        }
            
    }

    void SpawnObject()
    {
        float rightMost = transform.position.x + xOffset;
        float leftMost = transform.position.x - xOffset;

        int objectIndex = Random.Range(0, gameObjects.Length);
        Instantiate(gameObjects[objectIndex],new Vector3(Random.Range(rightMost, leftMost), transform.position.y, transform.position.z), transform.rotation);
    }
}
