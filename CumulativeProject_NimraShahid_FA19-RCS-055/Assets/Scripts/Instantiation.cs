using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System.Collections.Specialized;

public class Instantiation : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    private Vector3 Cubes;
    private float radius = 1;
    private int numCubes = 10;
    public static int PalindromeCount;
    private static System.Random random = new System.Random();

    // private static Text text;

 
    // This script will simply instantiate the Prefab when the game starts.


    void Start()
    {
        int i = 0;
        List<string> results = RandomString();
        while (numCubes > 0)
        {
            
             Cubes = new Vector3(UnityEngine.Random.Range(-12, 12), UnityEngine.Random.Range(1.2f, 1.2f), UnityEngine.Random.Range(-18, 18));
            if (Physics.CheckSphere(Cubes, radius))
            {
            }
            else
            {
                Instantiate(myPrefab, Cubes, Quaternion.identity);
            
                myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = results[i];
                if (IsPalindrome(results[i]))
                {
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().color = Color.blue;
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().fontStyle = FontStyles.Bold;
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().fontSize = 6;
                }

                else
                {
                    myPrefab.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().color = Color.white;
                }

                i++;
                numCubes = numCubes - 1;
                

            }

        }
        


    }

    public static List<string> RandomString() {
        int x;
       List<string> list_of_strings = new List<string>();
        for (int i = 0; i <= 10; i++)
        {
            const string chars = "XN5";
            x = UnityEngine.Random.Range(9, 15);
            string val = new string(Enumerable.Repeat(chars, x)
              .Select(s => s[random.Next(s.Length)]).ToArray());

           
            list_of_strings.Add(val);
           

        }
        List<string> test = createPalindrome(list_of_strings);

        return test;
    }



    public static List<string> createPalindrome(List<string> val)
    {
        PalindromeCount = UnityEngine.Random.Range(3, 9);
        List<string> value = val;
        for (int i = 0; i < PalindromeCount; i++)
        {

            string first = val[i].Substring(0, val[i].Length / 2);
            char[] arr = first.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            val[i] = first + temp;
            value[i] = val[i];

        }

        return value;
    }

    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if (text[0] != text[text.Length - 1])
                return false;
            else
                return IsPalindrome(text.Substring(1, text.Length - 2));
        }
    }
}
