using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    [SerializeField] PlantData info;

    SetPlantInfo spi;

    private void Start()
    {
        spi = GameObject.FindWithTag("PlantInfo").GetComponent<SetPlantInfo>();
    }

    private void OnMouseDown()
    {
        spi.OpenPlantPanel();
        spi.plantName.text = info.Name;
        spi.threatLevel.text = info.Threat.ToString();
        spi.plantIcon.GetComponent<RawImage>().texture = info.Icon;
    }

    //public PlantData plantData
    //{
    //    get { return info; }
    //}

    //You can also do it like this
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && info.Threat == PlantData.THREAT.High)
        {
            PlayerController.dead = true; //Dead is a static public property in player controller
        }
    }
}
