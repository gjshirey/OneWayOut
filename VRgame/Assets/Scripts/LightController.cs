using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class LightController : MonoBehaviour
{
    public Light flashlight;
    public SteamVR_Action_Boolean trigger;
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.RightHand;
    // Start is called before the first frame update
    void Start()
    {
        trigger.AddOnStateDownListener(TriggerDown, inputSource);
        flashlight = GetComponent<Light>();
    }

    private void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        flashlight.enabled = !flashlight.enabled;
    }
}
