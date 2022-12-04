using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    public int stnum = 0;
    public ShowN ShowN;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stnum >= 10)
        {
            ShowN.Show();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if (hit.collider.gameObject.tag == "Stranger")
                {
                    animator.SetBool("attacking", true);
                    Destroy(hit.collider.gameObject);
                    animator.SetBool("attacking", false);
                    stnum += 1;
                }
            }
        }

    }
}
