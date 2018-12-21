using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTacoSDK
{
	public interface ITacoLoadingState
	{
		void showLoading (string message);

		void hideLoading (string message);
	}

	public class TacoManageLoadingView : MonoBehaviour,ITacoLoadingState
	{
		#region ITacoLoadingState implementation

		public void showLoading (string message)
		{
			Debug.Log (message);
		}

		public void hideLoading (string message)
		{
			Debug.Log (message);
		}

		#endregion


	}
}
