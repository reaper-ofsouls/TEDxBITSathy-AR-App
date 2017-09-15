using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.EventSystems;
 
public class ButtonPopup : MonoBehaviour, ITrackableEventHandler {
     
    private TrackableBehaviour mTrackableBehaviour;
     
    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(100,100,240,60);
     
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
     
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
        }
        else
        {
            mShowGUIButton = false;
        }
    }
     
    void OnGUI() {
        if (mShowGUIButton) {
            
            // draw the GUI button
            
            if (GUI.Button(mButtonRect, "Check Me Out")) {
                
                if((gameObject.name).Equals("Target 1")){

                	Application.OpenURL("https://www.ted.com/tedx/events/22079");
                	Debug.Log("Button Clicked");
                }

                else if((gameObject.name).Equals("Target 2")){

                	Application.OpenURL("https://www.ted.com/talks/shah_rukh_khan_thoughts_on_humanity_fame_and_love");
                	Debug.Log("Button Clicked");
                }

                else if((gameObject.name).Equals("Target 3")){

                	Application.OpenURL("https://www.ted.com/talks/pranav_mistry_the_thrilling_potential_of_sixthsense_technology");
                	Debug.Log("Button Clicked");
                }

                else{

                	Application.OpenURL("https://ed.ted.com/");
                	Debug.Log("Button Clicked");
                }
            }
        }
    }
}