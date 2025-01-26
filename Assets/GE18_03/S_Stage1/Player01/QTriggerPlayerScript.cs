using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class QTriggerPlayerScript : MonoBehaviour
{
    [SerializeField]private ButtonDataScript buttonDataScript;
    [SerializeField]private LeverMoveScript leverMoveScript1;
    [SerializeField]private LeverMoveScript leverMoveScript2;
    public void OnQInterrupt(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            buttonDataScript.ActivateButton();
            leverMoveScript1.LeverMove();
            leverMoveScript2.LeverMove();
        }
    }
}
