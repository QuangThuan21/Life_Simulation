using UnityEngine;
using UnityEngine.UI;

public class CharacterBehaviour : MonoBehaviour
{
    /*[SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;

    private Animator animator;
    private CharacterController characterController;
    private float ySpeed;
    private float originalStepOffset;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (movementDirection != Vector3.zero)
        {
            
            animator.SetBool("isRunning", true);

            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            
                animator.SetBool("isRunning", false);
        }


            Vector3 velocity = movementDirection * speed;
            velocity.y = ySpeed;

            characterController.Move(velocity * Time.deltaTime);

    
    }*/
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

        // Di chuyển theo hướng trước hoặc sau
        Vector3 moveDirection = transform.forward * verticalInput;

        // Quay nhân vật
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        // Kiểm tra nút mũi tên lên hoặc xuống được nhấn để di chuyển theo hướng tương ứng
        if (verticalInput != 0)
        {
            //characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
            //transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        }
    }
}