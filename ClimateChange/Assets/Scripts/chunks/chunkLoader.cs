using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkLoader : MonoBehaviour {

    Transform _camera;
    [SerializeField]
    GameObject[] chunksEasy;
    [SerializeField]
    GameObject[] chunksMedium;
    [SerializeField]
    GameObject[] chunksHard;
    bool loaded;
    [SerializeField]
    float distanceSpawn;
    [SerializeField]
    float LowSpawn;

    private void Awake()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        loaded = false;
    }
    private void Update()
    {
        LoadChunk();
        DestroyThis();
    }
    void LoadChunk()
    {
        //checks if a new chunk should be created
        if(_camera.position.x >= transform.position.x - 20 && loaded == false)
        {
            Vector3 spawnLocation = new Vector3(transform.position.x + distanceSpawn, transform.position.y - LowSpawn, 13);
            int ods = Random.Range(1, 100);
            if(ods >= 1 && ods <= 40)
            {
                Instantiate(chunksEasy[Random.Range(0,chunksEasy.Length)], spawnLocation, Quaternion.identity);
            }
            if (ods >= 41 && ods <= 80)
            {
                Instantiate(chunksMedium[Random.Range(0, chunksMedium.Length)], spawnLocation, Quaternion.identity);
            }
            if (ods >= 81 && ods <= 100)
            {
                Instantiate(chunksHard[Random.Range(0, chunksHard.Length)], spawnLocation, Quaternion.identity);
            }
            loaded = true;
        }
    }
    void DestroyThis()
    {
        //if object is behind camera it dies.
        if(transform.position.x <= _camera.position.x - 40)
        {
            Destroy(this.gameObject);
        }
    }

}
