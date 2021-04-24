using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;

    GameObject objectsParent;
    const string OBJECTS_PARENT_NAME = "Objects";

    private void Start()
    {
        objectsParent = GameObject.Find(OBJECTS_PARENT_NAME);
        if (!objectsParent)
        {
            objectsParent = new GameObject(OBJECTS_PARENT_NAME);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0,100) < 10)
        {
            var cube = Instantiate(cubePrefab, transform.position, Quaternion.identity);
            cube.transform.parent = objectsParent.transform;
        }
        else if (Random.Range(0, 100) < 10)
        {
            var sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity);
            sphere.transform.parent = objectsParent.transform;
        }
    }
}
