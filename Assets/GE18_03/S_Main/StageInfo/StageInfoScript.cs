using UnityEngine;

public class StageInfoScript : MonoBehaviour
{
    private EtriggerPlayer2Script eTriggerPlayer2Script;
    [SerializeField] private string SceneName;
    private bool flg = false;
    void OnTriggerEnter(Collider t)
    {

        if(t.tag == "Egg")
        {
            flg = true;
        }
        if(t.tag == "Player" && flg)
        {
            eTriggerPlayer2Script = t.gameObject.GetComponent<EtriggerPlayer2Script>();
            eTriggerPlayer2Script.flg = true;
            eTriggerPlayer2Script.SceneName = SceneName;
        }
    }

    private void OnTriggerExit(Collider t)
    {
        if (t.tag == "Player")
        {
            eTriggerPlayer2Script = t.gameObject.GetComponent<EtriggerPlayer2Script>();
            eTriggerPlayer2Script.flg = true;
        }
    }
}
