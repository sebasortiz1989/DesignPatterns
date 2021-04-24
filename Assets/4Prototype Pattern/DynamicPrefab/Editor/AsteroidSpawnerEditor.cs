using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor (typeof(AsteroidSpawner))]
public class AsteroidSpawnerEditor : Editor
{
    string path;
    string assetPath;
    string filename;

    void OnEnable()
    {
        path = Aplication.dataPath + "/Asteroid";
        assetPath = "Assets/Asteroid/";
        filename = "asteroid_" + System.DateTime.Now.Ticks.ToString();
    }

    public override void OnInspectorGUI()
    {
        AsteroidSpawnerEditor astSpawner = (AsteroidSpawner)target;
        DrawDefaultInspector();

        if (GUILayout.Button("Create Asteroid"))
            astSpawner.CreateAsteroid();

        if (GUILayout.Button("Save Asteroid"))
        {
            System.IO.Directory.CreateDirectory(path);
            Mesh mesh = astSpawner.asteroid.GetComponent<MeshFilter>().sharedMesh;
            AssetDatabase.CreateAsset(mesh, assetPath + mesh.name + ".asset");
            AssetDatabase.SaveAssets();

            PrefabUtility.SaveAsPrefabAsset(astSpawner.asteroid, assetPath + filename + ".prefab");
        }
    }
}
