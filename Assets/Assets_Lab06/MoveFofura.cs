using UnityEngine;
using System.Collections;

public class MoveFofura : MonoBehaviour
{
    public Vector3 moveSpeed;
    public float spawnTime = 2f;
    public float spawnDelay = 2f;
    private bool canMove = false; // controla o movimento do personagem
    public GameObject caixa; // Referência à caixa
    public GameObject pedra; // Referência à pedra
    public GameObject outroPersonagem; // Referência ao outro personagem que deve parar

    // Use this for initialization
    void Start()
    {
        moveSpeed = Vector3.left * Time.deltaTime;
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
    }

    void Update()
    {
        // Verifica se os personagens estão próximos
        /*if (canMove)
        {
            // Move o personagem
            transform.position += moveSpeed;

            // Verifica se o outro personagem está próximo (distância menor que um valor definido)
            if (Vector3.Distance(transform.position, outroPersonagem.transform.position) < 0.5f) // ajuste o valor conforme necessário
            {
                desativarMovimento();
            }
        }*/

        // Verifica se a caixa e a pedra foram destruídas
        if (canMove)
        {
            transform.position += moveSpeed;

            if (caixa == null && pedra == null && Vector3.Distance(transform.position, outroPersonagem.transform.position) > 1.0f)
            {
                ativarMovimento();
            }
            else if (caixa == null && pedra == null && Vector3.Distance(transform.position, outroPersonagem.transform.position) < 2.0f)
            {
                desativarMovimento();
            }

        }
    }

    public void ativarMovimento()
    {
        canMove = true; // ativa o movimento do personagem
    }

    public void desativarMovimento()
    {
        canMove = false;
    }

    void ChangeSpeed()
    {
        moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f;
    }
}