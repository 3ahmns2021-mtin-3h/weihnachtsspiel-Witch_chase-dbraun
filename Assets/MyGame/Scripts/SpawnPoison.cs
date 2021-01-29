using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoison : MonoBehaviour
{
    public GameObject Poison;
    public GameObject Parentpoison;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnThePoison();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnThePoison();
        }
    }
    private void SpawnThePoison()
    {
        var clones = Instantiate(Poison);
        clones.GetComponent<Transform>().SetParent(Parentpoison.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

}
