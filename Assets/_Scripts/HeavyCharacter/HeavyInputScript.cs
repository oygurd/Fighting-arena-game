using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.Rendering;
using Unity.Entities;
using Cinemachine.Utility;
using System.Linq;
using Unity.Mathematics;
using Unity.Core;
public class HeavyInputScript : MonoBehaviour
{
    [SerializeField] AnimationsHandler animationsHandler;

    //Input system stuff
    PlayerInput playerInput;
    PlayerActions playerActions;
    InputAction playerInputAction;
    public InputActionReference move;

    Vector3 camForward;
    quaternion camRotation;


    Vector3 forceDirection;
    //player stuff
    Rigidbody rb;
    Collider playerCollider;


    Vector2 Movedirection;
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
        cameraLookAtEmpty = GameObject.FindWithTag("PlayerToCamRotator");

        canDash = true;
        rb = GetComponent<Rigidbody>();

        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;//| RigidbodyConstraints.FreezeRotationY;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        playerInput = GetComponent<PlayerInput>(); // reference the player input on the character
        playerActions = GetComponent<PlayerActions>();

    }


    private InputAction GetWKeyAction()
    {
        InputActionAsset asset = Resources.Load<InputActionAsset>("Playerctions");
        InputActionMap map = asset.FindActionMap("Movement");
        return map.FindAction("<Keyboard>/w\\");
    }


    public void OnMovement()//when pressing forward, move player to where the camera aims
    {

        //MoveCtx = move.action.ReadValue<InputAction.CallbackContext>();

        //MoveCtx = ctx;
        //drag
        rb.linearDamping = 2f;


        //movement
        Movedirection = move.action.ReadValue<Vector2>();

        // Movedirection.y = 0;
        //Movedirection.y = Mathf.Min(Movedirection.y, 0);

        camForward = playerCamera.transform.forward;
        Vector3 camRight = playerCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;
        camForceDirection = camForward;

        Vector3 correctDirectionX = Movedirection.x * transform.right;
        Vector3 correctDirectionZ = Movedirection.y * transform.forward;

        forceDirection = correctDirectionX + correctDirectionZ;



        rb.AddForce(forceDirection * speed, ForceMode.Acceleration);


        if(Movedirection.y == 0 && Movedirection.x == 0)
        {
            animationsHandler.Idle();
        }

        if (Movedirection.y > 0.1f)
        {
            animationsHandler.ForwardWalk();
        }




    }

    public void OnWOnly()
    {
        if (Movedirection.y > 0.1f)
        {

            //rb.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(camForward, Vector3.up), 20f * Time.fixedDeltaTime);

            rb.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(camForward * Time.fixedUnscaledDeltaTime * 15, Vector3.up), 0.1f);
            //transform.rotation = cameraLookAtEmpty.transform.rotation;

            //rb.rotation = Quaternion.Slerp(rb.rotation,camForward, 1f);
            // rb.MoveRotation(Quaternion.LookRotation(camForward * Time.deltaTime, Vector3.up));
            // rb.MoveRotation(Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(camForward, Vector3.up), 20 * Time.fixedDeltaTime));
            //rb.AddForce(camForceDirection * Time.deltaTime, ForceMode.Acceleration);
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

    public void OnWLeftclick(InputValue leftClickValue)
    {
        if (leftClickValue.isPressed)
        {
            //Debug.Log("W + L click works");
        }
    }




    private void LateUpdate()
    {

    }

    private void FixedUpdate()
    {
        //call physics inputs
        OnMovement();
        OnWOnly();


        cameraLookAtEmpty.transform.position = transform.position;

        // cameraLookAtEmpty.transform.rotation = Quaternion.Euler(cameraLookAtEmpty.transform.localEulerAngles.x, playerCamera.transform.localEulerAngles.y, cameraLookAtEmpty.transform.localEulerAngles.z);



    }





    // Update is called once per frame
    void Update()
    {

        //OnWOnly();
        /*if (Input.GetKeyDown(KeyCode.W))
        {
          //  rb.MoveRotation(Quaternion.LookRotation(camForward, Vector3.up));

            rb.AddForce(camForceDirection * Time.deltaTime, ForceMode.Acceleration);
        }*/
        isGrounded = Physics.Raycast(transform.position, Vector3.down, out hit, distancToGround, groundMask);
        if (!isGrounded)
        {
            rb.linearDamping = 1f;
        }

        Debug.Log(isGrounded);
        Debug.Log(move.action.ReadValue<Vector2>());

    }
}