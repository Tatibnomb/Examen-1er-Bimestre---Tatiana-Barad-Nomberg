using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flotaDeTaxis : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;
    int costoPorLitro;
    float costoTotalCombustible;
    int litroDeCombustible;
    float costoConDescuento;
    float descuento;

    // Start is called before the first frame update
    void Start()
    {
        descuento = costoPorLitro - 0.2f;
        litroDeCombustible = 15;
        costoPorLitro = litroDeCombustible * (cantidadDeUnidades * (periodoDeDias * 90));
        costoTotalCombustible = costoPorLitro * 130;

        if (periodoDeDias < 5 || cantidadDeUnidades < 1)
        {
            Debug.Log("La cantidad de días o unidades no es válida");
            return;
        }
        if(litroDeCombustible >= 100)
        {
            costoConDescuento = descuento * 0.2f;
            Debug.Log("El monto del descuento es de $" + descuento + " y el costo final del combustible es de $" + costoConDescuento);
        }
        else
        {
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
