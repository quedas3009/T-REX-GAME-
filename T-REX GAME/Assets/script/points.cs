using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public GameObject contadortex;
    public Text textoContador;
    public Text hightscore;
    private int contador = 0;
    public float intervaloAtualizacao = 1f; // Atualiza a cada segundo

    public int score = 0;

    public GameObject image;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
   





    public void Start()
    { 
            InvokeRepeating("AtualizarContador", 0f, intervaloAtualizacao);
    }

    public void Update()
    {
        if (gerador.start == false)
        {
            contador = 0;
            contadortex.SetActive(false);
        }
        if (gerador.start == true)
        {
            contadortex.SetActive(true);

        }

        if (score < contador)
        {
            score = contador;
        }




    }



    void AtualizarContador()
    {
        hightscore.text = score.ToString();
        contador++;
        textoContador.text =contador.ToString();
    }
}
