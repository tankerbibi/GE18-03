using UnityEngine;

public class EtriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider t)
    {
        Debug.Log("yes");
        if (t.tag == "Player")
        {
            EtriggerPlayerScript eTriggerPlayerScript = t.gameObject.GetComponent<EtriggerPlayerScript>();
            eTriggerPlayerScript.flg = true;
        }
    }
    //void OnTriggerStay(Collider t)
    //{
    //    if(t.tag == "Player")
    //        {
    //            EtriggerPlayerScript eTriggerPlayerScript = t.gameObject.GetComponent<EtriggerPlayerScript>();
    //            eTriggerPlayerScript.flg = true;
    //        }
    //}
}
