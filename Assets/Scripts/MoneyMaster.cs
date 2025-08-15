using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyMaster : MonoBehaviour
{
    private static MoneyMaster _instance;

    public static MoneyMaster instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<MoneyMaster>();
            }
            return _instance;
        }
    }

    public void SpawnCoin()
    {
        object[] parameters = new object[1];
        parameters[0] = "LOADS OF MONEY";
        EventManager.m_Instance.InvokeEvent<KachingEvent>(new KachingEvent(parameters));
    }
}
