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
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
}
