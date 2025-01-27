using UnityEditor;
using UnityEngine;

public class ChangeCameraScript : MonoBehaviour
{
    public GameObject firstCamera;
    public GameObject secondCamera;
    public GameObject thirdCamera;
    public GameObject fourthCamera;
    public GameObject fifthCamera;
    public GameObject egg;
    public GameObject eggMen;
    public bool flg1 = false;
    public bool flg2 = false;
    public bool flg3 = false;
    public float biggerAmount1 = 1.0f;
    public float biggerAmount2 = 1.0f;
    public float biggerAmount3 = 1.0f;


    private void Start()
    {
        firstCamera.SetActive(true);
        secondCamera.SetActive(false);
        thirdCamera.SetActive(false);
        fourthCamera.SetActive(false);
        fifthCamera.SetActive(false);

}

    public void CameraChengeda(int CameraNum)
    {
        switch (CameraNum)
        {
            case 1:
                firstCamera.SetActive(true);
                secondCamera.SetActive(false);
                thirdCamera.SetActive(false);
                fourthCamera.SetActive(false);
                fifthCamera.SetActive(false);
                break;
            case 2:
                firstCamera.SetActive(false);
                secondCamera.SetActive(true);
                thirdCamera.SetActive(false);
                fourthCamera.SetActive(false);
                fifthCamera.SetActive(false);
                break;
            case 3:
                firstCamera.SetActive(false);
                secondCamera.SetActive(false);
                thirdCamera.SetActive(true);
                fourthCamera.SetActive(false);
                fifthCamera.SetActive(false);
                break;
            case 4:
                firstCamera.SetActive(false);
                secondCamera.SetActive(false);
                thirdCamera.SetActive(false);
                fourthCamera.SetActive(true);
                fifthCamera.SetActive(false);
                break;
            case 5:
                firstCamera.SetActive(false);
                secondCamera.SetActive(false);
                thirdCamera.SetActive(false);
                fourthCamera.SetActive(false);
                fifthCamera.SetActive(true);
                break;
        }
    }

    public void DestroyEgg()
    {
        Destroy(egg);
    }
    public void StartBig(int num)
    {
        if (num == 1) 
        {
            flg1 = true;
        }
        else if(num == 2)
        {
            flg1 = false;
            flg2 = true;
        }
        else if (num == 3)
        {
            flg3 = true;
        }

    }

    public void BigWarp()
    {
        flg1 = false;
        eggMen.transform.localScale = new Vector3(1800,1800,1800);
    }

    public void FixedUpdate()
    {
        if (flg1)
        {
            Vector3 tmp = eggMen.transform.localScale;
            eggMen.transform.localScale = new Vector3(tmp.x + biggerAmount1, tmp.y + biggerAmount1, tmp.z + biggerAmount1);
        }
        if(flg2)
        {
            Vector3 tmp = eggMen.transform.localScale;
            eggMen.transform.localScale = new Vector3(tmp.x + biggerAmount2, tmp.y + biggerAmount2, tmp.z + biggerAmount2);
        }
        if (flg3)
        {
            Vector3 tmp = eggMen.transform.localScale;
            eggMen.transform.localScale = new Vector3(tmp.x + biggerAmount3, tmp.y + biggerAmount3, tmp.z + biggerAmount3);
        }
    }
}
