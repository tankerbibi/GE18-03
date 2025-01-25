using UnityEngine;

public class EtriggerScript : MonoBehaviour
{
    public bool lockFlg = true;
    //void OnTriggerEnter(Collider t)
    //{
    //    if(t.tag == "Player")
    //    {
    //        EtriggerPlayerScript eTriggerPlayerScript = t.gameObject.GetComponent<EtriggerPlayerScript>();
    //        eTriggerPlayerScript.flg = true;
    //    }
    //}

    void OnTriggerStay(Collider t)
    {
        if(t.tag == "Player" && !lockFlg)
            {
                EtriggerPlayerScript eTriggerPlayerScript = t.gameObject.GetComponent<EtriggerPlayerScript>();
                eTriggerPlayerScript.flg = true;
            }
    }
}
