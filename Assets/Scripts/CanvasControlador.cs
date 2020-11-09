using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasControlador : MonoBehaviour
{
    public GameObject score, menuPanel, menuButton;
    Text texto, scoreName;
    int valorScore;
    public void SetScore(int valor, string scoreName)
    {
        score = GameObject.Find(scoreName);
        texto = score.GetComponent<Text>();
        valorScore = valor;
        atualizarScore();
    }
    void atualizarScore()
    {
        texto.text = scoreName + ": " + valorScore.ToString();
    }
    public void ativarMenuBotao()
    {
        menuButton.SetActive(true);
        menuPanel.SetActive(false);
    }
    public void ativarMenuPainel()
    {
        menuPanel.SetActive(true);
        menuButton.SetActive(false);
    }
    public void voltarMenuInicial()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
