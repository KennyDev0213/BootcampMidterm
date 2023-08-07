using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeItemSpawning : MonoBehaviour
{
    Queue<GameObject> itemQueue = new Queue<GameObject>();

    public Transform spawnPoint;

    public GameObject itemToSpawn;
    public int itemLimit = 5;

    public void SpawnItem()
    {
        GameObject item = Instantiate(itemToSpawn, spawnPoint.position, spawnPoint.rotation);
        itemQueue.Enqueue(item);

        if (itemQueue.Count > itemLimit){
            Destroy(itemQueue.Dequeue());
        }
    }

    void Start()
    {
        if(itemToSpawn == null){
            Debug.LogWarning($"{name} does not have a item to spawn, if you try to spawn an item from this pipe, it will throw a null error");
        }        
    }
}
