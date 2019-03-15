using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("End");
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
