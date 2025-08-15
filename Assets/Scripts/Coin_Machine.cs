using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Machine : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform coinSlot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            MoneyMaster.instance.SpawnCoin();
    }
}