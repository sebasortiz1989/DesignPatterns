using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    Text message;
    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<Text>();
        message.enabled = false;
    }

    public void DisplayMessage(GameObject go)
    {
        message.text = "You Picked up and item!!!";
        message.enabled = true;
        Invoke("TurnOff", 2f);
    }

    void TurnOff()
    {
        message.enabled = false;
    }
}
