///
// Binding to the Beachon.h Pinch Analytics SDK from Pinch Media
//
// MIT X11 licensed
//
// Copyright 2009 ChrisNTR
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace PinchMedia {

	[Static][BaseType (typeof (NSObject))]
	interface Beacon {

		[Static][Export ("initAndStartBeaconWithApplicationCode:useCoreLocation:useOnlyWiFi:enableDebugMode:")]
		Beacon StartBeacon(string theApplicationCode, bool useCoreLocation, bool useOnlyWiFi, bool enableDebugMode);

		[Static][Export ("initAndStartBeaconWithApplicationCode:useCoreLocation:useOnlyWiFi:")]
		Beacon StartBeacon (string theApplicationCode, bool useCoreLocation, bool useOnlyWiFi);

		[Static][Export ("endBeacon")]
		void EndBeacon();

		[Export ("startSubBeaconWithName:")]
		void StartSubBeacon(string subBeaconName);

		[Export ("startTimedSubBeaconWithName:")]
		void StartTimedSubBeacon(string subBeaconName);
		
		[Export ("startSubBeaconWithName:timeSession:")]
		void StartSubBeacon(string subBeaconName, bool timeSession);

		[Export ("endSubBeaconWithName:")]
		void EndSubBeacon(string subBeaconName);

		[Export ("setBeaconLocation:")]
		void SetBeaconLocation(CLLocation newLocation);

		[Static][Export ("shared")]
		Beacon Shared { get; }
		
		//[Wrap ("WeakDelegate")]  
		//CLLocationManagerDelegate Delegate { get; set; }  
		
		//[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]  
		//NSObject WeakDelegate { get; set; }  
	}
}
