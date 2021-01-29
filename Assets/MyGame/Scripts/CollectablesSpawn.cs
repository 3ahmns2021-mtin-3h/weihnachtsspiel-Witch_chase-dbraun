using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesSpawn : MonoBehaviour
{
    public GameObject collectable;
    public GameObject parentSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnCollectable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnCollectable();
        }
    }
    private void SpawnCollectable()
    {
        var clones = Instantiate(collectable);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-50, 50), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

}
