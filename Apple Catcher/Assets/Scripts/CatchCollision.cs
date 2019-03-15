using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchCollision : MonoBehaviour
{
    #region Variables
    public int Catch = 0;
    public Text Score;
    public AudioSource Egg;
    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + Catch;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Egg.Play();
        Catch = Catch + 100;
        Destroy(collision.gameObject);
    }
}
