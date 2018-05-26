//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// TestDeRendimiento.cs (26/05/2018)											\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase que tiene el puente del plugin						\\
// Fecha Mod:		26/05/2018)													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Runtime.InteropServices;
#endregion

namespace MoonAntonio
{
	public class TestDeRendimiento : MonoBehaviour 
	{
		public int size = 512;
		[DllImport("LowLevelPlugin")]
		private static extern int[,] fillArray(int size);

		private void Start()
		{
			ArrayFillTest();
		}

		private void ArrayFillTest()
		{
			var start = Time.realtimeSinceStartup;
			int[,] tab = fillArray(size);
			Debug.Log((Time.realtimeSinceStartup - start).ToString("f6") + " secs");
			start = Time.realtimeSinceStartup;
			int[,] array = new int[size, size];
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					array[i, j] = i * size + j;
				}
			}
			Debug.Log((Time.realtimeSinceStartup - start).ToString("f6") + " secs");
		}
	}
}