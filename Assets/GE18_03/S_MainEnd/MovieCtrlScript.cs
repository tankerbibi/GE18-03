using NUnit.Framework.Constraints;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovieCtrlScript : MonoBehaviour
{
    private ChangeCameraScript changeCameraScript;
    private void Start()
    {
        changeCameraScript = GetComponent<ChangeCameraScript>();
        StartCoroutine(PlayMovie());
    }

    private IEnumerator PlayMovie()
    {
        yield return new WaitForSeconds(1.5f);
        changeCameraScript.CameraChengeda(2);
        yield return new WaitForSeconds(2);
        changeCameraScript.DestroyEgg();
        yield return new WaitForSeconds(0.4f);
        changeCameraScript.StartBig(1);
        yield return new WaitForSeconds(0.5f);
        changeCameraScript.StartBig(2);
        yield return new WaitForSeconds(0.5f);
        changeCameraScript.CameraChengeda(3);
        yield return new WaitForSeconds(5f);
        changeCameraScript.BigWarp();
        changeCameraScript.CameraChengeda(4);
        yield return new WaitForSeconds(3f);
        changeCameraScript.StartBig(1);
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("EndScene");


    }
}
