using UnityEngine;
using UnityEngine.UI;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject bullet;
    public Slider healthBar;



    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Pool.sharedInstance.Get("Bullet");
            if (b != null)
            {
                b.transform.position = this.transform.position;
                b.SetActive(true);
            }
        }

        Vector3 screenPos = Camera.main.WorldToScreenPoint(this.transform.position) + new Vector3(0, -120, 0);
        healthBar.transform.position = screenPos;
    }
}