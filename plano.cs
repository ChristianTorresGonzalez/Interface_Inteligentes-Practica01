using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plano : MonoBehaviour
{
    public string nombre;
    public int identificador = 9;
    public int contador;

    // Start is called before the first frame update
    void Start()
    {
        nombre = gameObject.name;
        contador = 0;
        Debug.Log(nombre + " - Identificador numerico: " + identificador);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Contador " + nombre + ": " + contador);
        contador++;
    }
}
