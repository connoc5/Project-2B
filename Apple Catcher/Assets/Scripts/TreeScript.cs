using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    #region Variables
    private float StartX = 0;
    private float StartY = 3f;
    public float Speed = 5f;
    public float DirChangeChance;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Vector3 positionTree = new Vector3(StartX, StartY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;
        if (Random.value <= DirChangeChance)
        {
            Speed *= -1;
        }

        if (transform.position.x > 7.5 || transform.position.x < -7.5)
        {
            Speed *= -1;
        }
    }
}