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
        yield return new WaitForSeconds(2f);

        changeCameraScript.CameraChengeda(2);
        yield return new WaitForSeconds(3);
        changeCameraScript.PlaySound();
        changeCameraScript.DestroyEgg();
        yield return new WaitForSeconds(1);

        changeCameraScript.CameraChengeda(3);
        yield return new WaitForSeconds(4);
        changeCameraScript.StartBig(1);
        yield return new WaitForSeconds(2);

        changeCameraScript.CameraChengeda(4);
        yield return new WaitForSeconds(2);
        changeCameraScript.StartBig(2);
        yield return new WaitForSeconds(3);
        changeCameraScript.BigWarp();

        changeCameraScript.CameraChengeda(5);
        changeCameraScript.PlayNoize();
        yield return new WaitForSeconds(3f);
        changeCameraScript.StartBig(3);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("EndScene");


    }
}
