using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringScripts : MonoBehaviour
{
    public string StringToLower(string inputString)
    {
        inputString = inputString.ToLower();

        return inputString;
    }

  //  public static string FirstCharToUpper(string input)
  //  {
     //   if (String.IsNullOrEmpty(input))
    //  throw new ArgumentException("ARGH!");
     //   return input.First().ToString().ToUpper() + input.Substring(1);
   // }
}
