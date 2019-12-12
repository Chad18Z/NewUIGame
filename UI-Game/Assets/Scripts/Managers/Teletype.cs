using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Teletype : MonoBehaviour
{
    // Get reference to the Text mesh pro component
    [SerializeField]
    GameObject messageText;

    AudioSource SoundEffectSource;

    TextMeshProUGUI textBox;

    // Animation curve for the fadeout
    [SerializeField]
    AnimationCurve fadeOutCurve;

    // Fade-out rate
    float fadeRate = .02f;

    Coroutine display;


    private void OnEnable()
    {
        //messageText = GameObject.FindGameObjectWithTag("textMeshDialog");
        SoundEffectSource = gameObject.GetComponent<AudioSource>();
        textBox = messageText.GetComponent<TextMeshProUGUI>();
    }

    public void ShowMessage(string message)
    {
        textBox.maxVisibleCharacters = 0;
        textBox.alpha = 1;
        textBox.text = message;
        StartCoroutine(DisplayMessage(message));
    }



    // Fades the text away
    IEnumerator FadeOut()
    {
        float counter = 0;
        while (counter <= 1)
        {
            textBox.alpha = fadeOutCurve.Evaluate(counter);
            counter += fadeRate;
            yield return null;
        }
        textBox.text = "";
        textBox.alpha = 0;

        yield return null;
    }

    IEnumerator DisplayMessage(string message)
    {
        bool skip = false;
        SoundEffectSource.loop = true;
        yield return new WaitForSeconds(.1f);
        int totalVisibleCharacters = textBox.textInfo.characterCount;
        int counter = 0;
        bool quit = false;
        SoundEffectSource.Play();
        while (!quit)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);

            // Allow player to mouse-button through text
            if (Input.GetMouseButton(0))
            {
                visibleCount = totalVisibleCharacters;
                skip = true;
            }

            textBox.maxVisibleCharacters = visibleCount;
            if (visibleCount >= totalVisibleCharacters)
            {
                SoundEffectSource.loop = false;
                if (!skip)
                {
                    yield return new WaitForSeconds(1.9f);
                }
                else quit = true;
            }
            counter += 1;
            yield return new WaitForSeconds(.01f);
        }

        SoundEffectSource.Stop();
        StartCoroutine(FadeOut());

        yield return null;
    }
}
