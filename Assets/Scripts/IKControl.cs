using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class IKControl : MonoBehaviour {

    protected Animator animator;
    public Transform rightVRController;
    public Transform leftVRController;
    public Transform vrCamera;


    void Start ()
    {
        animator = GetComponent<Animator>();
    }

    //a callback for calculating IK
    void OnAnimatorIK()
    {
        float reachR = animator.GetFloat("PlayerRightHand");
       animator.SetIKPositionWeight(AvatarIKGoal.RightHand, reachR);
       animator.SetIKPosition(AvatarIKGoal.RightHand, rightVRController.position);

       float reachL = animator.GetFloat("PlayerLeftHand");
       animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, reachL);
       animator.SetIKPosition(AvatarIKGoal.LeftHand, leftVRController.position);

       //camera moves with head butt only forwared
       animator.SetLookAtWeight(1f);
       animator.SetLookAtPosition(vrCamera.position + vrCamera.forward * 10f);

       //animator.SetFloat("PlayerHead", Mathf.Lerp(0,1,(vrCamera.position.y-crou)));

       //Hand rotation
       Quaternion angleOffset = Quaternion.Euler(0, 0, 0);
       animator.SetIKRotation(AvatarIKGoal.RightHand, rightVRController.rotation * angleOffset);
       animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
       animator.SetIKRotation(AvatarIKGoal.LeftHand, leftVRController.rotation * angleOffset);
       animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);

    }    
}