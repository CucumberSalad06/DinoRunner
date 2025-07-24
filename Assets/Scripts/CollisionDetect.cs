using System.Collections;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
    SpawnManager spawnManager;
    MoveForward moveForward;

    public bool isSolid = true;
    bool isSlowed = false;
    float speed = SpeedManager.Speed;
    //bool isRolling = PlayerController.isRolling;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        spawnManager = GameObject.FindAnyObjectByType<SpawnManager>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("slowing down...");
            if (isSolid == true || isSlowed ==true)
            {
                spawnManager.GetComponent<SpeedManager>().speed = 0;
                spawnManager.enabled = false;
            }
            else
            {
                isSlowed = true;
                StartCoroutine(speedUp());
                isSlowed = false;
            }
        }
    }
    private IEnumerator speedUp()
    {
        spawnManager.GetComponent<SpeedManager>().speed = speed * 0.6f;

        yield return new WaitForSeconds(3f);
        spawnManager.GetComponent<SpeedManager>().speed = speed;

    }

}
