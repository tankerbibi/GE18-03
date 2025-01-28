using UnityEngine;

public class StageInfoScript : MonoBehaviour
{
    private EtriggerPlayer2Script eTriggerPlayer2Script = null;
    [SerializeField] private string SceneName;
    private bool eggEnter = false;
    private bool pEnter = false;
    private GameObject player = null;
    public WhichStageScript.WhichStage myStage;
    void OnTriggerEnter(Collider t)
    {
        if (t.tag == "Egg")
        {
            eggEnter = true;
            if (pEnter)
            {
                if(player != null)
                {
                    if (WhichStageScript.stage != myStage)
                    {
                        eTriggerPlayer2Script = player.gameObject.GetComponent<EtriggerPlayer2Script>();
                        eTriggerPlayer2Script.flg = true;
                        eTriggerPlayer2Script.SceneName = SceneName;
                    }
                } 
            }
        }
        if (t.tag == "Player")
        {
            player = t.gameObject;
            pEnter = true;
            if (eggEnter)
            {
                if(WhichStageScript.stage != myStage)
                {
                    eTriggerPlayer2Script = player.gameObject.GetComponent<EtriggerPlayer2Script>();
                    eTriggerPlayer2Script.flg = true;
                    eTriggerPlayer2Script.SceneName = SceneName;
                }
            }
        }
    }

    private void OnTriggerExit(Collider t)
    {
        if (t.tag == "Egg")
        {
            eggEnter = false;
            Debug.Log("EggExit");
            if (eTriggerPlayer2Script != null)
            {
                eTriggerPlayer2Script.flg = false;
            }
        }
        if (t.tag == "Player")
        {
            pEnter = false;
            if (eTriggerPlayer2Script != null)
            {
                eTriggerPlayer2Script.flg = false;
            }
        }
    }



}
