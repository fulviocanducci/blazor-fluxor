﻿using Blazor.Fluxor;

namespace CounterSample.Client.Store.Counter.IncrementCounter
{
	public class IncrementCounterReducer : IReducer<CounterState, IncrementCounterAction>
	{
		public CounterState Reduce(CounterState state, IncrementCounterAction action)
		{
			return new CounterState(state.ClickCount + 1);
		}
	}
}
