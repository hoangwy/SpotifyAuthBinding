using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/LoginActivity", DoNotGenerateAcw=true)]
	public partial class LoginActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/field[@name='REQUEST_CODE']"
		[Register ("REQUEST_CODE")]
		public const int RequestCode = (int) 1138;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/field[@name='REQUEST_KEY']"
		[Register ("REQUEST_KEY")]
		public const string RequestKey = (string) "request";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/field[@name='RESPONSE_KEY']"
		[Register ("RESPONSE_KEY")]
		public const string ResponseKey = (string) "response";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/LoginActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoginActivity); }
		}

		protected LoginActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/constructor[@name='LoginActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoginActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LoginActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getAuthIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/method[@name='getAuthIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("getAuthIntent", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetAuthIntent (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1)
		{
			if (id_getAuthIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
				id_getAuthIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetStaticMethodID (class_ref, "getAuthIntent", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onClientCancelled;
#pragma warning disable 0169
		static Delegate GetOnClientCancelledHandler ()
		{
			if (cb_onClientCancelled == null)
				cb_onClientCancelled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClientCancelled);
			return cb_onClientCancelled;
		}

		static void n_OnClientCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.LoginActivity __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.LoginActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClientCancelled ();
		}
#pragma warning restore 0169

		static IntPtr id_onClientCancelled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/method[@name='onClientCancelled' and count(parameter)=0]"
		[Register ("onClientCancelled", "()V", "GetOnClientCancelledHandler")]
		public virtual unsafe void OnClientCancelled ()
		{
			if (id_onClientCancelled == IntPtr.Zero)
				id_onClientCancelled = JNIEnv.GetMethodID (class_ref, "onClientCancelled", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClientCancelled);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClientCancelled", "()V"));
			} finally {
			}
		}

		static Delegate cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
#pragma warning disable 0169
		static Delegate GetOnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Handler ()
		{
			if (cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ == null)
				cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_);
			return cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
		}

		static void n_OnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Authentication.LoginActivity __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.LoginActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClientComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/method[@name='onClientComplete' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationResponse']]"
		[Register ("onClientComplete", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V", "GetOnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Handler")]
		public virtual unsafe void OnClientComplete (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0)
		{
			if (id_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ == IntPtr.Zero)
				id_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ = JNIEnv.GetMethodID (class_ref, "onClientComplete", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClientComplete", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V"), __args);
			} finally {
			}
		}

	}
}
