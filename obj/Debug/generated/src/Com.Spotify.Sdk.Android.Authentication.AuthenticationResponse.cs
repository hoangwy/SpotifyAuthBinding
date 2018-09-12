using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse", DoNotGenerateAcw=true)]
	public partial class AuthenticationResponse : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationResponse$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/constructor[@name='AuthenticationResponse.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
			{
				if (cb_setAccessToken_Ljava_lang_String_ == null)
					cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
				return cb_setAccessToken_Ljava_lang_String_;
			}

			static IntPtr n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccessToken (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAccessToken_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetAccessToken_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetAccessToken (string p0)
			{
				if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAccessToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCode_Ljava_lang_String_Handler ()
			{
				if (cb_setCode_Ljava_lang_String_ == null)
					cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCode_Ljava_lang_String_);
				return cb_setCode_Ljava_lang_String_;
			}

			static IntPtr n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCode_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetCode (string p0)
			{
				if (id_setCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCode", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCode", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetError_Ljava_lang_String_Handler ()
			{
				if (cb_setError_Ljava_lang_String_ == null)
					cb_setError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetError_Ljava_lang_String_);
				return cb_setError_Ljava_lang_String_;
			}

			static IntPtr n_SetError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetError (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setError_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setError", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetError_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetError (string p0)
			{
				if (id_setError_Ljava_lang_String_ == IntPtr.Zero)
					id_setError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setError", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setError_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setError", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setExpiresIn_I;
#pragma warning disable 0169
			static Delegate GetSetExpiresIn_IHandler ()
			{
				if (cb_setExpiresIn_I == null)
					cb_setExpiresIn_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetExpiresIn_I);
				return cb_setExpiresIn_I;
			}

			static IntPtr n_SetExpiresIn_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetExpiresIn (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setExpiresIn_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setExpiresIn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpiresIn", "(I)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetExpiresIn_IHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetExpiresIn (int p0)
			{
				if (id_setExpiresIn_I == IntPtr.Zero)
					id_setExpiresIn_I = JNIEnv.GetMethodID (class_ref, "setExpiresIn", "(I)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setExpiresIn_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpiresIn", "(I)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetState_Ljava_lang_String_Handler ()
			{
				if (cb_setState_Ljava_lang_String_ == null)
					cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetState_Ljava_lang_String_);
				return cb_setState_Ljava_lang_String_;
			}

			static IntPtr n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setState_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetState_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetState (string p0)
			{
				if (id_setState_Ljava_lang_String_ == IntPtr.Zero)
					id_setState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_;
#pragma warning disable 0169
			static Delegate GetSetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Handler ()
			{
				if (cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ == null)
					cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_);
				return cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_;
			}

			static IntPtr n_SetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationResponse.Type']]"
			[Register ("setType", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetType (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type p0)
			{
				if (id_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ == IntPtr.Zero)
					id_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse$QueryParams", DoNotGenerateAcw=true)]
		public sealed partial class QueryParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='ACCESS_TOKEN']"
			[Register ("ACCESS_TOKEN")]
			public const string AccessToken = (string) "access_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='CODE']"
			[Register ("CODE")]
			public const string Code = (string) "code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const string Error = (string) "error";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='EXPIRES_IN']"
			[Register ("EXPIRES_IN")]
			public const string ExpiresIn = (string) "expires_in";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='STATE']"
			[Register ("STATE")]
			public const string State = (string) "state";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationResponse$QueryParams", ref java_class_handle);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='CODE']"
			[Register ("CODE")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Code {
				get {
					if (CODE_jfieldId == IntPtr.Zero)
						CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE", "Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EMPTY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='EMPTY']"
			[Register ("EMPTY")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Empty {
				get {
					if (EMPTY_jfieldId == IntPtr.Zero)
						EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='TOKEN']"
			[Register ("TOKEN")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Token {
				get {
					if (TOKEN_jfieldId == IntPtr.Zero)
						TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN", "Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationResponse$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;", "")]
			public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;", "")]
			public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
				try {
					return (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthenticationResponse); }
		}

		protected AuthenticationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/constructor[@name='AuthenticationResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe AuthenticationResponse (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AuthenticationResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		static IntPtr id_getError;
		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getError", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static int n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresIn;
		public virtual unsafe int ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()I", "GetGetExpiresInHandler")]
			get {
				if (id_getExpiresIn == IntPtr.Zero)
					id_getExpiresIn = JNIEnv.GetMethodID (class_ref, "getExpiresIn", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getExpiresIn);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiresIn", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static IntPtr id_fromUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='fromUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("fromUri", "(Landroid/net/Uri;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse FromUri (global::Android.Net.Uri p0)
		{
			if (id_fromUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_fromUri_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "fromUri", "(Landroid/net/Uri;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
