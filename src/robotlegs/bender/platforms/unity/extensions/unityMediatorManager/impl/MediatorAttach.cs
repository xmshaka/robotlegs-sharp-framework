//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections.Generic;

namespace robotlegs.bender.platforms.unity.extensions.unityMediatorManager.impl
{
	public class MediatorAttach : MonoBehaviour
	{
		/*============================================================================*/
		/* Public Properties                                                          */
		/*============================================================================*/

		public event Action<object> AddedMediator;

		public event Action<object> RemovedMediator;

		public object[] Mediators
		{
			get
			{
				return _mediators;
			}
		}

		public object View
		{
			get
			{
				return _view;
			}
		}

		/*============================================================================*/
		/* Private Properties                                                         */
		/*============================================================================*/
		
		private object[] _mediators = new object[0];
		
		private object _view;

		/*============================================================================*/
		/* Private Functions                                                          */
		/*============================================================================*/

		public void SetView(object view)
		{
			_view = view;
		}

		public void AddMediator(object mediator)
		{
			List<object> newMediators = new List<object> (_mediators);
			newMediators.Add (mediator);
			_mediators = newMediators.ToArray();
			if (AddedMediator != null) 
			{
				AddedMediator(mediator);
			}
		}

		public void RemoveMediator(object mediator)
		{
			List<object> newMediators = new List<object> (_mediators);
			if (newMediators.Remove (mediator)) 
			{
				_mediators = newMediators.ToArray();
				if (RemovedMediator != null) 
				{
					RemovedMediator(mediator);
				}
			}
		}
	}
}

