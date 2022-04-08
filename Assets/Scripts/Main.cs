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
    public Text timer;
    public Button btnTourTir;
    public Button btnGlace;
    public Button btnBombe;
    public Button btnEffacer;
    public Text pv;

    public GameObject tourTirPrefab;
    public GameObject glacePrefab;
    public GameObject bombePrefab;
    public Collider fin;

    private int gold = 0;
    private int morts = 0;
    private int vie = 100;
    private int nbVague = 0;
    private List<Ennemie> listeEnnemies;
    private bool vagueEnCours;
    private bool enPause = false;

    // Start is called before the first frame update
    void Start()
    {
        //Ajoute le listener pour les boutons
        btnTourTir.onClick.AddListener(PlacerTourTir);
        btnGlace.onClick.AddListener(PlacerGlace);
        btnBombe.onClick.AddListener(PlacerBombe);
        btnEffacer.onClick.AddListener(EffacerTour);
        btnPause.onClick.AddListener(Pause);
        btnReprendre.onClick.AddListener(Reprendre);

        //Or au début du jeux
        Data.Gold = 10;
        gold = Data.Gold;

        NouvVague(nbVague);
        //start le timer
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        // timer

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

    public void EnnemieMort(Ennemie ennemie)
    {
        listeEnnemies.Remove(ennemie);
        ennemie.enabled = false;

        gold = Data.Gold;
        morts = Data.ennemieMort;

        if (listeEnnemies.Count <= 0)
        {
            nbVague += 1;
            vagueEnCours = false;
        }
    }

    // place tour normal sur la base selectionner
    void PlacerTourTir()
    {
        if (Data.BaseSelect == "Tower Base")
            Instantiate(tourTirPrefab, new Vector3(-17.59f, 0f, -2.31f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (1)")
            Instantiate(tourTirPrefab, new Vector3(-16.69f, 0f, -17.8f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (2)")
            Instantiate(tourTirPrefab, new Vector3(-11.12f, 0f, 42.76f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (3)")
            Instantiate(tourTirPrefab, new Vector3(-0.74f, 0f, -3.93f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (4)")
            Instantiate(tourTirPrefab, new Vector3(-0.81f, 0f, -16.42f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (5)")
            Instantiate(tourTirPrefab, new Vector3(8.29f, 0f, -34.34f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (6)")
            Instantiate(tourTirPrefab, new Vector3(6.29f, 0f, -26.14f), new Quaternion(-90f, 90f, 90f, 90f));
    }

    // place tour de glace sur la base selectionner
    void PlacerGlace()
    {
        if (Data.BaseSelect == "Tower Base")
            Instantiate(glacePrefab, new Vector3(-17.59f, 0f, -2.31f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (1)")
            Instantiate(glacePrefab, new Vector3(-16.69f, 0f, -17.8f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (2)")
            Instantiate(glacePrefab, new Vector3(-11.12f, 0f, 42.76f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (3)")
            Instantiate(glacePrefab, new Vector3(-0.74f, 0f, -3.93f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (4)")
            Instantiate(glacePrefab, new Vector3(-0.81f, 0f, -16.42f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (5)")
            Instantiate(glacePrefab, new Vector3(8.29f, 0f, -34.34f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (6)")
            Instantiate(glacePrefab, new Vector3(6.29f, 0f, -26.14f), new Quaternion(-90f, 90f, 90f, 90f));
    }

    // place tour à bombe sur la base selectionner
    void PlacerBombe()
    {
        if (Data.BaseSelect == "Tower Base")
            Instantiate(bombePrefab, new Vector3(-17.59f, 0f, -2.31f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (1)")
            Instantiate(bombePrefab, new Vector3(-16.69f, 0f, -17.8f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (2)")
            Instantiate(bombePrefab, new Vector3(-11.12f, 0f, 42.76f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (3)")
            Instantiate(bombePrefab, new Vector3(-0.74f, 0f, -3.93f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (4)")
            Instantiate(bombePrefab, new Vector3(-0.81f, 0f, -16.42f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (5)")
            Instantiate(bombePrefab, new Vector3(8.29f, 0f, -34.34f), new Quaternion(-90f, 90f, 90f, 90f));
        else if (Data.BaseSelect == "Tower Base (6)")
            Instantiate(bombePrefab, new Vector3(6.29f, 0f, -26.14f), new Quaternion(-90f, 90f, 90f, 90f));
    }

    void EffacerTour()
    {
        // effacer les tours
    }

    public void EnnemieArriver(Ennemie ennemie)
    {
        // reduit les pvs
        Data.Pv -= 1;
        pv.text = Data.Pv.ToString();
        // Détruit l'ennemie
        Destroy(ennemie);
    }

    IEnumerator Timer()
    {
        while (true)
        {
            //Ajoute des secondes
            timer.text = Time.deltaTime.ToString();
        }
    }

    void Pause()
    {
        //mettre le jeux en pause
        Debug.Log("Jeux en pause");

        //masquer le bouton de pause
        btnPause.enabled = false;
        //Activer le bouton reprendre
        btnReprendre.enabled = true;
    }

    void Reprendre()
    {
        //reprendre le jeux
        Debug.Log("Jeux reprit");
        //masquer le bouton reprendre
        btnReprendre.enabled = false;
        //Activer le bouton Pause
        btnPause.enabled = true;
    }
}
