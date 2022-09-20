using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 100f;
    public GameObject cam = null;
    private CharacterController cController;
    private Vector3 moveDir = Vector3.zero;

    private void Start()
    {
        cController = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        // vertical > 0 일때 따라가게

        moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

        if (moveDir.magnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(cam.transform.forward * rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
        }



        cController.Move(moveDir * speed * Time.deltaTime);
    }
}