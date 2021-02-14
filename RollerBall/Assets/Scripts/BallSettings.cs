using UnityEngine;

public class BallSettings : MonoBehaviour
{
    Renderer rend;
    
    void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");
        rend = player.GetComponent<Renderer>();
        rend.material.SetColor("_Color", ColorSelect.Ballc);
        player.transform.localScale = ChangeBallSize.ballsize;
    }
}
