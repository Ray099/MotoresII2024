using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KachingObject : MonoBehaviour
{ 
    
    public GameObject coinPrefab;
    public Transform coinSlot;

    void Start()
    {

        EventManager.m_Instance.AddListener<KachingEvent>(ObjKaching);
    }

    private void ObjKaching(KachingEvent _event)
    {
        Coin newCoin = null;
        float turn = Input.GetAxis("Horizontal");
        PoolManager.Instance.SpawnObject<Coin>(out newCoin, coinPrefab, coinSlot.position, coinSlot.rotation, PoolManager.PoolType.GameObjects);
        newCoin.GetComponent<Rigidbody>().AddTorque(coinSlot.transform.right * 150000000.0f);
        object[] parameters = _event.GetParameters();
        Debug.Log("$$$" + parameters[0]);
    
    }
}
