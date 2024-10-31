using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Cronometro : MonoBehaviour
{
    /* Bloc de notas:
 -Botón "Start"/"Begin" que comience la secuencia del juego con el cronometro
 -Cronometro cuenta atrás desde 60, sin decimales
 -Al iniciar la partida no hay enemigos
 - Cada 5-10 segundos spawn enemigo aleatorio de los predeterminados en localización aleatoria de las predeterminadas.
 -Los personajes que re-spawneen tras el paso del tiempo deben estar desactivados (comprobar activeSelf en array)
 -Pantalla final de partida (EndScreen) con resultados (RewardAchieved) y botón de reintentar.

 Arrays: (¿Usar un Random-Range para comenzar el spawneo?) 
 Peronsaje: 	Tiempo:		Recompensa:
 BadGuy		    5s		    +500
 BadGuy2		3s		    +750
 GoodGuy		4s		    -50
 Lady		    8s		    -80
 Sheriff		10f		    -100        */
    /*"Cronometro" no es un cronometro, su principal función es llevar el código "pesado" para el funcionamiento del gameplay, no solo una cuenta regresiva desde
 60 segundos (que como puedes apreciar no me sale) sino también el array para el spawneo de enemigos. La cuenta regresiva se tendría que preparar desde un public
 esto debido a los pulsadores del "Start" y "EndScreen" serían los encargados de comenzar el conteo y de reiniciarlo, la forma más fácil es mediante un booleano
 en otro proyecto tengo eso mismo hecho. Desde dentro de un if podemos determinar, gracias al bool, cuando empezar la cuenta regresiva y el tiempo pasado, tras
 unos pocos segundos comenzarían a spawnear en intervalos y cantidades aleatorias haciendo uso de un par de Random.Range, el cual se reiniciaría gracias a un
 if que se activaría cada vez que un objetivo es eliminado, comenzando una cuenta regresiva de 5-10 segundos (Random.Range), eligiendo una ubicación aleatoria del
 array y un personaje aleatorio de otro array, los arrays tendrian que funcionar con gameObject en vez de números para ser posible, desconozco (sin mis apuntes) 
 como podría hacerlo, ya que no me lo sé de memoria.

    La necesidad de dividirlo en dos, pese a que estoy seguro que hay una forma de hacerlo juntos, es para evitar bugs que asignen a cada objetivo con un lugar, 
 eliminando el factor aleatorio, al hacerlo separado es como si tiraras la moneda dos veces. Lo que desconozco es como verificar si el objetivo está caído o no,
 para esto se podría usar un if, que reinicie "la moneda" cada vez que el objetivo a respawnear este desactivado, otra forma podría ser hacer un arrays
 con publics y getComponents para tener una lista de activos y desactivos, eligiendo de forma aleatoria los que nos interesan, todo debería estar en el "update" 
 sin duda.

 P.D: Haría falta una clase solo para saber usar el glosario de Unity, ya que está dividido en distintas versiones, una cada vez menos completa que la anterior
 y una forma escrita, que copiando y pegando no funciona, siempre tiene información faltante, por eso existen tantos tutoriales. Aunque la labor de un
 programador prácticamente es copiar, pegar y adaptar.
 P.P.D: Estoy suspendido y seguramente lo que he escrito no tenga ningún valor, pero al menos corrígeme la línea de pensamiento, para saber si debo usar una
 metodología distinta a la hora de plantearme problemas y cuestiones, en cuando a escribir de memoria, siempre he sido horrible a la hora de memorizar código
 en sí mismo, aunque no tenga problemas con otras cosas.
 P.P.P.D: Pasa un buen día/tarde/noche/finde, dependiendo de cuando estés leyendo esto. Iba a poner un chiste para terminar ameno esto, pero no sé tu humor y el
 mío es muy oscuro, asi que diré uno de madre: -¿Eres de Grecia? -En parte sí, y en Partenon*/


    [SerializeField]
    TextMeshProUGUI cronometro;
    
    public int tiempoRestante;

    void Start()
    {
        tiempoRestante = 60;   
    }

    void Update()
    {
        tiempoRestante = tiempoRestante - (int)Time.deltaTime;
        //bug.Log("Quedan " + tiempoRestante +" segundos"); 
        cronometro.text = string.Format("{0}", tiempoRestante);
        //System.String tiempoRestante = System.String.Format("{0}");
    }
}
