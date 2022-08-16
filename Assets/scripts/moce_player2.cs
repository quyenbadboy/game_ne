using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moce_player2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider thanh_mana;
    public Game.AxieFigure figure;
    void Start()
    {
        creatxie();
    }
    public void creatxie()
    {
        string genes = "0x200000000000030001c0a0e0840c00000001000c0800850200000094080085040001000818a0c20600010010106042020001000c0840c2020001001010404506";
        figure.SetGenes("", genes);
        var meshRenderer = figure.GetComponent<MeshRenderer>();
        meshRenderer.sortingOrder = 10;
        figure.transform.localScale = Vector3.one * 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(3f, 3f, 3f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-3f, 3f, 3f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * 5, 0);
            //transform.localScale = new Vector3(3f, 3f, 3f);
        }
    }
}
