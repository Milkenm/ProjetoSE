using System.Collections.Generic;

namespace ProjetoFinal
{
	public class LedStateManager<T>
	{
		private Dictionary<T, (string LedOn, string LedOff)> _objectToLedMap = new Dictionary<T, (string LedOn, string LedOff)>();
		private Dictionary<T, bool> _statesMap = new Dictionary<T, bool>();

		public LedStateManager<T> AddObject( T obj, string ledOn, string ledOff, bool initialState )
		{
			_objectToLedMap.Add( obj, (ledOn, ledOff) );
			_statesMap.Add( obj, initialState );

			return this;
		}

		public bool GetState( T obj )
		{
			return _statesMap[obj];
		}

		public void SetState( T obj, bool state )
		{
			_statesMap[obj] = state;
		}

		public bool ToggleState( T obj )
		{
			var newState = !_statesMap[obj];
			_statesMap[obj] = newState;
			return newState;
		}

		public string GetOnState( T obj )
		{
			return _objectToLedMap[obj].LedOn;
		}

		public string GetOffState( T obj )
		{
			return _objectToLedMap[obj].LedOff;
		}

		public string GetLedAction( T obj )
		{
			var actions = _objectToLedMap[obj];
			return _statesMap[obj] ? actions.LedOn : actions.LedOff;
		}
	}
}
