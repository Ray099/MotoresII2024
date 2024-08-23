using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("tickTickBoom", 3);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Destroy(bullet);
    }
    void tickTickBoom()
    {
        Destroy(bullet);
    }
}
