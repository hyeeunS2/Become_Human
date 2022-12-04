using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Govillage : MonoBehaviour
{
    public ShowS ShowS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50.0f))
            {
                if (hit.collider.gameObject.tag == "village")
                {
                    ShowS.Show();
                }
            }
        }

    }
}
