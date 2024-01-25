using UnityEngine;

public class menu : MonoBehaviour
{
    //menus
    public GameObject deathmenu;
    public GameObject player;
    public GameObject firstmenu;
    public GameObject dethmenu1;


    public AudioSource musicmenu;
    public AudioSource musicdeath;
    public AudioSource musictuturial;

    public string deleteobjetos = "morte";

    public static bool firstmenuon;
    public static bool deathmenuon;
    public static bool tuturialmenuon;


    private void Start()
    {
        Invoke("morte", 1f);

    }

    private void Update()
    {
        if (Player.morreu == true)
        {
            gerador.start = false;
            deathmenu.SetActive(true);
            DestruirObjetosPorTag();

        }

        if (firstmenuon == true)
        {
            musicmenu.Play();
        }
        if (firstmenu == false)
        {
            musicmenu.Stop();
        }
        if (tuturialmenuon == true)
        {
            musictuturial.Play();
        }
        if (tuturialmenuon == false)
        {
            musictuturial.Stop();
        }
        if (deathmenuon == true)
        {
            musicdeath.Play();
        }
        if (musicdeath == false)
        {
            musicdeath.Stop();
        }



    }




    void DestruirObjetosPorTag()
    {
        GameObject[] objetosParaDestruir = GameObject.FindGameObjectsWithTag(deleteobjetos);


        foreach (GameObject objeto in objetosParaDestruir)
        {
            Destroy(objeto);
        }
    }



    public void again()
    {
        Player.morreu = false;
        deathmenu.SetActive(false);
        gerador.start = true;
    }

   public void backtomenu()
   {
        Player.morreu = false;
        deathmenu.SetActive(false);
        firstmenu.SetActive(true);
        firstmenuon = true;
        menu.deathmenuon = false;
    }
}
