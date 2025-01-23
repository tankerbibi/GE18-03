using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.LookDev;
using UnityEngine.SceneManagement;

public class EtriggerPlayerScript : MonoBehaviour
{
    public bool flg = false;

    public void OnInterrupt(InputAction.CallbackContext context)
    {
        if (context.started && flg)
        {
            WhichStageScript.stage = WhichStageScript.WhichStage.Stage2;
            SceneManager.LoadScene("MainScene");
        }
    }
}
