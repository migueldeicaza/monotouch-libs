//
// Binding to the GANTracker.h Google Analytics iPhone SDK from Google
//
// MIT X11 licensed
//
// Copyright 2009 Novell, Inc.
//
using System;
using MonoTouch.Foundation;

namespace GoogleAnalytics {

	[BaseType (typeof (NSObject))]
	interface GANTracker {
		[Static][Export ("sharedTracker")]
		GANTracker SharedTracker { get; }

		[Export ("startTrackerWithAccountID:dispatchPeriod:delegate:")]
		void StartTracker (string accountiD, int dispatchPeriod, [NullAllowed] GANTrackerDelegate ganDelegate);

		[Export ("stopTracker")]
		void StopTracker ();

		[Export ("trackPageview:withError:"), Internal]
		bool _TrackPageView (string pageUrl, IntPtr nsErrorPtr);

		[Export ("trackEvent:action:label:value:withError:"), Internal]
		bool _TrackEvent (string category, string action, string label, int value, IntPtr nsErrorPtr);

		[Export ("dispatch")]
		bool Dispatch ();
	}

	[BaseType (typeof (NSObject))]
	interface GANTrackerDelegate {
		[Export ("trackerDispatchDidComplete:eventsDispatched:eventsFailedDispatch:")]
		void DispatchCompleted (GANTracker tracker, int eventsDispatched, int eventsFailedDispatch);
	}
	
}