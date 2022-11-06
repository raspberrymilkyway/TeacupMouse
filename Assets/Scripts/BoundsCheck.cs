using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
*   Pull the boundaries of the table
*   Check to see if the current object is on the table
*   If not, maybe it falls and then deletes?
*/

public class BoundsCheck : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject table;

    [Header("Set Dynamically")]
    public float xTrans;
    public float zTrans;

    private float boundXn;
    private float boundXx;
    private float boundZn;
    private float boundZx;

    void Start()
    {
        MeshRenderer mesh = table.GetComponent<MeshRenderer>();
        boundXn = mesh.bounds.min.x;
        boundXx = mesh.bounds.max.x;
        boundZn = mesh.bounds.min.z;
        boundZx = mesh.bounds.max.z;

        xTrans = gameObject.transform.position.x;
        zTrans = gameObject.transform.position.z;
    }

    void Update()
    {
        xTrans = gameObject.transform.position.x;
        zTrans = gameObject.transform.position.z;

        if (xTrans > boundXx || zTrans > boundZx || xTrans < boundXn || zTrans < boundZn){
            if (gameObject.tag == "Player"){
                SceneManager.LoadScene("EndingScene");
            }
            else{
                Destroy(gameObject);
            }
        }
    }
}
