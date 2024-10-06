using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFelpudo : MonoBehaviour
{
    public Vector3 moveSpeed;
    private bool canMove = false; // controla o movimento do personagem
    public GameObject caixa; // Referência à caixa
    public GameObject pedra; // Referência à pedra
    public GameObject outroPersonagem; // Referência ao outro personagem que deve parar

    void Start()
    {
        moveSpeed = Vector3.right * 0.03f;
    }

    void Update()
    {
        if (caixa == null && pedra == null)
        {
            if (Vector3.Distance(transform.position, outroPersonagem.transform.position) < 2.0f)
            {
                desativarMovimento(); // personagens proximos, para movimento
            }
            else
            {
               transform.position += moveSpeed; // move o personagem
            }
        }        
    }

    public void desativarMovimento()
    {
        canMove = false;
    }    
}