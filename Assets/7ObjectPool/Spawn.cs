using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteroid;

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
            //Instantiate(asteroid, transform.position + new Vector3(Random.Range(-16, 16), 0, 0), Quaternion.identity);
            GameObject a = Pool.sharedInstance.Get("Asteroid");
            if (a != null)
            {
                a.transform.position = transform.position + new Vector3(Random.Range(-16, 16), 0, 0);
                a.SetActive(true);
            }
        }

    }
}
