using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenas : MonoBehaviour
{
    public GameObject[] paineis;

    

    public void MoverDireita()
    {
        Vector3 ultimaPosicao = paineis[paineis.Length - 1].transform.position;
        for (int i = paineis.Length - 1; i > 0; i--)
        {
            paineis[i].transform.position = paineis[i - 1].transform.position;
        }
        paineis[0].transform.position = ultimaPosicao;
    }

    public void MoverEsquerda()
    {
        Vector3 primeiraPosicao = paineis[0].transform.position;
        for (int i = 0; i < paineis.Length - 1; i++)
        {
            paineis[i].transform.position = paineis[i + 1].transform.position;
        }
        paineis[paineis.Length - 1].transform.position = primeiraPosicao;
    }
    /*private int painelAtual = 0;

    void Start()
    {
        
    }

         public void MoverDireita()
    {
        // Verifica se o painel atual não é o último
        if (painelAtual < paineis.Length - 1)
        {
            // Move o painel atual para a direita
            paineis[painelAtual].transform.localPosition += Vector3.right * 3f;

            // Move o próximo painel para a posição do painel atual
            paineis[painelAtual + 1].transform.localPosition = paineis[painelAtual].transform.localPosition;

            // Atualiza o índice do painel atual
            painelAtual++;
        }
    }

     public void MoverEsquerda()
    {
        // Verifica se o painel atual não é o primeiro
        if (painelAtual > 0)
        {
            // Move o painel atual para a esquerda
            paineis[painelAtual].transform.localPosition += Vector3.left * -3f;

            int painelAnterior = painelAtual - 1;

            // Verifica se o índice do painel anterior é maior ou igual a zero
            if (painelAnterior >= 0)
            {
                // Move o painel anterior para a posição do painel atual
                paineis[painelAnterior].transform.localPosition = paineis[painelAtual].transform.localPosition;
            }

            // Atualiza o índice do painel atual
            painelAtual--;
        
    }
    }*/

    public void Passa(string nome)
    {
        SceneManager.LoadScene(nome);
    }

}
