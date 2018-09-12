using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationClient", DoNotGenerateAcw=true)]
	public partial class AuthenticationClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationClient$QueryParams", DoNotGenerateAcw=true)]
		public sealed partial class QueryParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='ID']"
			[Register ("ID")]
			public const string Id = (string) "id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='REFERRER']"
			[Register ("REFERRER")]
			public const string Referrer = (string) "referrer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='UTM_CAMPAIGN']"
			[Register ("UTM_CAMPAIGN")]
			public const string UtmCampaign = (string) "utm_campaign";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='UTM_MEDIUM']"
			[Register ("UTM_MEDIUM")]
			public const string UtmMedium = (string) "utm_medium";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='UTM_SOURCE']"
			[Register ("UTM_SOURCE")]
			public const string UtmSource = (string) "utm_source";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationClient$QueryParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QueryParams); }
			}

			internal QueryParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthenticationClient); }
		}

		protected AuthenticationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/constructor[@name='AuthenticationClient' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe AuthenticationClient (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AuthenticationClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_createLoginActivityIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='createLoginActivityIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("createLoginActivityIntent", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateLoginActivityIntent (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1)
		{
			if (id_createLoginActivityIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
				id_createLoginActivityIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetStaticMethodID (class_ref, "createLoginActivityIntent", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLoginActivityIntent_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getResponse_ILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='getResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("getResponse", "(ILandroid/content/Intent;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse GetResponse (int p0, global::Android.Content.Intent p1)
		{
			if (id_getResponse_ILandroid_content_Intent_ == IntPtr.Zero)
				id_getResponse_ILandroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getResponse", "(ILandroid/content/Intent;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResponse_ILandroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAvailable_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='isAvailable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("isAvailable", "(Landroid/content/Context;Landroid/content/Intent;)Z", "")]
		public static unsafe bool IsAvailable (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_isAvailable_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_isAvailable_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "isAvailable", "(Landroid/content/Context;Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAvailable_Landroid_content_Context_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_openDownloadSpotifyActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openDownloadSpotifyActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("openDownloadSpotifyActivity", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OpenDownloadSpotifyActivity (global::Android.App.Activity p0)
		{
			if (id_openDownloadSpotifyActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_openDownloadSpotifyActivity_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "openDownloadSpotifyActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openDownloadSpotifyActivity_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_openDownloadSpotifyActivity_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openDownloadSpotifyActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("openDownloadSpotifyActivity", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public static unsafe void OpenDownloadSpotifyActivity (global::Android.App.Activity p0, string p1)
		{
			if (id_openDownloadSpotifyActivity_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_openDownloadSpotifyActivity_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "openDownloadSpotifyActivity", "(Landroid/app/Activity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openDownloadSpotifyActivity_Landroid_app_Activity_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_openLoginActivity_Landroid_app_Activity_ILcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openLoginActivity' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("openLoginActivity", "(Landroid/app/Activity;ILcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", "")]
		public static unsafe void OpenLoginActivity (global::Android.App.Activity p0, int p1, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p2)
		{
			if (id_openLoginActivity_Landroid_app_Activity_ILcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
				id_openLoginActivity_Landroid_app_Activity_ILcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetStaticMethodID (class_ref, "openLoginActivity", "(Landroid/app/Activity;ILcom/spotify/sdk/android/authentication/AuthenticationRequest;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openLoginActivity_Landroid_app_Activity_ILcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args);
			} finally {
			}
		}

		static IntPtr id_openLoginInBrowser_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openLoginInBrowser' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("openLoginInBrowser", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", "")]
		public static unsafe void OpenLoginInBrowser (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1)
		{
			if (id_openLoginInBrowser_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
				id_openLoginInBrowser_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetStaticMethodID (class_ref, "openLoginInBrowser", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openLoginInBrowser_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args);
			} finally {
			}
		}

		static IntPtr id_stopLoginActivity_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='stopLoginActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("stopLoginActivity", "(Landroid/app/Activity;I)V", "")]
		public static unsafe void StopLoginActivity (global::Android.App.Activity p0, int p1)
		{
			if (id_stopLoginActivity_Landroid_app_Activity_I == IntPtr.Zero)
				id_stopLoginActivity_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "stopLoginActivity", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stopLoginActivity_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

	}
}
