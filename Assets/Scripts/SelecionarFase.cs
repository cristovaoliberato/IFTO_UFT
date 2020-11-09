using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionarFase : MonoBehaviour
{
    GameObject[] posicoes;
    int numeroPosicao = -1;
    GameObject posicaoInicial;
    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = GameObject.FindGameObjectWithTag("posicaoInicial");
        posicoes = GameObject.FindGameObjectsWithTag("pontosPosicoes");
    }
    void Update()
    {
        if(numeroPosicao <0)
            transform.position = Vector3.Lerp(transform.position, new Vector3(posicaoInicial.transform.position.x, posicaoInicial.transform.position.y, -0.1f), 4f * Time.deltaTime);
        else
            transform.position = Vector3.Lerp(transform.position, new Vector3(posicoes[numeroPosicao].transform.position.x, posicoes[numeroPosicao].transform.position.y, -0.1f), 4f * Time.deltaTime);
    }
    public void left()
    {
        if (numeroPosicao >= 0)
        {
            numeroPosicao--;
        }
        else
            numeroPosicao = posicoes.Length - 1;
    }
    public void right()
    {
        if (numeroPosicao < posicoes.Length - 1)
        {
            numeroPosicao++;
        }
        else
            numeroPosicao = -1;
    }
    public void GameObjectToIndex(GameObject targetObj)
    {
        for (int i = 0; i < posicoes.Length; i++)
        {
            if (posicoes[i] == targetObj)
            {
               numeroPosicao = i;
            }
        }
    }
    public void iniciarFase()
    {
        SceneManager.LoadScene(posicoes[numeroPosicao].name);    
    }
}
