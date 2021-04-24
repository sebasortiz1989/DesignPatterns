using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphereSpawner : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 10)
        {
            ProcCube.Clone(this.transform.position);
        }
        else if (Random.Range(0, 100) < 10)
        {
            ProcSphere.Clone(this.transform.position);
        }
    }
}
