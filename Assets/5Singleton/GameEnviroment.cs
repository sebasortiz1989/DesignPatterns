using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnviroment
{
    private static GameEnviroment sharedInstance;
    private List<GameObject> obstacles = new List<GameObject>();

    public List<GameObject> Obstacles { get { return obstacles; } }

    public static GameEnviroment Singleton
    {
        get 
        { 
            if (sharedInstance == null)
            {
                sharedInstance = new GameEnviroment();
            }
            return sharedInstance;        
        }
    }

    public void AddObstacles(GameObject go)
    {
        obstacles.Add(go);
    }

    public void RemoveObstacles(GameObject go)
    {
        int index = obstacles.IndexOf(go);
        obstacles.RemoveAt(index);
    }
}
