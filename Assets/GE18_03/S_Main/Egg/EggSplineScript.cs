using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;

public class EggSplineScript : MonoBehaviour
{
    public Transform Tutorial; //èâä˙à íu
    public Transform stage1;
    public Transform stage2;
    public Transform stage3;
    public Transform goal;
    private Vector3 targetPos;
    public float time = 1.0f;
    private Vector3 velocity = Vector3.zero;
    private Vector3 goalPos;
    public bool flg = false;
    public float yDuration = 1f;
    private float elapesed = 0f;
    private Vector3 initPos;
    public EggMoveScript eggMoveScript;
    public float upY = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initPos = transform.position;
        switch (WhichStageScript.stage)
        {
            case WhichStageScript.WhichStage.Tutorial:
                {
                    targetPos = stage1.position;
                }
                break;
            case WhichStageScript.WhichStage.Stage1:
                {
                    transform.position = new Vector3(stage1.position.x, stage1.position.y + upY, stage1.position.z);
                    targetPos = stage2.position;
                    eggMoveScript.initY = Tutorial.position.y + upY;
                }
                break;
            case WhichStageScript.WhichStage.Stage2:
                {
                    transform.position = new Vector3(stage2.position.x, stage2.position.y  + upY, stage2.position.z);
                    targetPos = stage3.position;
                    eggMoveScript.initY = stage2.position.y + upY;
                }
                break;
            case WhichStageScript.WhichStage.Stage3:
                {
                    transform.position = new Vector3(stage3.position.x, stage3.position.y + upY, stage3.position.z);
                    targetPos = goal.position;
                    eggMoveScript.initY = stage3.position.y + upY;
                }
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (flg)
        {
            elapesed += Time.deltaTime;
            float t = Mathf.Clamp01(elapesed / yDuration);
            eggMoveScript.initY = Vector3.Lerp(initPos, targetPos, t).y + upY;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, time);
        }
    }
}
