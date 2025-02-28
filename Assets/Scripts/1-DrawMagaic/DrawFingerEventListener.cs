using Rokid.UXR.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawFingerEventListener : MonoBehaviour
{
    // Debug Part
    public bool debugMode = false;
    public GameObject debugTextObj;
    public Text debugText;

    // Tracking Point
    private Vector3 palm, thumbTip, indexFingerTip, middleFingerTip, pinkyTip;

    // Pose Related
    public static bool ifPose;
    public static Vector3 drawPoint;

    void Start()
    {
        // Debug Part
        if(debugMode) debugTextObj.SetActive(true);
        else debugTextObj.SetActive(false);
    }

    void Update()
    {
        TrackingPoints();
        PoseJudgement();
        GetPoseDrawPoint();
    
        if(debugMode) DebugInfo();
    }

    // Tracking Points
    void TrackingPoints()
    {
        palm = GetSkeletonPose(SkeletonIndexFlag.PALM, HandType.RightHand).position;
        thumbTip = GetSkeletonPose(SkeletonIndexFlag.THUMB_TIP, HandType.RightHand).position;
        indexFingerTip = GetSkeletonPose(SkeletonIndexFlag.INDEX_FINGER_TIP, HandType.RightHand).position;
        middleFingerTip = GetSkeletonPose(SkeletonIndexFlag.MIDDLE_FINGER_TIP, HandType.RightHand).position;
        pinkyTip = GetSkeletonPose(SkeletonIndexFlag.PINKY_TIP, HandType.RightHand).position;
    }

    // Pose Judgement
    void PoseJudgement()
    {
        if (Vector3.Distance(palm, thumbTip) >= 0.06 && Vector3.Distance(palm, indexFingerTip) >= 0.06 &&
            Vector3.Distance(palm, middleFingerTip) >= 0.06 && Vector3.Distance(palm, pinkyTip) < 0.07)
            ifPose = true;
        else ifPose = false;
    }

    // Pose Draw Point
    void GetPoseDrawPoint()
    {
        if (ifPose) drawPoint = GetSkeletonPose(SkeletonIndexFlag.MIDDLE_FINGER_TIP, HandType.RightHand).position;
        else drawPoint = new Vector3(-100, -100, -100);
    }

    void DebugInfo()
    {
        debugText.text = Vector3.Distance(palm, thumbTip).ToString("F4");
        debugText.text += ("\n" + Vector3.Distance(palm, indexFingerTip).ToString("F4"));
        debugText.text += ("\n" + Vector3.Distance(palm, middleFingerTip).ToString("F4"));
        debugText.text += ("\n" + Vector3.Distance(palm, pinkyTip).ToString("F4"));
        debugText.text += ("\n" + ifPose.ToString());
    }

    private Pose GetSkeletonPose(SkeletonIndexFlag index, HandType hand)
    {
        return GesEventInput.Instance.GetSkeletonPose(index, hand);
    }
}
