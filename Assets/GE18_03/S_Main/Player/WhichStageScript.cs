using UnityEngine;
using UnityEngine.SceneManagement;

public class WhichStageScript : MonoBehaviour
{
    public enum WhichStage
    {
        Tutorial,
        Stage1,
        Stage2,
        Stage3
    }

    public static Vector3 SavedPos;

    public static WhichStage stage = WhichStage.Stage3;

    private void Start()
    {
        if(stage != WhichStage.Tutorial && SceneManager.GetActiveScene().name == "MainScene")
        {
            transform.position = SavedPos;
        }
    }
}
