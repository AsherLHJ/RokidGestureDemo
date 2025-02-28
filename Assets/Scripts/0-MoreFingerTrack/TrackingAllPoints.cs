using Rokid.UXR.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingAllPoints : MonoBehaviour
{
    public GameObject hanPointsTrackObj;

    private GameObject thumb_tip, index_finger_tip, middle_finger_tip, ring_finger_tip, pinky_tip;
    private GameObject thumb_cmc, plam, metacarpal_index, metacarpel_middle, metacarpel_ring, metacarpel_pinky;

    void Start()
    {
        thumb_tip = Instantiate(hanPointsTrackObj);
        index_finger_tip = Instantiate(hanPointsTrackObj);
        middle_finger_tip = Instantiate(hanPointsTrackObj);
        ring_finger_tip = Instantiate(hanPointsTrackObj);
        pinky_tip = Instantiate(hanPointsTrackObj);
        thumb_cmc = Instantiate(hanPointsTrackObj);
        plam = Instantiate(hanPointsTrackObj);
        metacarpal_index = Instantiate(hanPointsTrackObj);
        metacarpel_middle = Instantiate(hanPointsTrackObj);
        metacarpel_ring = Instantiate(hanPointsTrackObj);
        metacarpel_pinky = Instantiate(hanPointsTrackObj);
    }

    void Update()
    {
        thumb_tip.transform.position = GetSkeletonPose(SkeletonIndexFlag.THUMB_TIP, HandType.RightHand).position;
        index_finger_tip.transform.position = GetSkeletonPose(SkeletonIndexFlag.INDEX_FINGER_TIP, HandType.RightHand).position;
        middle_finger_tip.transform.position = GetSkeletonPose(SkeletonIndexFlag.MIDDLE_FINGER_TIP, HandType.RightHand).position;
        ring_finger_tip.transform.position = GetSkeletonPose(SkeletonIndexFlag.RING_FINGER_TIP, HandType.RightHand).position;
        pinky_tip.transform.position = GetSkeletonPose(SkeletonIndexFlag.PINKY_TIP, HandType.RightHand).position;
        thumb_cmc.transform.position = GetSkeletonPose(SkeletonIndexFlag.THUMB_CMC, HandType.RightHand).position;
        plam.transform.position = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_INDEX, HandType.RightHand).position;
        metacarpal_index.transform.position = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_MIDDLE, HandType.RightHand).position;
        metacarpel_middle.transform.position = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_RING, HandType.RightHand).position;
        metacarpel_ring.transform.position = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_PINKY, HandType.RightHand).position;
        metacarpel_pinky.transform.position = GetSkeletonPose(SkeletonIndexFlag.PALM, HandType.RightHand).position;

        thumb_tip.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.THUMB_TIP, HandType.RightHand).rotation;
        index_finger_tip.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.INDEX_FINGER_TIP, HandType.RightHand).rotation;
        middle_finger_tip.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.MIDDLE_FINGER_TIP, HandType.RightHand).rotation;
        ring_finger_tip.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.RING_FINGER_TIP, HandType.RightHand).rotation;
        pinky_tip.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.PINKY_TIP, HandType.RightHand).rotation;
        thumb_cmc.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.THUMB_CMC, HandType.RightHand).rotation;
        plam.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_INDEX, HandType.RightHand).rotation;
        metacarpal_index.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_MIDDLE, HandType.RightHand).rotation;
        metacarpel_middle.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_RING, HandType.RightHand).rotation;
        metacarpel_ring.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.METACARPAL_PINKY, HandType.RightHand).rotation;
        metacarpel_pinky.transform.rotation = GetSkeletonPose(SkeletonIndexFlag.PALM, HandType.RightHand).rotation;
    }

    private Pose GetSkeletonPose(SkeletonIndexFlag index, HandType hand)
    {
        return GesEventInput.Instance.GetSkeletonPose(index, hand);
    }
}
