using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/SpotifyNativeAuthUtil", DoNotGenerateAcw=true)]
	public partial class SpotifyNativeAuthUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/SpotifyNativeAuthUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpotifyNativeAuthUtil); }
		}

		protected SpotifyNativeAuthUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']/constructor[@name='SpotifyNativeAuthUtil' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", "")]
		public unsafe SpotifyNativeAuthUtil (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SpotifyNativeAuthUtil)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args);
			} finally {
			}
		}

		static Delegate cb_startAuthActivity;
#pragma warning disable 0169
		static Delegate GetStartAuthActivityHandler ()
		{
			if (cb_startAuthActivity == null)
				cb_startAuthActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartAuthActivity);
			return cb_startAuthActivity;
		}

		static bool n_StartAuthActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartAuthActivity ();
		}
#pragma warning restore 0169

		static IntPtr id_startAuthActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']/method[@name='startAuthActivity' and count(parameter)=0]"
		[Register ("startAuthActivity", "()Z", "GetStartAuthActivityHandler")]
		public virtual unsafe bool StartAuthActivity ()
		{
			if (id_startAuthActivity == IntPtr.Zero)
				id_startAuthActivity = JNIEnv.GetMethodID (class_ref, "startAuthActivity", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startAuthActivity);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAuthActivity", "()Z"));
			} finally {
			}
		}

		static Delegate cb_stopAuthActivity;
#pragma warning disable 0169
		static Delegate GetStopAuthActivityHandler ()
		{
			if (cb_stopAuthActivity == null)
				cb_stopAuthActivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAuthActivity);
			return cb_stopAuthActivity;
		}

		static void n_StopAuthActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAuthActivity ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAuthActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']/method[@name='stopAuthActivity' and count(parameter)=0]"
		[Register ("stopAuthActivity", "()V", "GetStopAuthActivityHandler")]
		public virtual unsafe void StopAuthActivity ()
		{
			if (id_stopAuthActivity == IntPtr.Zero)
				id_stopAuthActivity = JNIEnv.GetMethodID (class_ref, "stopAuthActivity", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAuthActivity);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAuthActivity", "()V"));
			} finally {
			}
		}

	}
}
