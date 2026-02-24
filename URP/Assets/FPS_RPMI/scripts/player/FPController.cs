using UnityEngine;
using UnityEngine.InputSystem;

public class FPController : MonoBehaviour
{
    #region General Variables

    [Header("Movement & Look")]
    [SerializeField] GameObject camHolder;
    [SerializeField] float speed = 5f;
    [SerializeField] float crouchSpeed = 3f;
    [SerializeField] float sprintSpeed = 8f;
    [SerializeField] float MaxForce = 1f;
    [SerializeField] float sensitivy = 0.1f;


    [Header("Player stats bools")]

    [SerializeField] bool isSprinting;
    [SerializeField] bool isCrouching;

    #endregion

    Rigidbody rb;

    Vector2 moveInput;
    Vector2 lookInput;

    float lookRotation;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Input Methods
    public void Onmove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

    }





    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();

    }
    public void OnJump(InputAction.CallbackContext context)
    {


    }
    public void OnCroach(InputAction.CallbackContext context)
    {


    }
    public void OnSprint(InputAction.CallbackContext context)
    {


    }
    #endregion
}
