//
// Binding to the GANTracker.h Google Analytics iPhone SDK from Google
//
// MIT X11 licensed
//
// Copyright 2009 Novell, Inc.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace GoogleAnalytics {

	public partial class GANTracker {

		public bool TrackPageView (string url, out NSError nsError)
		{
			unsafe {
				IntPtr error;
				IntPtr ptr_to_error = (IntPtr) (&error);

				var ret = _TrackPageView (url, (IntPtr) ptr_to_error);
				if (error != IntPtr.Zero)
					nsError = (NSError) Runtime.GetNSObject (error);
				else
					nsError = null;
				return ret;
			}
		}

		public bool TrackEvent (string category, string action, string label, int value, out NSError nsError)
		{
			unsafe {
				IntPtr error;
				IntPtr ptr_to_error = (IntPtr) (&error);

				var ret = _TrackEvent (category, action, label, value, (IntPtr) ptr_to_error);
				if (error != IntPtr.Zero)
					nsError = (NSError) Runtime.GetNSObject (error);
				else
					nsError = null;
				return ret;
			}
		}
		
	}
}