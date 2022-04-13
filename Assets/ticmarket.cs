using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ticmarket : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;
    public float precioproducto1;
    public float precioproducto2;
    public float precioproducto3;
    public int cantidadproducto1;
    public int cantidadproducto2;
    public int cantidadproducto3;
    float descuentoproducto1;
    float descuentoproducto2;
    float descuentoproducto3;
    float preciosindescuento;
    float montodescuento1;
    float montodescuento2;
    float montodescuento3;
    float preciototal;
    float montodescuentos;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadproducto1 < 1 || precioproducto1 < 1)
        {
            Debug.Log("Error");
        }
        else if (cantidadproducto1 > 3)
        {
            preciosindescuento = precioproducto1 + precioproducto2 + precioproducto3;
            descuentoproducto1 = precioproducto1 * (80 / 100);
            montodescuento1 = descuentoproducto1 - precioproducto1;
            preciototal = descuentoproducto1 + precioproducto2 + precioproducto3;
            Debug.Log("La compra de los tres productos sin descuento es de" + preciosindescuento+ ",el monto de descuento total es de"+montodescuento1+" y el total con descuentos aplicados es de" +preciototal);

        }
        else if (cantidadproducto1 > 3 && cantidadproducto2 > 2)
        {
            preciosindescuento = precioproducto1 + precioproducto2 + precioproducto3;
            descuentoproducto1 = precioproducto1 * (80 / 100);
            descuentoproducto2 = precioproducto2 * (80 / 100);
            montodescuento1 = descuentoproducto1 - precioproducto1;
            montodescuento2 = descuentoproducto2 - precioproducto2;
            montodescuentos = montodescuento1 + montodescuento2; 
            preciototal= descuentoproducto1 + descuentoproducto2 + precioproducto3;
            Debug.Log("La compra de los tres productos sin descuento es de" + preciosindescuento + ",el monto de descuento total es de" + montodescuentos + " y el total con descuentos aplicados es de" + preciototal);

        }
        else if (cantidadproducto1 > 3 && cantidadproducto2 > 2 && cantidadproducto3>3)
        {
            preciosindescuento = precioproducto1 + precioproducto2 + precioproducto3;
            descuentoproducto1 = precioproducto1 * (80 / 100);
            descuentoproducto2 = precioproducto2 * (80 / 100);
            descuentoproducto3 = precioproducto3 * (80 / 100);
            montodescuento1 = descuentoproducto1 - precioproducto1;
            montodescuento2 = descuentoproducto2 - precioproducto2;
            montodescuento3 = descuentoproducto3 - precioproducto3;
            montodescuentos = montodescuento1 + montodescuento2 + montodescuento3;
            preciototal = descuentoproducto1 + descuentoproducto2 + descuentoproducto3;
            Debug.Log("La compra de los tres productos sin descuento es de" + preciosindescuento + ",el monto de descuento total es de" + montodescuentos + " y el total con descuentos aplicados es de" + preciototal);

        }
        else if (cantidadproducto1 > 2 && cantidadproducto3 > 1)
        {
            preciosindescuento = precioproducto1 + precioproducto2 + precioproducto3;
            descuentoproducto1 = precioproducto1 * (80 / 100);
            descuentoproducto3 = precioproducto3 * (80 / 100);
            montodescuento1 = descuentoproducto1 - precioproducto1;
            montodescuento3 = descuentoproducto3 - precioproducto3;
            montodescuentos = montodescuento1 + montodescuento2;
            preciototal = descuentoproducto1 + descuentoproducto3 + precioproducto2;
            Debug.Log("La compra de los tres productos sin descuento es de" + preciosindescuento + ",el monto de descuento total es de" + montodescuentos + " y el total con descuentos aplicados es de" + preciototal);

        }
        else if (cantidadproducto2 > 3 && cantidadproducto3 > 1)
        {
            preciosindescuento = precioproducto1 + precioproducto2 + precioproducto3;
            descuentoproducto2 = precioproducto2 * (80 / 100);
            descuentoproducto3 = precioproducto3 * (80 / 100);
            montodescuento2 = descuentoproducto2 - precioproducto1;
            montodescuento3 = descuentoproducto3 - precioproducto3;
            montodescuentos = montodescuento2 + montodescuento3;
            preciototal = descuentoproducto2 + descuentoproducto3 + precioproducto1;
            Debug.Log("La compra de los tres productos sin descuento es de" + preciosindescuento + ",el monto de descuento total es de" + montodescuentos + " y el total con descuentos aplicados es de" + preciototal);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
