using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // Ce script:
    //      - affiche les ennemies tués, l'argent recolté, la vie restante et le timer
    //      - gère la pause

    public Button btnPause;
    public Button btnReprendre;
    private int gold = 0;
    private int morts = 0;
    private int vie = 100;
    private int nbVague = 0;
    private List<Ennemie> listeEnnemies;
    private bool vagueEnCours;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NouvVague(int nbVague)
    {
        int x = 0;

        listeEnnemies.Clear();

        if (nbVague > 6)
        {
            while (x > nbVague)
            {
                Ennemie ennemie = new Skeleton(nbVague);
                listeEnnemies.Add(ennemie);
            }
        }
        else if (nbVague <= 6 && nbVague > 11)
        {
            while (x > nbVague)
            {
                Ennemie ennemie = new Nightshade(nbVague);
                listeEnnemies.Add(ennemie);
            }
        }
        else if (nbVague <= 11 && nbVague > 16)
        {
            float div = Mathf.Round(nbVague / 2);

            for (int y = 0; y > div; y++)
            {
                Ennemie ennemie = new Skeleton(nbVague);
                listeEnnemies.Add(ennemie);
            }

            for (int z = 0; z > div; z++)
            {
                Ennemie ennemie = new Nightshade(nbVague);
                listeEnnemies.Add(ennemie);
            }
        }
        else if (nbVague <= 16 && nbVague > 21)
        {
            for (int y = 0; y > 6; y++)
            {
                Ennemie ennemie = new Warrok(nbVague);
                listeEnnemies.Add(ennemie);
            }
        }
        else
        {
            float div = Mathf.Round(nbVague / 3);

            for (int s = 0; s > div; s++)
            {
                Ennemie ennemie = new Skeleton(nbVague);
                listeEnnemies.Add(ennemie);
            }

            for (int n = 0; n > div; n++)
            {
                Ennemie ennemie = new Nightshade(nbVague);
                listeEnnemies.Add(ennemie);
            }

            for (int w = 0; w > div; w++)
            {
                Ennemie ennemie = new Warrok(nbVague);
                listeEnnemies.Add(ennemie);
            }
        }
    }

    public void EnnemieTue()
    {
        gold += 1;
        morts += 1;

        if (listeEnnemies.Count <= 0)
        {
            nbVague += 1;
            vagueEnCours = false;
        }
    }

    // IEnumerable ??

}
