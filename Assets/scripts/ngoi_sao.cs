using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ngoi_sao : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sao;
    public float vitri;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(sao.transform.position.x, sao.transform.position.y);
        transform.Translate(Time.deltaTime * 7, -Time.deltaTime * 7, 0);
        Debug.Log(transform.position.y);
        if(transform.position.y <= vitri)
        {
            sao.SetActive(true);
            Destroy(gameObject);
        }
    }
}
