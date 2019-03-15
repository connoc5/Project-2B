using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
    #region Variables
    public float Speed = 7.5f;
    #endregion
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Clamp(transform.position.x, -5, 5);
        transform.position += Vector3.zero * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D) && transform.position.x < 10.75 || Input.GetKey(KeyCode.RightArrow) && transform.position.x < 10.75)
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -10.75 || Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10.75)
        {
            transform.position += Vector3.right * -Speed * Time.deltaTime;
        }
    }
}
