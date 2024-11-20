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
        HeavyAnimator.SetBool("Idle", true);
        HeavyAnimator.SetBool("BackWalk", false);
        HeavyAnimator.SetBool("ForwardWalk", false);
    }

    public void Jump()
    {
        HeavyAnimator.SetBool("Jump",true);
        HeavyAnimator.SetBool("Idle", false);

    }

    public void ForwardWalk()
    {
        HeavyAnimator.SetBool("ForwardWalk", true);
        HeavyAnimator.SetBool("BackWalk", false);
        HeavyAnimator.SetBool("Idle", false);
    }

    public void BackWalk()
    {
        HeavyAnimator.SetBool("BackWalk", true);
        HeavyAnimator.SetBool("ForwardWalk", false);
        HeavyAnimator.SetBool("Idle", false);
    }

    public void WalkRight()
    {
        HeavyAnimator.Play("WalkingRight");
    }

    public void WalkLeft()
    {
        HeavyAnimator.Play("WalkingLeft");
    }

    //attack animations

   public void Jab()
    {
        HeavyAnimator.SetBool("Jab",true);
    }




    // Update is called once per frame
    void Update()
    {

    }
}
