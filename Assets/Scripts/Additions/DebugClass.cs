using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLibrary.Additions
{

	public class DebugClass 
	{
		//Red
		public static void LogRed(string context){
		
			Debug.Log ("<color=Red>" + context + "</color>");
		}
		public static  void LogRed(string Message,Object context){

			Debug.Log ("<color=Red>" + Message + "</color>", context);
		}
		//Green

		public static void LogGreen(string context){

			Debug.Log ("<color=Green>" + context + "</color>");
		}
		public static  void LogGreen(string Message,Object context){

			Debug.Log ("<color=Green>" + Message + "</color>", context);
		}

		//Yellow

		public static void LogYellow(string context){

			Debug.Log ("<color=Yellow>" + context + "</color>");
		}
		public static  void LogYellow(string Message,Object context){

			Debug.Log ("<color=Yellow>" + Message + "</color>", context);
		}

		//Blue

		public static void LogBlue(string context){

			Debug.Log ("<color=Blue>" + context + "</color>");
		}
		public static  void LogBlue(string Message,Object context){

			Debug.Log ("<color=Blue>" + Message + "</color>", context);
		}

		//magenta

		public static void LogMagenta(string context){

			Debug.Log ("<color=Magenta>" + context + "</color>");
		}
		public static  void LogMagenta(string Message,Object context){

			Debug.Log ("<color=Magenta>" + Message + "</color>", context);
		}

		//Cyan

		public static void LogCyan(string context){

			Debug.Log ("<color=Cyan>" + context + "</color>");
		}
		public static  void LogCyan(string Message,Object context){

			Debug.Log ("<color=Cyan>" + Message + "</color>", context);
		}
	 
	}
}