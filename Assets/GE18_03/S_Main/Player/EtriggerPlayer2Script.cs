using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EtriggerPlayer2Script : MonoBehaviour
{
    [System.NonSerialized] public bool flg = false;
    [System.NonSerialized] public string SceneName = null;
    public void OnInterrupt(InputAction.CallbackContext context)
    {
        if (context.started && flg)
        {
            if (SceneName != null)
            {
                WhichStageScript.SavedPos = transform.position;
                SceneManager.LoadScene(SceneName);
            }
        }
    }
}
