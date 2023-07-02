using System.Collections.Generic;
using UnityEngine;

public class RandomStringsGenerator : MonoBehaviour
{
    private const int NumberOfStrings = 10000;

    private List<string> generatedStrings = new List<string>();

    private const int MinRandomNumber = 1;
    private const int MaxRandomNumber = 10000;

    private void Start()
    {
        for (int i = 0; i < NumberOfStrings; i++)
        {
            string randomString = Random.Range(MinRandomNumber, MaxRandomNumber).ToString();

            generatedStrings.Add(randomString);
        }

        ConcatenatePairs();
    }

    private void ConcatenatePairs()
    {
        if (generatedStrings.Count % 2 != 0)
        {
            Debug.LogError("The list must contain an even number of strings.");
            return;
        }

        for (int i = 0; i < generatedStrings.Count; i += 2)
        {
            string concatenatedString = generatedStrings[i] + generatedStrings[i + 1];

            // Output the concatenated string to the console for verification
            Debug.Log(concatenatedString);
        }
    }
}