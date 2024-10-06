using UnityEngine;
using System.Collections;

public class MoveFofura : MonoBehaviour
{
    public Vector3 moveSpeed;
    private bool canMove = false; // controla o movimento do personagem
    public GameObject caixa; // Referência à caixa
    public GameObject pedra; // Referência à pedra
    public GameObject outroPersonagem; // Referência ao outro personagem que deve parar


    // Use this for initialization
    void Start()
    {
        moveSpeed = Vector3.left * 0.03f; // velocidade
    }

    void Update()
    {
        if (caixa == null && pedra == null)
        {
            // Calcular a distância até o outro personagem
            float distance = Vector3.Distance(transform.position, outroPersonagem.transform.position);
            Debug.Log("Distância: " + distance); // Log da distância

            if (Vector3.Distance(transform.position, outroPersonagem.transform.position) < 2.0f)
            {
                desativarMovimento(); // personagens proximos, para o movimento
            }
            else
            {
                transform.position += moveSpeed; // personagens distantes, mantem movimento
            }
        }
    }

    public void desativarMovimento()
    {
        canMove = false;
    }
}