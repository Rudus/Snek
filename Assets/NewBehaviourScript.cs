using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

public string children;


    // Use this for initialization
    void Start() {
    int i = 0;
    Debug.Log("Hello my name is " + gameObject + " My parent is: " + GetComponent<Transform>().parent + "My Children are: ");
    foreach (Transform child in transform)
        {
            //children = gameObject;
            
            Debug.Log(gameObject.transform.GetChild(i));
            i++;
        }

        

        
        
            
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
