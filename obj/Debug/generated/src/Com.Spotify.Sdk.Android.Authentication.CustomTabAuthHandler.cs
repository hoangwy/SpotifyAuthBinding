using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/CustomTabAuthHandler", DoNotGenerateAcw=true)]
	public partial class CustomTabAuthHandler : global::Java.Lang.Object, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/CustomTabAuthHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomTabAuthHandler); }
		}

		protected CustomTabAuthHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/constructor[@name='CustomTabAuthHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomTabAuthHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CustomTabAuthHandler)) {
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

		static Delegate cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_Handler ()
		{
			if (cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ == null)
				cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_);
			return cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
		}

		static void n_SetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener p0 = (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompleteListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/method[@name='setOnCompleteListener' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationHandler.OnCompleteListener']]"
		[Register ("setOnCompleteListener", "(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V", "GetSetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_Handler")]
		public virtual unsafe void SetOnCompleteListener (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener p0)
		{
			if (id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ == IntPtr.Zero)
				id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompleteListener", "(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCompleteListener", "(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_Handler ()
		{
			if (cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == null)
				cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_);
			return cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		}

		static bool n_Start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("start", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z", "GetStart_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_Handler")]
		public virtual unsafe bool Start (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1)
		{
			if (id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
				id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener"
		public event EventHandler Cancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIAuthenticationHandlerOnCompleteListenerImplementor,
						SetOnCompleteListener,
						__h => __h.OnCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.OnCancelHandler -= value);
			}
		}

		public event EventHandler<global::Com.Spotify.Sdk.Android.Authentication.CompleteEventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIAuthenticationHandlerOnCompleteListenerImplementor,
						SetOnCompleteListener,
						__h => __h.OnCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.OnCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Com.Spotify.Sdk.Android.Authentication.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIAuthenticationHandlerOnCompleteListenerImplementor,
						SetOnCompleteListener,
						__h => __h.OnErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.OnErrorHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCompleteListener;

		global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor __CreateIAuthenticationHandlerOnCompleteListenerImplementor ()
		{
			return new global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor (this);
		}
#endregion
	}
}
