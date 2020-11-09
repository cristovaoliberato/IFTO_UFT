using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoControle : MonoBehaviour
{
    public Animator animador;
    string[] animacoes = new string[]
    {
        "up",
        "idle",
        "down",
        "left",
        "right",
        "cimaEsquerda",
        "cimaDireita",
        "baixoEsquerda",
        "baixoDireita"
    };
    public string animacaoAtual;
    float inputX, inputY;
    PlayerController playerCtrl;
    // Start is called before the first frame update
    void Start()
    {
        animador = gameObject.GetComponent<Animator>();
       
        
    }
    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerCtrl = player.GetComponent<PlayerController>();
        inputX = playerCtrl.input_x;
        inputY = playerCtrl.input_y;
        if (inputX < 0.2f && inputX > -0.2f)
        {
            if (inputY < -0.7f) //baixo
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[2];
            }
            else if (inputY > 0.7f) //cima
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[0];
            }
        }
        if (inputY < 0.2f && inputY > -0.2f)
        {
            if (inputX < -0.7f) //esquerda
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[3];
            }
            else if (inputX > 0.7f) //direita
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[4];
            }
        }
        if (inputX < -0.21f && inputX > -0.69f)
        {
            if (inputY < -0.21f && inputY > -0.69f) //baixoEsquerda
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[2];
            }
            else if (inputY > 0.21f && inputY < 0.69f) //cimaEsquerda
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[0];
            }
        }
        if (inputX > 0.21f && inputX < 0.69f)
        {
            if (inputY < -0.21f && inputY > -0.69f) //baixoDireita
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[2];
            }
            else if (inputY > 0.21f && inputY < 0.69f) //cimaDireita
            {
                desativaTodasAnimacoes();
                animacaoAtual = animacoes[0];
            }
        }
        if (inputX == 0 && inputY == 0)
        {
            desativaTodasAnimacoes();
            animacaoAtual = animacoes[1];
        }

        void desativaTodasAnimacoes()
        {
            for (int i = 0; i < animacoes.Length; i++)
            {
                if (animacoes[i] != animacaoAtual)
                {
                    animador.SetBool(animacoes[i], false);
                }
                animador.SetBool(animacaoAtual, true);
            }
        }
    }
}
