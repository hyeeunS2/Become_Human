using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 5.0f;
    public float rotateSpeed = 2f;
    Animator animator;

    Rigidbody body;

    public static float h = 0, v = 0;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator= GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 dir = new Vector3(h, 0, v);
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Speed * v * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateSpeed * h);

        AnimationUpdate();

    }

    void AnimationUpdate()
    {
        if (h == 0 && v == 0)
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
        }
    }
    
}
