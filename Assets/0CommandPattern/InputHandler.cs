using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] GameObject actor;
    Animator anim;
    Command keySpace, keyP, keyK;

    private void Awake()
    {
        anim = actor.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        keySpace = new PerformJump();
        keyP = new PerformPunch();
        keyK = new PerformKick();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            keyP.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            keyK.Execute(anim);
        }
    }
}
