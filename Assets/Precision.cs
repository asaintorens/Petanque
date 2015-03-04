using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Precision : MonoBehaviour {

    public Slider slide;
    public bool augmente;
    public bool locked;
    public float vitesseProgression = 0.07F;
	void Start () {
        this.augmente = false;
        this.locked = false;
    }
	
	// Update is called once per frame
	void Update () {
	    
        if (!this.locked)
        {
            if(augmente)
            {
                if(this.slide.value >=1)
                {
                    this.augmente = false;
                    this.slide.value -= vitesseProgression;
                }else
                {
                    this.slide.value += vitesseProgression;
                    
                }
            }
            else
            {
                if (this.slide.value <= 0)
                {
                    this.augmente = true;
                    this.slide.value += vitesseProgression;
                }
                else
                {
                    this.slide.value -= vitesseProgression;
                }
            }
        }
	}
}
