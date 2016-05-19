﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timePast = 0f;
	public float totalGameTime = 30f;

	private float remainingTimeInSecs = 5.0f;
	private Text text;


	void Start() {
		text = GetComponent<Text> ();

		remainingTimeInSecs = totalGameTime;

	}


    void Update () {

	}

	public string FloatToTime (float toConvert, string format){
         switch (format){
//             case "00.0":
//                 return string.Format("{0:00}:{1:0}", 
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*10) % 10));//miliseconds
//             break;
//             case "#0.0":
//                 return string.Format("{0:#0}:{1:0}", 
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*10) % 10));//miliseconds
//             break;
             case "00.00":
                 return string.Format("{0:00}:{1:00}", 
                     Mathf.Floor(toConvert) % 60,//seconds
                     Mathf.Floor((toConvert*100) % 100));//miliseconds
             break;
//             case "00.000":
//                 return string.Format("{0:00}:{1:000}", 
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*1000) % 1000));//miliseconds
//             break;
//             case "#00.000":
//                 return string.Format("{0:#00}:{1:000}", 
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*1000) % 1000));//miliseconds
//             break;
//             case "#0:00":
//                 return string.Format("{0:#0}:{1:00}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60);//seconds
//             break;
//             case "#00:00":
//                 return string.Format("{0:#00}:{1:00}", 
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60);//seconds
//             break;
//             case "0:00.0":
//                 return string.Format("{0:0}:{1:00}.{2:0}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*10) % 10));//miliseconds
//             break;
//             case "#0:00.0":
//                 return string.Format("{0:#0}:{1:00}.{2:0}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*10) % 10));//miliseconds
//             break;
//             case "0:00.00":
//                 return string.Format("{0:0}:{1:00}.{2:00}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*100) % 100));//miliseconds
//             break;
//             case "#0:00.00":
//                 return string.Format("{0:#0}:{1:00}.{2:00}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*100) % 100));//miliseconds
//             break;
//             case "0:00.000":
//                 return string.Format("{0:0}:{1:00}.{2:000}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*1000) % 1000));//miliseconds
//             break;
//             case "#0:00.000":
//                 return string.Format("{0:#0}:{1:00}.{2:000}",
//                     Mathf.Floor(toConvert / 60),//minutes
//                     Mathf.Floor(toConvert) % 60,//seconds
//                     Mathf.Floor((toConvert*1000) % 1000));//miliseconds
//             break;
         }
         return "error";
     }

}
