using UnityEngine;

public class EtriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider t)
    {
        if(t.gameObject.tag == "Player")
        {
            EtriggerPlayerScript eTriggerPlayerScript = t.gameObject.GetComponent<EtriggerPlayerScript>();
            eTriggerPlayerScript.flg = true;
        }
    }
}
