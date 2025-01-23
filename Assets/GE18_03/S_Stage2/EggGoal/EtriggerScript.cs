using UnityEngine;

public class EtriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider t)
    {
        if(t.gameObject.tag == "Player")
        {
            Debug.Log("ƒS[ƒ‹‚¾‚æ");
        }
    }
}
