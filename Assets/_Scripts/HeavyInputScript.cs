using UnityEngine;
using UnityEngine.InputSystem;
public class HeavyInputScript : MonoBehaviour
{
    //Input system stuff
    PlayerInput PlayerInput;
    InputAction HeavyMovementActions;

    Vector3 forceDirection = Vector3.zero;

    //player stuff
    Rigidbody rb;
    Collider playerCollider;

    //ground detection
    [SerializeField] float distancToGround = 1f;
    [SerializeField] LayerMask groundMask;
    [SerializeField] bool isGrounded;



    RaycastHit hit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PlayerInput = GetComponent<PlayerInput>();
        HeavyMovementActions = PlayerInput.actions.FindAction("Basic Movement");
    }
    
    public void MoveControl()
    {
        //Vector3 moveDirection = new Vector3(PlayerInput.actions["Movement"].ReadValue<Vector3>().x, 0, PlayerInput.actions["Movement"].ReadValue<Vector3>().z);

        Vector2 MoveDirection = HeavyMovementActions.ReadValue<Vector2>();
        rb.AddForce(new Vector2(MoveDirection.x, MoveDirection.y) * 20, ForceMode.Acceleration);
    }




    public void Jump()
    {
        int jumps = 1;
        if (isGrounded && jumps == 1)
        {
            rb.AddForce(Vector3.up * 2, ForceMode.VelocityChange);
        }
    }


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, out hit, distancToGround, groundMask);
        Debug.Log(isGrounded);

    }
}
