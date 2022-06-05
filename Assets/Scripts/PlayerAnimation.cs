using UnityEngine.AI;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetComponent<NavMeshAgent>().velocity);
        if (GetComponent<NavMeshAgent>().velocity != Vector3.zero)
        {
            
            animator.SetBool("isRunning", true);
        } else animator.SetBool("isRunning", false);

    }
}
