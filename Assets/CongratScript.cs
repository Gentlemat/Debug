using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh text;
    public ParticleSystem sparksParticles;
    
    private float rotatingSpeed = 50.0f;
    private int currentText = 0;
    private float timeToNextText = 1.5f;

    private List<string> textToDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textToDisplay = new List<string>();

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        text.text = textToDisplay[currentText];

        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextText -= Time.deltaTime;

        sparksParticles.transform.Rotate(Vector3.up, rotatingSpeed * Time.deltaTime);

        if (timeToNextText < 0)
        {
            currentText++;
            if (currentText >= textToDisplay.Count)
                currentText = 0;
        
            timeToNextText = 1.5f;
            text.text = textToDisplay[currentText];
        }
    }
}