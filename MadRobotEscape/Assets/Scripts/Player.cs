using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : MonoBehaviour
{
    public float MoveSpeed = 5;

    private PlayerController Controller;
    private GunController GunController;
    private Camera viewCamera;

    // Use this for initialization
    private void Start()
    {
        Controller = GetComponent<PlayerController>();
        GunController = GetComponent<GunController>();
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        // Movement input
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * MoveSpeed;
        Controller.Move(moveVelocity);
    }
}