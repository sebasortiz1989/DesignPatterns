using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantData", menuName = "Plant Data", order = 51)]
public class PlantData : ScriptableObject
{
    // Put a bunch of properties

    public enum THREAT
    { 
    None, Low, Moderate, High
    }

    [SerializeField] string plantName;
    [SerializeField] THREAT plantThreat;
    [SerializeField] Texture icon;

}
