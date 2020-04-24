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
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.state == GameManager.StateType.PLAY)
        {
            axis = new Vector3(input.axis.x, 0, input.axis.y);
            forward = transform.forward;
            if (Mathf.Abs(Vector3.SignedAngle(axis, forward, Vector3.up)) < angle)
            {
                Vector3 direction = Player.instance.hmdTransform.TransformDirection(axis);
                //characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
                transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
            }
        }
    }
}
// - new Vector3(0, 9.81f, 0)