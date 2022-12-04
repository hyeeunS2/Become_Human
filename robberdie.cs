using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robberdie : MonoBehaviour
{
    public ShowS ShowS;
    public int num = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (num >= 10)
        {
            ShowS.Show();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.collider.gameObject.tag == "robber")
                {
                    num += 1;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}

