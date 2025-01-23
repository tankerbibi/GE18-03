using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    public float time = 1.0f;
    private Vector3 velocity = Vector3.zero;
    public bool flg = false;
    private Vector3 initPos;
    private Vector3 targetPos;
    public EggMoveScript eggMoveScript;
    public float upY = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (WhichStageScript.stage)
        {
            case WhichStageScript.WhichStage.Tutorial:
                {
                    initPos = transform.position;
                    targetPos = stage1.position;
                }
                break;
            case WhichStageScript.WhichStage.Stage1:
                {
                    initPos = stage1.position;
                    targetPos = stage2.position;
                }
                break;
            case WhichStageScript.WhichStage.Stage2:
                {
                    initPos = stage2.position;
                    targetPos = stage3.position;
                }
                break;
            case WhichStageScript.WhichStage.Stage3:
                {
                    initPos = stage3.position;
                    targetPos = goal.position;
                }
                break;
        }
        transform.position = new Vector3(initPos.x, initPos.y + upY, initPos.z);
        eggMoveScript.initY = initPos.y + upY;

    }

    // Update is called once per frame
    void Update()
    {
        if (flg)
        {
            Vector3 tmp = Vector3.SmoothDamp(transform.position, new Vector3(targetPos.x,targetPos.y + upY, targetPos.z), ref velocity, time);
            transform.position = tmp;
            eggMoveScript.initY = tmp.y + upY;
        }
    }
}
