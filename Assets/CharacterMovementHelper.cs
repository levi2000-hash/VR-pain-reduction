using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovementHelper : MonoBehaviour
{
    // Start is called before the first frame update
    private XRRig xrrig;
    private CharacterController charController;
    private CharacterControllerDriver driver;
    void Start()
    {
        xrrig = GetComponent<XRRig>();
        charController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    protected virtual void UpdateCharacterController()
    {
        if (xrrig == null || charController == null)
            return;

        var height = Mathf.Clamp(xrrig.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = xrrig.CameraInOriginSpacePos;
        center.y = height / 2f + charController.skinWidth;

       charController.height = height;
       charController.center = center;
    }
}
