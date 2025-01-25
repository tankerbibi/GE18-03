using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.LookDev;
using UnityEngine.SceneManagement;

public class EtriggerPlayerScript : MonoBehaviour
{
    [System.NonSerialized]public bool flg = false;
    private string sceneName;
    
    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    public void OnInterrupt(InputAction.CallbackContext context)
    {
        if (context.started && flg)
        {
            switch (sceneName)
            {
                case "Stage1Scene":
                    WhichStageScript.stage = WhichStageScript.WhichStage.Stage1;
                    break;
                case "Stage2Scene":
                    WhichStageScript.stage = WhichStageScript.WhichStage.Stage2;
                    break;
                case "Stage3Scene":
                    WhichStageScript.stage = WhichStageScript.WhichStage.Stage3;
                    break;
            }
            SceneManager.LoadScene("MainScene");
        }
    }
}
