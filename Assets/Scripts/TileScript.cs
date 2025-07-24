using UnityEngine;

public class TileScript : MonoBehaviour
{

    TileController tileController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        tileController = GameObject.FindFirstObjectByType<TileController>();
    }

    private void OnTriggerExit(Collider other)
    { 
       
        if (other.CompareTag("TileTag"))
        {
            //print("exited");
            tileController.SpawnTile();
        }
       
    }

}

