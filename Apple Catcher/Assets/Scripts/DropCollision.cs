using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropCollision : MonoBehaviour
{
    #region Variables
    public GameObject ApplePrefab;
    public GameObject Tree;
    public GameObject Basket;
    public CatchCollision script;
    public AudioSource splat;

    public Text Lives;
    public int MaxLives = 3;
    private int CurrentLives;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        script = Basket.GetComponent<CatchCollision>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
        }
    }
    private void Awake()
    {
        CurrentLives = MaxLives;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        splat.Play();
        CurrentLives--;
        if (Lives.text == "Lives: 1")
        {
            Lives.text = "Lives: 0";
            Time.timeScale = 0;
            Basket.transform.position = new Vector3(0, -3.5f, 1);
            Tree.transform.position = new Vector3(0, 2.5f, 0);
            Lives.text = "Lives: 3";
            script.Catch = 0;
        }
        else if (Lives.text == "Lives: 2")
        {
            Lives.text = "Lives: 1";
        }
        else if (Lives.text == "Lives: 3")
        {
            Lives.text = "Lives: 2";
        }
        Destroy(collision.gameObject);
    }
}
