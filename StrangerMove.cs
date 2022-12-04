using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangerMove : MonoBehaviour
{
    public float Speed = 0.5f;
    public float rotateSpeed = 0.5f;
    private float time;

    public GameObject Yesfield;
    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        time += Time.deltaTime;
        float h = 2, v = 3;
        if (time > 5)
        {
            h = Random.Range(-36, 36);
            //v = Random.Range(-40, 40);
            
            time = 0.0f;
        }

        transform.Translate(Vector3.forward * Speed * v * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateSpeed * h);
    }

    void OnTriggerExit(Collider other)
    {

        if (other.transform.tag == "field")
        {

            transform.position = Vector3.MoveTowards(gameObject.transform.position, Yesfield.transform.position, 0.005f);

        }


    }
}
