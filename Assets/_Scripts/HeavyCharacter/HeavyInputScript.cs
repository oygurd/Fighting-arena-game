using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.Rendering;
public class HeavyInputScript : MonoBehaviour
{
    //Input system stuff
    PlayerInput playerInput;
    PlayerActions playerActions;
    public InputActionReference move;

    Vector3 forceDirection = Vector3.zero;
    //player stuff
    Rigidbody rb;
    Collider playerCollider;

    [Header("Camera Properties")]
    [SerializeField] Camera playerCamera;
    [SerializeField] GameObject cameraLookAtEmpty;
    Vector2 playerCamRot;

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
        cameraLookAtEmpty = GameObject.FindWithTag("PlayerToCamRotator");

        canDash = true;
        rb = GetComponent<Rigidbody>();

        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        playerInput = GetComponent<PlayerInput>(); // reference the player input on the character
        playerActions = GetComponent<PlayerActions>();

    }



    public void OnMovement()//when pressing forward, move player to where the camera aims
    {
        //drag
        rb.linearDamping = 2f;



        //movement



        Vector2 Movedirection = move.action.ReadValue<Vector2>().normalized;
        forceDirection = new Vector3(Movedirection.x, 0, Movedirection.y);
        // transform.Rotate(transform.localRotation.x, forceDirection.y, transform.localRotation.z);
        //rb.AddForce(forceDirection * speed, ForceMode.Acceleration);
        rb.AddForce(new Vector3(forceDirection.x, 0, forceDirection.z) * speed, ForceMode.Acceleration);

        if (move.action.ReadValue<Vector2>().y > 0.1f)
        {
            transform.Rotate(new Vector3(0, playerCamRot.y, 0) * Time.deltaTime * 10);
            

            transform.rotation = Quaternion.Euler(transform.localEulerAngles.x, playerCamera.transform.rotation.y, transform.localEulerAngles.z);

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
        playerCamRot = cameraValue.Get<Vector2>();
        
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
