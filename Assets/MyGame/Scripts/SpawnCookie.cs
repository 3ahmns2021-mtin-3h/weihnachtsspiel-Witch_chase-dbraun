using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCookie : MonoBehaviour
{
    public GameObject Cookie;
    public GameObject Spawncookie;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTheCookies();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheCookies();
        }
    }
    private void SpawnTheCookies()
    {
        var clones = Instantiate(Cookie);
        clones.GetComponent<Transform>().SetParent(Spawncookie.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

}
