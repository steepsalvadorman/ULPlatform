using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraDePoder : MonoBehaviour
{
    public Image barraDePoder;
    public float poderActual;
    public float poderMaximo;

    void Update()
    {
        barraDePoder.fillAmount = poderActual / poderMaximo;
    }

    public void AumentarPoder(float cantidad)
    {
        poderActual += cantidad;
        if (poderActual > poderMaximo) {
            poderActual = poderMaximo;
        }
        barraDePoder.fillAmount = poderActual / poderMaximo; // Actualiza la barra de poder
    }

    // Destruir el enemigo y aumentar el poder en 10 unidades
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Se activó OnTriggerEnter"); // Línea de depuración
            AumentarPoder(10.0f); // Aumenta el poder en 10 unidades
            Destroy(other.gameObject); // Destruye el enemigo
        }
    }
}
