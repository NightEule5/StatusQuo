﻿#region License
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
using System.Collections.Generic;
using System.Text;

namespace StatusQuo
{
	public sealed class StatusEngine
	{
		private List<IStatusElement> Elements;

		public StatusEngine(params IStatusElement[] elements)
			=> Elements = new List<IStatusElement>(elements);

		
	}
}
