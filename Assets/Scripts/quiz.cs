using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{

    public Button sim, nop, question;

    public Text verdade,texto;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        sim.onClick.AddListener(SeSim);
        nop.onClick.AddListener(SeNop);
        question.onClick.AddListener(SeQuestion);
    }

    void SeSim(){
        print("sim");
        verdade.text = "VOCÊ ACERTOU";
        verdade.color = Color.green;
        texto.text = "";
        sim.enabled = false;
        sim.GetComponent<Image>().enabled = false;
        nop.enabled = false;
        nop.GetComponent<Image>().enabled = false;
    }
    void SeNop(){
        print("nop");
        verdade.text = "SIM FOI VERDADE";
        verdade.color = Color.red;
        texto.text = "";
        sim.enabled = false;
        sim.GetComponent<Image>().enabled = false;
        nop.enabled = false;
        nop.GetComponent<Image>().enabled = false;
        
    }
    void SeQuestion(){
        canvas.enabled = !(canvas.enabled);
        print("SeQuestion");
    }
}
