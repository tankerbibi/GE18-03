using UnityEngine;

public class SwitchCollisionScript : MonoBehaviour
{
    SwitchMoveScript switchMoveScript;
    public CagoUpScript cagoUpScript;
    public EtriggerPlayerScript etriggerPlayerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switchMoveScript = GetComponent<SwitchMoveScript>();
    }

    void OnTriggerEnter(Collider t)
    {
        if(t.tag == "Egg")
        {
            switchMoveScript.ChangeAppear();
            cagoUpScript.flg = true;
            //etriggerPlayerScript.flg = true;
        }
    }
}
