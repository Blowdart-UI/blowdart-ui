// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace Blowdart.UI
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + "}")]
    public abstract class RenderInstruction
    {
	    public int? Ordinal { get; protected set; }
		public abstract string DebuggerDisplay { get; }
    }
}
