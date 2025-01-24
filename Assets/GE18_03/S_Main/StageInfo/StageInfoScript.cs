using UnityEngine;

public class StageInfoScript : MonoBehaviour
{
    private EtriggerPlayer2Script eTriggerPlayer2Script;
    [SerializeField] private string SceneName;
    void OnTriggerEnter(Collider t)
    {
        if(t.tag == "Player")
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
            eTriggerPlayer2Script.flg = false;
        }
    }
}
