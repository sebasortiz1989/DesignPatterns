using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnviroment
{
    private static GameEnviroment sharedInstance;

    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public static GameEnviroment Singleton
    {
        get
        {
            if (sharedInstance == null)
            {
                sharedInstance = new GameEnviroment();
                sharedInstance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));
            }
            return sharedInstance;
        }
    }
}
