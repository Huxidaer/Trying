using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Cowboy_AnimatiorController:MonoBehaviour
{
    private Animator animator;

    // 如果你忘了在检视面板里拖引用，会自动尝试在当前对象上找 Animator
    private void Awake()
    {
      animator = GetComponent<Animator>();
    }

    private void Update()
    {
        CastRod();
        Run();
        Fall();
        Back();

    }
    private void Back()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            animator.SetTrigger("Back");
        }
    }private void Fall()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {

            animator.SetTrigger("Fall");
        }
    }
    private void Run()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
        
            animator.SetTrigger("GoStraigt");
        }
    }
    private void CastRod()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
         
            animator.SetTrigger("Cast");
        }
    }
}
