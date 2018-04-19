using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class VoiceManager : MonoBehaviour {
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
    // Use this for initialization
    void Start () {

        keywords.Add("Yes", () =>
        {
            GameObject.Find("yes_button_welcome").SendMessageUpwards("OnSelect", SendMessageOptions.DontRequireReceiver);
        });

        keywords.Add("More", () =>
        {
            GameObject.Find("more").SendMessageUpwards("OnSelect", SendMessageOptions.DontRequireReceiver);
        });

        keywords.Add("GE", () =>
        {
            GameObject.Find("news_title_2_invisible").SendMessageUpwards("OnSelect", SendMessageOptions.DontRequireReceiver);
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
	}
	
    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}
