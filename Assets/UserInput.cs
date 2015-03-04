using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserInput : MonoBehaviour {
    public Scrollbar HauteurForce;
    public Scrollbar LongueurForce;
    public Scrollbar HauteurLance;
    public Scrollbar DirectionLance;
    public Precision precision;

  public  int nbBoules;
	void Start () {
        nbBoules = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.precision.locked = true;
            

            GameObject go = GameObject.Find("Boule" + nbBoules);
            Boule boule = (Boule)go.GetComponent(typeof(Boule));
            boule.LancerAleatoire(this.precision.slide.value);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject go = GameObject.Find("Boule" + nbBoules);
            Boule boule = (Boule)go.GetComponent(typeof(Boule));
            boule.Reset();
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            this.precision.locked = false;
            this.nbBoules++;
            GameObject go = GameObject.Instantiate(Resources.Load("Boule")) as GameObject;
            go.name = "Boule" + nbBoules;
            
            Boule boule = (Boule)go.GetComponent(typeof(Boule));
            boule.estJoue = false;

            GameObject camObj = GameObject.Find("Camera");
            Camera camera = (Camera)camObj.GetComponent(typeof(Camera));
            camera.laBoule = boule;
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            GameObject cameraTopObj = GameObject.Find("CameraTop");
            CameraTop cameraTop= (CameraTop)cameraTopObj.GetComponent(typeof(CameraTop));
            cameraTop.ChangeCamera();
        }
	}
}
