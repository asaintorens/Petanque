using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public Boule laBoule;
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	
        if(laBoule !=null)
        {
            this.UpdateCameraPosition();
        }
	}

    private void UpdateCameraPosition()
    {
        Vector3 vecteurExentré = new Vector3(laBoule.transform.position.x + 2, laBoule.transform.position.y+1, laBoule.transform.position.z );
        transform.position = Vector3.Lerp(
        transform.position, vecteurExentré,
        Time.deltaTime );
    }
}
