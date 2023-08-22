using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    //public float RotationSpeed = 1f;
    public Transform targetplayer;
    public Vector3 cameraOffset;

    [Range (0.1f,1.0f)]
    public float smooth = 0.5f;
    public bool LookAtTarget = false;

    public bool rotateAroundPlayer=true;
    public float rotationSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetplayer.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (rotateAroundPlayer)
        {
            Quaternion camRotate = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);

            cameraOffset = camRotate * cameraOffset;

        }



        Vector3 newposition = targetplayer.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newposition, smooth);

        if (LookAtTarget || rotateAroundPlayer)
        {
            transform.LookAt(targetplayer);
        }

        //camControl();
    }

    //void camControl()
    //{
    //    mouseX = Input.GetAxis("Mouse X") * RotationSpeed;
    //    mouseY = Input.GetAxis("Mouse Y") * RotationSpeed;

    //    mouseY = Mathf.Clamp(mouseY, -35, 60);

    //    transform.LookAt(target);

    //    target.rotation = Quaternion.Euler(mouseX, mouseY, 0);
    //    player.rotation = Quaternion.Euler(0, mouseX, 0);
    //}
}
