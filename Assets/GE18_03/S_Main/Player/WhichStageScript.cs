using UnityEngine;

public class WhichStageScript : MonoBehaviour
{
    public enum WhichStage
    {
        Tutorial,
        Stage1,
        Stage2,
        Stage3
    }

    public static WhichStage stage = WhichStage.Tutorial;
}
