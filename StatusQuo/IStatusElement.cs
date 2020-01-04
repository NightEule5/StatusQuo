#region License
// Copyright 2019-2020 NightEule5
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
	/// Exposes an interface for status elements. These are the constructs that
	/// specify how status is displayed and manipulated.
	/// </summary>
	public interface IStatusElement
	{
		/// <summary>
		/// An event fired when the element's content has been updated, to trigger
		/// a soft render.
		/// </summary>
		event EventHandler ContentUpdated;

		int MaxWidth { get; set; }
		int MaxHeight { get; set; }

		/// <summary>
		/// Renders the element at the specified line.
		/// </summary>
		/// <param name="start">
		/// The line the element should be rendered on.
		/// </param>
		/// <param name="soft">
		/// True for a soft render, where the element has already been rendered
		/// and the content needs to be updated; false for a hard render, where
		/// everything needs to be rendered.
		/// </param>
		/// <returns>
		/// The total number of lines the element encompasses.
		/// </returns>
		int Render(int start, bool soft = false);
	}
}
