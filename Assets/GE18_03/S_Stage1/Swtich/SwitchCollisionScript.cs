using UnityEngine;

public class SwitchCollisionScript : MonoBehaviour
{
    SwitchMoveScript switchMoveScript;
    CagoUpScript cagoUpScript;
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
        }
    }
}
