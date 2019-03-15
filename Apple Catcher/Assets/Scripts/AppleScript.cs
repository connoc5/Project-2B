using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleScript : MonoBehaviour
{
    #region Variables
    public GameObject ApplePrefab;
    public GameObject Container;
    public AudioSource Chicken;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnObject()
    {
        Chicken.Play();
        GameObject prefabinstance = Instantiate(ApplePrefab, transform.position, Quaternion.identity);
        prefabinstance.transform.SetParent(Container.transform);
    }
}
