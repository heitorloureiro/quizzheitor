using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    public static GameMenager instancia;

    [Header("Gerador de Alans")]
    public GameObject objetoAlan;
    public Transform[] geradoresAlan;
    public float taxaAlan;

    private void Awake()
    {
        instancia = this; 
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GerarAlan()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GerarAlan()
    {
        int rnd = Random.Range(0, geradoresAlan.Length);
        Instantiate(objetoAlan, geradoresAlan[rnd].position, Quaternion.identity);
        yield return new WaitForSeconds(taxaAlan);
        StartCoroutine(GerarAlan());
    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(0);
    }
}
