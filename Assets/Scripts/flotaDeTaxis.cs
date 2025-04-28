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
        descuento = costoPorLitro - (20/100);
        litroDeCombustible = 15;
        costoPorLitro = cantidadDeUnidades * (periodoDeDias * 90) * litroDeCombustible;
        costoTotalCombustible = costoPorLitro * 130;

        if (periodoDeDias < 5 || cantidadDeUnidades < 1)
        {
            Debug.Log("La cantidad de días o unidades no es válida");
            return;
        }
        if(litroDeCombustible >= 100)
        {
            costoConDescuento = descuento - (20 / 100);
            Debug.Log("El precio de tu combustible con el descuento aplicado es de $" + costoConDescuento)
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
