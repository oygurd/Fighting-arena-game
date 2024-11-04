using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.Rendering;
using Unity.Entities;
public class HeavyInputScript : MonoBehaviour
{
    //Input system stuff
    PlayerInput playerInput;
    PlayerActions playerActions;
    public InputActionReference move;

    Vector3 forceDirection;
    //player stuff
    Rigidbody rb;
    Collider playerCollider;

    [Header("Camera Properties")]
    [SerializeField] Camera playerCamera;
    [SerializeField] GameObject cameraLookAtEmpty;
    Vector3 camForceDirection;

    //public parameters
    [Header("Speed properties")]
    [SerializeField] float speed;

    [Header("Jump properties")]
    [SerializeField] float jumpForce;

    [Header("Dash properties")]
    [SerializeField] bool canDash;
    [SerializeField] float dashForce;
    [SerializeField] float dashCD;
    //ground detection
    [SerializeField] float distancToGround;
    [SerializeField] LayerMask groundMask;
    [SerializeField] bool isGrounded;



    RaycastHit hit;

    private void OnEnable()
    {

    }
    private void OnDisable()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        //Vector3 playerCamPivot = 
        //playerCamRot = GameObject.FindWithTag("PlayerToCamRotator");
        cameraLookAtEmpty = GameObject.FindWithTag("PlayerToCamRotator");

        canDash = true;
        rb = GetComponent<Rigidbody>();

        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        playerInput = GetComponent<PlayerInput>(); // reference the player input on the character
        playerActions = GetComponent<PlayerActions>();

    }



    public void OnMovement()//when pressing forward, move player to where the camera aims
    {
        //drag
        rb.linearDamping = 2f;

        //movement

        Vector2 Movedirection = move.action.ReadValue<Vector2>();

        Vector3 camForward = playerCamera.transform.forward;
        Vector3 camRight = playerCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;
        camForceDirection = camForward;


        Vector3 correctDirectionX = Movedirection.x * transform.right;
        Vector3 correctDirectionZ = Movedirection.y * transform.forward;



        //forceDirection = new Vector3(Movedirection.x, rb.position.y, Movedirection.y);
        forceDirection = correctDirectionX + correctDirectionZ;
        rb.AddForce(forceDirection * speed, ForceMode.Acceleration);
        //transform.localRotation = Quaternion.LookRotation(Movedirection, Vector3.up);
        


        if (move.action.ReadValue<Vector2>().y > 0.1f)
        {
            transform.localRotation = Quaternion.LookRotation(camForward * Time.smoothDeltaTime, Vector3.up);
            rb.AddForce(camForceDirection , ForceMode.Acceleration);

        }




    }

    public void OnJump(InputValue jumpValue)
    {
        if (isGrounded && jumpValue.isPressed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    public void OnDash(InputValue dashValue)
    {
        if (dashValue.isPressed && canDash)
        {
            rb.AddForce(forceDirection * dashForce, ForceMode.Impulse);
            canDash = false;

            StartCoroutine(DashCDHandler());
        }
    }


    public void OnCamera(InputValue cameraValue)
    {
        // playerCamRot = cameraValue.Get<Vector2>();

    }

    IEnumerator DashCDHandler()
    {
        yield return new WaitForSeconds(dashCD);
        canDash = true;
    }



    private void FixedUpdate()
    {
        //call physics inputs
        OnMovement();

        cameraLookAtEmpty.transform.position = transform.position;

        cameraLookAtEmpty.transform.rotation = Quaternion.Euler(cameraLookAtEmpty.transform.localEulerAngles.x, playerCamera.transform.localEulerAngles.y, cameraLookAtEmpty.transform.localEulerAngles.z);



    }





    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.Raycast(transform.position, Vector3.down, out hit, distancToGround, groundMask);
        if (!isGrounded)
        {
            rb.linearDamping = 1f;
        }

        Debug.Log(isGrounded);
        Debug.Log(move.action.ReadValue<Vector2>());
    }
}
