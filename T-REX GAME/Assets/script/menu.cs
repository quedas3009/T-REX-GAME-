using UnityEngine;

public class menu : MonoBehaviour
{
    //menus
    public GameObject deathmenu;
    public GameObject player;
    public GameObject firstmenu;
    public GameObject dethmenu1;




    public string deleteobjetos = "morte";




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
        
   }
}
