using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;
    private Animator animator;

    private CharacterController characterController;

    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (verticalInput != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        Vector3 moveDirection = transform.forward * verticalInput;

        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        if (verticalInput != 0)
        {
            transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        }
    }
}
