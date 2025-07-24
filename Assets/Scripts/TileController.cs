using UnityEngine;

public class TileController : MonoBehaviour
{
    public GameObject tile;
    Vector3 Endpoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate (tile, gameObject.transform.position, Quaternion.identity);
        Endpoint = temp.transform.GetChild(0).transform.position;
    }
    // Update is called once per frame
    void Start()

    {


    }
}

