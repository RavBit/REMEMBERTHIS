using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasuringManager : MonoBehaviour {

    public IEnumerator UpdateResources()
    {
        //Assigning strings from the text
        //Init form and give them the email and password
        WWWForm form = new WWWForm();
        form.AddField("patient_ID", AppManager.instance.User.ID);
        form.AddField("tries", MemoryManager.instance.tries);
        form.AddField("memory_ID", MemoryManager.instance._currentmemory.ID);

        Debug.Log("UPDATING RESOURCES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        //Login to the website and wait for a response
        WWW w = new WWW("http://81.169.177.181/RT/PHP/update_resources.php", form);
        yield return w;

        //Check if the response if empty or not
        if (string.IsNullOrEmpty(w.error))
        {
            Debug.Log("w.text: " + w.text);
            //Return the json array and put it in the C# User class
            Check check = JsonUtility.FromJson<Check>(w.text);
            if (check.success == true)
            {
                //Check if there is any error in the class. If there is return the error
                if (check.error != "")
                {
                    Debug.LogError("An error occured.. " + check.error);
                }
                else
                {
                    //Login the user and redirect it to a new scene
                    Debug.Log("Succes! Uploaded measurement!");
                }
                //If the JsonArary is empty return this string in the feedback
            }
            else
            {
                Debug.LogError("An error occured.");
            }

            //If the string is empty return this string in the feedback
        }
        else
        {
            // error
            Debug.LogError("An error occured.");
        }

    }

}
public class Check
{
    public bool success;
    public string error;
}
