using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGameScript : MonoBehaviour
{
    public void GotoMain()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void GotoTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void GotoFinish()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }
}
