﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TAPI.SDK
{
    /// <summary>
    /// Represents a weak reference, which references an object while still allowing
    /// that object to be reclaimed by garbage collection.
    /// </summary>
    /// <typeparam name="T">The type of the referenced object</typeparam>
	public class WeakReference<T> : WeakReference where T : class
	{
        /// <summary>
        /// Initializes a new instance of the TAPI.SDK.WeakReference class, referencing
        /// the specified object.
        /// </summary>
        /// <param name="target">The object to track or null.</param>
		public WeakReference(T target)
			: base(target)
		{

		}
        /// <summary>
        /// Initializes a new instance of the TAPI.SDK.WeakReference class, referencing
        /// the specified object and using the specified resurrection tracking.
        /// </summary>
        /// <param name="target">An object to track.</param>
        /// <param name="trackResurrection">Indicates when to stop tracking the object. If true, the object is tracked after finalization; if false, the object is only tracked until finalization.</param>
		public WeakReference(T target, bool trackResurrection)
			: base(target, trackResurrection)
		{

		}

        /// <summary>
        /// Gets or sets the object (the target) referenced by the current TAPI.SDK.WeakReference object.
        ///
        /// Returns:
        ///     null if the object referenced by the current TAPI.SDK.WeakReference object
        ///     has been garbage collected; otherwise, a reference to the object referenced
        ///     by the current TAPI.SDK.WeakReference object.
        /// <exception cref="System.InvalidOperationException">The reference to the target object is invalid. This exception can be thrown while setting this property if the value is a null reference or if the object has been finalized during the set operation.</exception>
		public new T Target
		{
			get
			{
				return base.Target as T;
			}
			set
			{
				base.Target = value;
			}
		}
	}
}
