using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject player = null;
    public float rotationSpeed = 10f;
    Vector3 rotationDir = Vector3.zero;
    Vector3 rotateTarget = Vector3.zero;

    private void FixedUpdate()
    {
        transform.position = player.transform.position;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateTarget.x += mouseX;
        rotateTarget.y -= mouseY;

        mouseY = Mathf.Clamp(mouseY, -120f, 55f);


        transform.Rotate(Vector3.up, mouseX * 3, Space.World);
        transform.Rotate(Vector3.right, -mouseY * 1.5f);

        //rotationDir = Quaternion.Euler(0, transform.eulerAngles.y, 0) * rotationDir;


        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(rotationDir), Time.deltaTime);
    }
}

/*
float x = Input.GetAxis("Mouse Y");
float y = Input.GetAxis("Mouse X");

rotX += x * rotationSpeed * Time.deltaTime;
rotY += y * rotationSpeed * Time.deltaTime; 

rotX = Mathf.Clamp(rotX, -55f, 120f);
transform.rotation = Quaternion.Euler(-rotX, transform.rotation.y, 0);
*/