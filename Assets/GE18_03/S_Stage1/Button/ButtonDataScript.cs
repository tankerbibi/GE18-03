using UnityEngine;

public class ButtonDataScript : MonoBehaviour
{

    private ButtonMoveScript buttonMoveScript;
    [SerializeField]private LeverMoveScript leverMoveScriptTate;
    [SerializeField] private LeverMoveScript leverMoveScriptYoko;
    [SerializeField]private SelectBanMoveScript selectBanMoveScript;
    [SerializeField] private PlayerCheckScript playerCheckScript;
    void Start()
    {
        buttonMoveScript = GetComponent<ButtonMoveScript>();
    }

    public void ActivateButton()
    {
        if (playerCheckScript.flg)
        {
            buttonMoveScript.ChangeAppear();
            selectBanMoveScript.Push();
        }
    }
}
