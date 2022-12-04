using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowS : MonoBehaviour
{
    private void Awake()
    {
        transform.gameObject.SetActive(false);
    }

    public void Show()
    {
        transform.gameObject.SetActive(true);
    }
}
