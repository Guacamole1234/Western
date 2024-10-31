using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Replay : MonoBehaviour
{

    [SerializeField]
    Button replay;
    [SerializeField]
    Canvas endScreen;
    [SerializeField]
    Canvas gameplay;
    [SerializeField]
    Canvas start;

    /* El objetivo es hacer que al presionarse el bot�n "Replay", visualizado aqu� como "replay", este aplique un set.Active(false) al canvas "EndScreen" y
     reinicie el script y la secuencia del gameplay sin pasar por el canvas de "start". Se podr�a hacer los arreglos necesarios para hacer funcionar el juego en
    el mismo script, no obstante creo que por facilidades lo har�a en otro script a parte, por lo que tendr�a que llamar a ese script y activarlo de nuevo para
    que reinicie la partida.
    
     Simult�neamente este mismo script serivir�a para activar el gameplay desde el bot�n "Begin" en el canvas de "Start", este bot�n es denominado aqu� como "start"
    y tendr�a la finalidad de comenzar el script de juego, por lo que ser�a necesario llamar al script como el caso anterior*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
