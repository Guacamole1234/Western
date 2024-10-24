using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Cronometro : MonoBehaviour
{
    /* Bloc de notas:
 -Bot�n "Start"/"Begin" que comience la secuencia del juego con el cronometro
 -Cronometro cuenta atr�s desde 60, sin decimales
 -Al iniciar la partida no hay enemigos
 - Cada 5-10 segundos spawn enemigo aleatorio de los predeterminados en localizaci�n aleatoria de las predeterminadas.
 -Los personajes que re-spawneen tras el paso del tiempo deben estar desactivados (comprobar activeSelf en array)
 -Pantalla final de partida (EndScreen) con resultados (RewardAchieved) y bot�n de reintentar.

 Arrays: (�Usar un Random-Range para comenzar el spawneo?) 
 Peronsaje: 	Tiempo:		Recompensa:
 BadGuy		    5s		    +500
 BadGuy2		3s		    +750
 GoodGuy		4s		    -50
 Lady		    8s		    -80
 Sheriff		10f		    -100        */
    /*"Cronometro" no es un cronometro, su principal funci�n es llevar el c�digo "pesado" para el funcionamiento del gameplay, no solo una cuenta regresiva desde
 60 segundos (que como puedes apreciar no me sale) sino tambi�n el array para el spawneo de enemigos. La cuenta regresiva se tendr�a que preparar desde un public
 esto debido a los pulsadores del "Start" y "EndScreen" ser�an los encargados de comenzar el conteo y de reiniciarlo, la forma m�s f�cil es mediante un booleano
 en otro proyecto tengo eso mismo hecho. Desde dentro de un if podemos determinar, gracias al bool, cuando empezar la cuenta regresiva y el tiempo pasado, tras
 unos pocos segundos comenzar�an a spawnear en intervalos y cantidades aleatorias haciendo uso de un par de Random.Range, el cual se reiniciar�a gracias a un
 if que se activar�a cada vez que un objetivo es eliminado, comenzando una cuenta regresiva de 5-10 segundos (Random.Range), eligiendo una ubicaci�n aleatoria del
 array y un personaje aleatorio de otro array, los arrays tendrian que funcionar con gameObject en vez de n�meros para ser posible, desconozco (sin mis apuntes) 
 como podr�a hacerlo, ya que no me lo s� de memoria.

    La necesidad de dividirlo en dos, pese a que estoy seguro que hay una forma de hacerlo juntos, es para evitar bugs que asignen a cada objetivo con un lugar, 
 eliminando el factor aleatorio, al hacerlo separado es como si tiraras la moneda dos veces. Lo que desconozco es como verificar si el objetivo est� ca�do o no,
 para esto se podr�a usar un if, que reinicie "la moneda" cada vez que el objetivo a respawnear este desactivado, otra forma podr�a ser hacer un arrays
 con publics y getComponents para tener una lista de activos y desactivos, eligiendo de forma aleatoria los que nos interesan, todo deber�a estar en el "update" 
 sin duda.

 P.D: Har�a falta una clase solo para saber usar el glosario de Unity, ya que est� dividido en distintas versiones, una cada vez menos completa que la anterior
 y una forma escrita, que copiando y pegando no funciona, siempre tiene informaci�n faltante, por eso existen tantos tutoriales. Aunque la labor de un
 programador pr�cticamente es copiar, pegar y adaptar.
 P.P.D: Estoy suspendido y seguramente lo que he escrito no tenga ning�n valor, pero al menos corr�geme la l�nea de pensamiento, para saber si debo usar una
 metodolog�a distinta a la hora de plantearme problemas y cuestiones, en cuando a escribir de memoria, siempre he sido horrible a la hora de memorizar c�digo
 en s� mismo, aunque no tenga problemas con otras cosas.
 P.P.P.D: Pasa un buen d�a/tarde/noche/finde, dependiendo de cuando est�s leyendo esto. Iba a poner un chiste para terminar ameno esto, pero no s� tu humor y el
 m�o es muy oscuro, asi que dir� uno de madre: -�Eres de Grecia? -En parte s�, y en Partenon*/


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
