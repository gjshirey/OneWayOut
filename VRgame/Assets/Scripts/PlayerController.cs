using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    public float angle = 5;
    Vector3 axis;
    Vector3 forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	axis = new Vector3(input.axis.x, 0, input.axis.y);
	forward = transform.forward;
	if (Mathf.Abs(Vector3.SignedAngle(axis, forward, Vector3.up)) < angle){
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(axis);
            transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
	}
    }
}
