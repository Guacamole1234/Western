using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class wallet : MonoBehaviour
{
    /*Este script tiene como finalidad administrar la suma de puntos, "dinero", atrav�s de una wallet, mostr�ndola en tiempo real durante el gameplay en el margen
 derecho superior de la pantalla en "RewardText" y el resultado final en la pantalla �ltima, en "RewardAchived", que saldr�a al terminar el tiempo, as� como 
 llevar la serie de c�digo para desactivar los objetivos clickados, seguramente el uso de tags facilitar�a esta labor, de esta forma tendr�a de forma localizada 
 el conteo del dinero, pudiendo evitar crear el "saldo" como un public y tener que realizar comunicaci�n contin�a entre dos scripts, que puede dar origen a 
 fallos o c�digos adicionales*/

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
