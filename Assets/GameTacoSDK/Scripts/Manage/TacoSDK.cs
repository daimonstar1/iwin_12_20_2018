using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTacoSDK
{
	public class TacoSDK : SingletonMono<TacoSDK>
	{

		public void Init ()
		{
			Instantiate (Resources.Load<GameObject> ("Prefabs/LoginPanel"));
		}
	}
}
