﻿using System;
using System.ComponentModel;

namespace WinDirStat.Net.Services.Structures {
	/// <summary>How icons are stored and displayed.</summary>
	[Serializable]
	public enum IconCacheMode : byte {
		/// <summary>Don't show icons.</summary>
		[Description("Don't show icons")]
		None,
		/// <summary>Use default icons (File/Folder/Drive/Computer).</summary>
		[Description("Use default icons")]
		Basic,
		/// <summary>Use file type icons.</summary>
		[Description("Use file type icons")]
		FileType,
		/// <summary>Use individual icons.</summary>
		[Description("Individual icons")]
		Individual,
		/// <summary>Use individual icons with overlays.</summary>
		//[Description("Individual icons with overlays")]
		//IndividualOverlays,
	}

	/// <summary>The states for caching an icon.</summary>
	public enum IconCacheState : byte {
		/// <summary>The icon has not been cached yet.</summary>
		NotCached,
		/// <summary>An asynchronous operation is running to cache the icon.</summary>
		Caching,
		/// <summary>The icon has been cached at its highest level.</summary>
		Cached,
	}
	
	/// <summary>A structure containing both a cached icon and name.</summary>
	public class IIconAndName {
		/// <summary>The returned icon.</summary>
		public IImage Icon { get; }
		/// <summary>The returned name.</summary>
		public string Name { get; }

		/// <summary>Constructs a new <see cref="IconAndName"/>.</summary>
		/// 
		/// <param name="icon">The icon to use.</param>
		/// <param name="name">The name to use.</param>
		public IIconAndName(IImage icon, string name) {
			Icon = icon;
			Name = name;
		}
	}

	/// <summary>The callback delegate for caching an icon.</summary>
	/// 
	/// <param name="icon">The returned icon.</param>
	public delegate void ICacheIconCallback(IImage icon);
	/// <summary>The callback delegate for caching an icon and name.</summary>
	/// 
	/// <param name="iconName">The returned icon and name.</param>
	public delegate void ICacheIconAndNameCallback(IIconAndName iconName);
}
