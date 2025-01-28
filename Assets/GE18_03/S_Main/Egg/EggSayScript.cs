using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class EggSayScript : MonoBehaviour
{
    public BoxCollider BoxCollider;
    public TMP_Text text;
    private Coroutine _showCoroutine;
    public float wait = 0.2f;
    public EggSplineScript eggSplineScript;
    private AudioSource audioSource;
    [SerializeField] private AudioClip sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        text.maxVisibleCharacters = 0;
    }

    void OnTriggerEnter(Collider t)
    {
        if(t.gameObject.tag == "Player")
        {
            switch (WhichStageScript.stage)
            {
              case WhichStageScript.WhichStage.Tutorial:
                    {
                        string message = "卵＜卵が食べたい。取ってきてくれ。";
                        text.text = message;

                    }
                    break;
                case WhichStageScript.WhichStage.Stage1:
                    {
                        string message = "卵＜まだ足りない。";
                        text.text = message;
                    }
                    break;
                    case WhichStageScript.WhichStage.Stage2:
                    {
                        string message = "卵＜..............。";
                        text.text = message;
                    }
                    break;
                case WhichStageScript.WhichStage.Stage3:
                    {
                        string message = "卵＜%'$)#()&#&($%)%$()$($#)%($)(%)%&%${|$#{$*%~$|#&*$|$%&*~|%*'|%%$&";
                        text.text = message;
                    }
                    break;
            }
            show();
        }
    }

    public void show()
    {
        if(_showCoroutine == null)
        {
            _showCoroutine = StartCoroutine(Simple());
        }
    }

    private IEnumerator Simple()
    {
        text.maxVisibleCharacters = 0;

        for(var i = 0; i < text.text.Length; i++)
        {
            audioSource.PlayOneShot(sound);
            yield return new WaitForSeconds(wait);

            text.maxVisibleCharacters = i + 1;
        }
        eggSplineScript.flg = true;
    }
}
