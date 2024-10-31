using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class wallet : MonoBehaviour
{
    /*Este script tiene como finalidad administrar la suma de puntos, "dinero", através de una wallet, mostrándola en tiempo real durante el gameplay en el margen
 derecho superior de la pantalla en "RewardText" y el resultado final en la pantalla última, en "RewardAchived", que saldría al terminar el tiempo, así como 
 llevar la serie de código para desactivar los objetivos clickados, seguramente el uso de tags facilitaría esta labor, de esta forma tendría de forma localizada 
 el conteo del dinero, pudiendo evitar crear el "saldo" como un public y tener que realizar comunicación continúa entre dos scripts, que puede dar origen a 
 fallos o códigos adicionales*/

    [SerializeField]
    TextMeshProUGUI dineroObtenido;

    public int saldo;
    void Start()
    {
        saldo = 0;
    }

    void Update()
    {
          
    }
}
