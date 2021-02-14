using UnityEngine;
using UnityEngine.UI;

public class ChangeBallSize : MonoBehaviour
{
    public Toggle toggle;
    public GameObject playerObject;
    public static Vector3 ballsize;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GameObject.Find("ChangeSize").GetComponent<Toggle>();
        //playerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(toggle.isOn)
        {
            ballsize = new Vector3(5, 5, 5);
        }

        else
        {
            ballsize = new Vector3(1, 1, 1);
        }
    }
}
