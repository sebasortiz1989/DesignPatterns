using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnviroment
{
    private static GameEnviroment sharedInstance;

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

    private List<GameObject> obstacles = new List<GameObject>();
    public List<GameObject> Obstacles { get { return obstacles; } }

    private List<GameObject> goals = new List<GameObject>();
    public List<GameObject> Goals { get { return goals; }}

    public GameObject GetRandomGoal()
    {
        int index = Random.Range(0, goals.Count);
        return goals[index];
    }

    public void AddObstacles(GameObject go)
    {
        obstacles.Add(go);
    }

    public void RemoveObstacles(GameObject go)
    {
        int index = obstacles.IndexOf(go);
        obstacles.RemoveAt(index);
        GameObject.Destroy(go);
    }
}
