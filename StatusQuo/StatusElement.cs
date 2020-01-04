#region License
// Copyright 2020 NightEule5
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion
using System;

namespace StatusQuo
{
	/// <summary>
	/// Provides a default implementation for <see cref="IStatusElement"/>.
	/// </summary>
	public abstract class StatusElement : IStatusElement
	{
		public event EventHandler ContentUpdated;

		public int MaxWidth { get; set; }
		public int MaxHeight { get; set; }

		public int Render(int start, bool soft = false)
			=> soft ? SoftRender(start) : HardRender(start);

		public abstract int SoftRender(int start);
		public abstract int HardRender(int start);

		/// <summary>
		/// Signals an update by firing the <see cref="ContentUpdated"/> event.
		/// Call this whenever status changes to trigger a soft render.
		/// </summary>
		protected void SignalUpdate()
			=> ContentUpdated?.Invoke(this, new EventArgs());
	}
}
