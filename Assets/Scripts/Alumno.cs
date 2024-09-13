using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alumno : MonoBehaviour
{
    // Start is called before the first frame update

    public Image imagen;
    void Start()
    {
        imagen = GetComponent<Image>();
        EventManager.m_Instance.AddListener<NoLlegoElProfeEvent>(MeVoyACasa);
    }

    // Update is called once per frame
    private void MeVoyACasa(NoLlegoElProfeEvent _event)
    {
        object[] parameters = _event.GetParameters();
        Debug.Log("Me voy a casa por que  no llego el profe de "+ parameters[0]);
        imagen.color = (Color)parameters[1];
    }
}
