using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationRequest", DoNotGenerateAcw=true)]
	public partial class AuthenticationRequest : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationRequest$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationRequest$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/constructor[@name='AuthenticationRequest.Builder' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationResponse.Type'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;Ljava/lang/String;)V", "")]
			public unsafe Builder (string p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p2);
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
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/sdk/android/authentication/AuthenticationRequest;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/spotify/sdk/android/authentication/AuthenticationRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/spotify/sdk/android/authentication/AuthenticationRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCampaign_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCampaign_Ljava_lang_String_Handler ()
			{
				if (cb_setCampaign_Ljava_lang_String_ == null)
					cb_setCampaign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCampaign_Ljava_lang_String_);
				return cb_setCampaign_Ljava_lang_String_;
			}

			static IntPtr n_SetCampaign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCampaign (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCampaign_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setCampaign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCampaign", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetCampaign_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetCampaign (string p0)
			{
				if (id_setCampaign_Ljava_lang_String_ == IntPtr.Zero)
					id_setCampaign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCampaign", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCampaign_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCampaign", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCustomParam_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomParam_Ljava_lang_String_Ljava_lang_String_);
				return cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_SetCustomParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomParam (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCustomParam_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setCustomParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setCustomParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetCustomParam_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetCustomParam (string p0, string p1)
			{
				if (id_setCustomParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomParam_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_setScopes_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetScopes_arrayLjava_lang_String_Handler ()
			{
				if (cb_setScopes_arrayLjava_lang_String_ == null)
					cb_setScopes_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetScopes_arrayLjava_lang_String_);
				return cb_setScopes_arrayLjava_lang_String_;
			}

			static IntPtr n_SetScopes_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetScopes (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setScopes_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setScopes' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("setScopes", "([Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetScopes_arrayLjava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetScopes (string[] p0)
			{
				if (id_setScopes_arrayLjava_lang_String_ == IntPtr.Zero)
					id_setScopes_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScopes", "([Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setScopes_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScopes", "([Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_setShowDialog_Z;
#pragma warning disable 0169
			static Delegate GetSetShowDialog_ZHandler ()
			{
				if (cb_setShowDialog_Z == null)
					cb_setShowDialog_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShowDialog_Z);
				return cb_setShowDialog_Z;
			}

			static IntPtr n_SetShowDialog_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShowDialog (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setShowDialog_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setShowDialog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowDialog", "(Z)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetShowDialog_ZHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetShowDialog (bool p0)
			{
				if (id_setShowDialog_Z == IntPtr.Zero)
					id_setShowDialog_Z = JNIEnv.GetMethodID (class_ref, "setShowDialog", "(Z)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShowDialog_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowDialog", "(Z)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setState_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetState_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetState (string p0)
			{
				if (id_setState_Ljava_lang_String_ == IntPtr.Zero)
					id_setState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationRequest$QueryParams", DoNotGenerateAcw=true)]
		public sealed partial class QueryParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public const string ClientId = (string) "client_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='REDIRECT_URI']"
			[Register ("REDIRECT_URI")]
			public const string RedirectUri = (string) "redirect_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='RESPONSE_TYPE']"
			[Register ("RESPONSE_TYPE")]
			public const string ResponseType = (string) "response_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='SCOPE']"
			[Register ("SCOPE")]
			public const string Scope = (string) "scope";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='SHOW_DIALOG']"
			[Register ("SHOW_DIALOG")]
			public const string ShowDialog = (string) "show_dialog";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='STATE']"
			[Register ("STATE")]
			public const string State = (string) "state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='UTM_CAMPAIGN']"
			[Register ("UTM_CAMPAIGN")]
			public const string UtmCampaign = (string) "utm_campaign";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='UTM_MEDIUM']"
			[Register ("UTM_MEDIUM")]
			public const string UtmMedium = (string) "utm_medium";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='UTM_SOURCE']"
			[Register ("UTM_SOURCE")]
			public const string UtmSource = (string) "utm_source";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationRequest$QueryParams", ref java_class_handle);
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
				return JNIEnv.FindClass ("com/spotify/sdk/android/authentication/AuthenticationRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthenticationRequest); }
		}

		protected AuthenticationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/constructor[@name='AuthenticationRequest' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe AuthenticationRequest (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AuthenticationRequest)) {
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

		static Delegate cb_getCampaign;
#pragma warning disable 0169
		static Delegate GetGetCampaignHandler ()
		{
			if (cb_getCampaign == null)
				cb_getCampaign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaign);
			return cb_getCampaign;
		}

		static IntPtr n_GetCampaign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Campaign);
		}
#pragma warning restore 0169

		static IntPtr id_getCampaign;
		public virtual unsafe string Campaign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getCampaign' and count(parameter)=0]"
			[Register ("getCampaign", "()Ljava/lang/String;", "GetGetCampaignHandler")]
			get {
				if (id_getCampaign == IntPtr.Zero)
					id_getCampaign = JNIEnv.GetMethodID (class_ref, "getCampaign", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCampaign), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCampaign", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUri;
		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				if (id_getRedirectUri == IntPtr.Zero)
					id_getRedirectUri = JNIEnv.GetMethodID (class_ref, "getRedirectUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRedirectUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseType;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeHandler ()
		{
			if (cb_getResponseType == null)
				cb_getResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseType);
			return cb_getResponseType;
		}

		static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseType);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseType;
		public virtual unsafe string ResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getResponseType' and count(parameter)=0]"
			[Register ("getResponseType", "()Ljava/lang/String;", "GetGetResponseTypeHandler")]
			get {
				if (id_getResponseType == IntPtr.Zero)
					id_getResponseType = JNIEnv.GetMethodID (class_ref, "getResponseType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getState' and count(parameter)=0]"
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getCustomParam_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCustomParam_Ljava_lang_String_Handler ()
		{
			if (cb_getCustomParam_Ljava_lang_String_ == null)
				cb_getCustomParam_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCustomParam_Ljava_lang_String_);
			return cb_getCustomParam_Ljava_lang_String_;
		}

		static IntPtr n_GetCustomParam_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetCustomParam (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomParam_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getCustomParam' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCustomParam", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetCustomParam_Ljava_lang_String_Handler")]
		public virtual unsafe string GetCustomParam (string p0)
		{
			if (id_getCustomParam_Ljava_lang_String_ == IntPtr.Zero)
				id_getCustomParam_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCustomParam", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomParam_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomParam", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetScopes ());
		}
#pragma warning restore 0169

		static IntPtr id_getScopes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getScopes' and count(parameter)=0]"
		[Register ("getScopes", "()[Ljava/lang/String;", "GetGetScopesHandler")]
		public virtual unsafe string[] GetScopes ()
		{
			if (id_getScopes == IntPtr.Zero)
				id_getScopes = JNIEnv.GetMethodID (class_ref, "getScopes", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScopes), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScopes", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_toUri;
#pragma warning disable 0169
		static Delegate GetToUriHandler ()
		{
			if (cb_toUri == null)
				cb_toUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUri);
			return cb_toUri;
		}

		static IntPtr n_ToUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToUri ());
		}
#pragma warning restore 0169

		static IntPtr id_toUri;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='toUri' and count(parameter)=0]"
		[Register ("toUri", "()Landroid/net/Uri;", "GetToUriHandler")]
		public virtual unsafe global::Android.Net.Uri ToUri ()
		{
			if (id_toUri == IntPtr.Zero)
				id_toUri = JNIEnv.GetMethodID (class_ref, "toUri", "()Landroid/net/Uri;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUri), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
