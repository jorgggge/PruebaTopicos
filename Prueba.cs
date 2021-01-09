using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
	public DatabaseReference reference;
    // Start is called before the first frame update
    void Start()
    {
         // Set up the Editor before calling into the realtime database.
	    FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://iaproject-88ae5.firebaseio.com/");
        
        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        Debug.Log("Holis xd", gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
