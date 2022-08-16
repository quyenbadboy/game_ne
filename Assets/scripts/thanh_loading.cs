using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thanh_loading : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject backgr;
    Animator ani;
    void Start()
    {
        StartCoroutine(dung());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator dung()
    {
        yield return new WaitForSeconds(5);
        backgr.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(0);
        Destroy(gameObject);




    }
}
