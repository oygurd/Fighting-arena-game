using UnityEngine;


public class AnimationsHandler : MonoBehaviour
{
    [SerializeField] Animator HeavyAnimator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HeavyAnimator = GetComponentInChildren<Animator>();
    }

    //Movement animations
    public void Idle()
    {
        HeavyAnimator.SetBool("ForwardWalk", false);
        HeavyAnimator.SetBool("BackWalk", false);
        HeavyAnimator.SetBool("isIdle", true);
    }

    public void Jump()
    {
        HeavyAnimator.SetBool("Jump", true);
        HeavyAnimator.SetBool("isIdle", false);
    }

    public void ForwardWalk()
    {
        HeavyAnimator.SetBool("ForwardWalk", true);
        HeavyAnimator.SetBool("isIdle", false);
    }

    public void BackWalk()
    {
        HeavyAnimator.SetBool("BackWalk", true);
        HeavyAnimator.SetBool("isIdle", false);
    }

    public void WalkRight()
    {
        HeavyAnimator.SetBool("WalkRight", true);
        HeavyAnimator.SetBool("isIdle", false);
    }

    public void WalkLeft()
    {
        HeavyAnimator.SetBool("WalkLeft", true);
        HeavyAnimator.SetBool("isIdle", false);
    }





    // Update is called once per frame
    void Update()
    {

    }
}
