using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_player_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isNen_dat, isRight;
    public GameObject skill;
    public Sprite[] skins;
    public SpriteRenderer src;
    private int skinindex;
    public Game.AxieFigure figure;
    void Start()
    {
        skinindex = PlayerPrefs.GetInt("skins", 0);
        isRight = false;
        //src.sprite = skins[skinindex];
        creatxie();
        //src.enabled = false;
    }
    public void creatxie()
    {
        string genes = "0x2000000000000300008100e08308000000010010088081040001000010a043020000009008004106000100100860c40200010000084081060001001410a04406";
        figure.SetGenes("", genes);
        var meshRenderer = figure.GetComponent<MeshRenderer>();
        meshRenderer.sortingOrder = 10;
        figure.transform.localScale = Vector3.one * 4;
        figure.GetComponent<PolygonCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * 4, 0, 0);
            transform.localScale = new Vector3(0.4798764f, 0.4454139f, 1f);
            figure.Actionrun();
            isRight = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * 4, 0, 0);
            transform.localScale = new Vector3(-0.4798764f, 0.4454139f, 1f);
            figure.Actionrun();
            isRight = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isNen_dat)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 15;
                figure.DoJumpAnim();
                isNen_dat = false;
            }

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            figure.AttackFly();
        }
        if (Input.GetKey(KeyCode.R))
        {

            if (thanh_mana.time_addmana >= 100)
            {
                figure.Victory();
                thanh_mana.time_addmana = 0;
                if (isRight == true)
                {
                    Instantiate(skill, new Vector2(transform.localPosition.x, transform.localPosition.y + 1), transform.localRotation);
                }
                else
                {
                    Instantiate(skill, new Vector2(transform.localPosition.x, transform.localPosition.y + 1), Quaternion.Euler(new Vector3(0, 0, 180)));
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "map" || collision.gameObject.tag == "cuc_da")
        {
            isNen_dat = true;
        }
    }

}

