using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    public List<GameObject> objetosADestruir; // Lista de objetos a serem destru�dos

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido est� na lista de objetos a serem destru�dos
        if (objetosADestruir.Contains(collision.gameObject))
        {
            // Destroi o objeto colidido
            Destroy(collision.gameObject); // Destroi o objeto com o qual a pedra colidiu
            Destroy(gameObject); // Destroi o objeto atual (pedra)
        }
    }
}
