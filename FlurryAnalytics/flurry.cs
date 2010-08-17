//
//  Flurry iPhone Analytics Agent
//  use with libFlurryWithLocation.a  
//
//  MIT X11 licensed
//
// Copyright 2010 Kevin McMahon (http://twitter.com/klmcmahon)
//
using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace Flurry
{

	[BaseType (typeof (NSObject))]
	interface FlurryAPI {

		//+ (void)setAppVersion:(NSString *)version;		
		[Static, Export ("setAppVersion:")]
		void SetAppVersion (string version);

		//+ (NSString *)getFlurryAgentVersion;			
		[Static, Export ("getFlurryAgentVersion")]
		string GetFlurryAgentVersion { get; }

		//+ (void)setAppCircleEnabled:(BOOL)value;		
		[Static, Export ("setAppCircleEnabled:")]
		void SetAppCircleEnabled (bool value);

		//+ (void)setShowErrorInLogEnabled:(BOOL)value;	
		[Static, Export ("setShowErrorInLogEnabled:")]
		void SetShowErrorInLogEnabled (bool value);

		//+ (void)unlockDebugMode:(NSString*)debugModeKey apiKey:(NSString *)apiKey;	
		[Static, Export ("unlockDebugMode:apiKey:")]
		void UnlockDebugMode (string debugModeKey, string apiKey);

		//+ (void)setPauseSecondsBeforeStartingNewSession:(int)seconds; 
		[Static, Export ("setPauseSecondsBeforeStartingNewSession:")]
		void SetPauseSecondsBeforeStartingNewSession (int seconds);

		//+ (void)startSession:(NSString *)apiKey;
		[Static, Export ("startSession:")]
		void StartSession (string apiKey);

		//+ (void)logEvent:(NSString *)eventName;
		[Static, Export ("logEvent:")]
		void LogEvent (string eventName);

		//+ (void)logEvent:(NSString *)eventName withParameters:(NSDictionary *)parameters;
		[Static, Export ("logEvent:withParameters:")]
		void LogEvent (string eventName, NSDictionary parameters);

		//+ (void)logError:(NSString *)errorID message:(NSString *)message exception:(NSException *)exception;
		[Static, Export ("logError:message:exception:")]
		void LogError (string errorID, string message, NSException exception);

		//+ (void)logError:(NSString *)errorID message:(NSString *)message error:(NSError *)error;
		[Static, Export ("logError:message:error:")]
		void LogError (string errorID, string message, NSError error);

		//+ (void)logEvent:(NSString *)eventName timed:(BOOL)timed;
		[Static, Export ("logEvent:timed:")]
		void LogEvent (string eventName, bool timed);

		//+ (void)logEvent:(NSString *)eventName withParameters:(NSDictionary *)parameters timed:(BOOL)timed;
		[Static, Export ("logEvent:withParameters:timed:")]
		void LogEvent (string eventName, NSDictionary parameters, bool timed);

		//+ (void)endTimedEvent:(NSString *)eventName withParameters:(NSDictionary *)parameters;	
		[Static, Export ("endTimedEvent:withParameters:")]
		void EndTimedEvent (string eventName, NSDictionary parameters);

		//+ (void)countPageViews:(id)target;		
		[Static, Export ("countPageViews:")]
		void CountPageViews (NSObject target);

		//+ (void)countPageView;					
		[Static, Export ("countPageView")]
		void CountPageView ();

		//+ (void)setUserID:(NSString *)userID;	
		[Static, Export ("setUserID:")]
		void SetUserID (string userID);

		//+ (void)setAge:(int)age;				
		[Static, Export ("setAge:")]
		void SetAge (int age);

		//+ (void)setSessionReportsOnCloseEnabled:(BOOL)sendSessionReportsOnClose;	
		[Static, Export ("setSessionReportsOnCloseEnabled:")]
		void SetSessionReportsOnCloseEnabled (bool sendSessionReportsOnClose);

		//+ (void)setSessionReportsOnPauseEnabled:(BOOL)setSessionReportsOnPauseEnabled;	
		[Static, Export ("setSessionReportsOnPauseEnabled:")]
		void SetSessionReportsOnPauseEnabled (bool setSessionReportsOnPauseEnabled);

		//+ (void)setEventLoggingEnabled:(BOOL)value;		
		[Static, Export ("setEventLoggingEnabled:")]
		void SetEventLoggingEnabled (bool value);

		//+ (UIView *)getHook:(NSString *)hook xLoc:(int)x yLoc:(int)y view:(UIView *)view;
		[Static, Export ("getHook:xLoc:yLoc:view:")]
		UIView GetHook (string hook, int x, int y, UIView view);

		//+ (UIView *)getHook:(NSString *)hook xLoc:(int)x yLoc:(int)y view:(UIView *)view attachToView:(BOOL)attachToView orientation:(NSString *)orientation canvasOrientation:(NSString *)canvasOrientation autoRefresh:(BOOL)refresh canvasAnimated:(BOOL)canvasAnimated;
		[Static, Export ("getHook:xLoc:yLoc:view:attachToView:orientation:canvasOrientation:autoRefresh:canvasAnimated:")]
		UIView GetHook (string hook, int x, int y, UIView view, bool attachToView, string orientation, string canvasOrientation, bool refresh, bool canvasAnimated);

		//+ (void)updateHook:(UIView *)banner;
		[Static, Export ("updateHook:")]
		void UpdateHook (UIView banner);

		//+ (void)removeHook:(UIView *)banner;
		[Static, Export ("removeHook:")]
		void RemoveHook (UIView banner);

		//+ (void)openCatalog:(NSString *)hook canvasOrientation:(NSString *)canvasOrientation canvasAnimated:(BOOL)canvasAnimated;
		[Static, Export ("openCatalog:canvasOrientation:canvasAnimated:")]
		void OpenCatalog (string hook, string canvasOrientation, bool canvasAnimated);

		//+ (void)setAppCircleDelegate:(id)delegate;
		[Static, Export ("setAppCircleDelegate:")]
		void SetAppCircleDelegate (IntPtr appCircleDelegate);

	}
	[Model]

	[BaseType (typeof (NSObject))]
	interface FlurryAdDelegate {

		//@optional- (void)dataAvailable;
		[Abstract, Export ("dataAvailable")]
		void DataAvailable ();

		//- (void)dataUnavailable;
		[Abstract, Export ("dataUnavailable")]
		void DataUnavailable ();

		//- (void)canvasWillDisplay:(NSString *)hook;
		[Abstract, Export ("canvasWillDisplay:")]
		void CanvasWillDisplay (string hook);

		//- (void)canvasWillClose;
		[Abstract, Export ("canvasWillClose")]
		void CanvasWillClose ();

	}
}
