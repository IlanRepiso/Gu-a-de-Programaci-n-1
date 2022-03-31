using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text9 : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema:  
    //Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje
    //del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    //mostrar lo pedido en el siguiente formato:  
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

        public int Juan;
        public int Roberto;
        public int Jorge;
    // Start is called before the first frame update
    void Start()
    {
         int total = Juan + Roberto + Jorge;
        float porcentaje = total / 100;
        Debug.Log("Juan: capital aportado: $" + Juan + ", Porcentaje del capital: %" + Juan / porcentaje + ", Monto total aportado: %" + total);
        Debug.Log("Roberto: capital aportado: $" + Roberto + ", Porcentaje del capital: %" + Roberto / porcentaje + ", Monto total aportado: %" + total);
        Debug.Log("Jorge: capital aportado: $" + Jorge + ", Porcentaje del capital: %" + Jorge / porcentaje + ", Monto total aportado: %" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
