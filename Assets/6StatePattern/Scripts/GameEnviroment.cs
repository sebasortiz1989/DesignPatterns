using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
                sharedInstance.checkpoints = sharedInstance.checkpoints.OrderBy(waypoint => waypoint.name).ToList(); //Orders it in ascending alphabetical order.
            }
            return sharedInstance;
        }
    }
}
