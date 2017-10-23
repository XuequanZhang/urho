// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Button.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Gui
{
	/// <summary>
	/// Push button %UI element.
	/// </summary>
	public unsafe partial class Button : BorderImage
	{
		unsafe partial void OnButtonCreated ();

		[Preserve]
		public Button (IntPtr handle) : base (handle)
		{
			OnButtonCreated ();
		}

		[Preserve]
		protected Button (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnButtonCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Button_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Button_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Button_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Button_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Button_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Button));
			return new StringHash (Button_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Button_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Button));
			return Marshal.PtrToStringAnsi (Button_GetTypeNameStatic ());
		}

		[Preserve]
		public Button () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Button_Button (IntPtr context);

		[Preserve]
		public Button (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Button));
			handle = Button_Button ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnButtonCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Button));
			Button_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_Update (IntPtr handle, float timeStep);

		/// <summary>
		/// Perform UI element update.
		/// </summary>
		public override void Update (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			Button_Update (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_OnClickBegin (IntPtr handle, ref Urho.IntVector2 position, ref Urho.IntVector2 screenPosition, int button, int buttons, int qualifiers, IntPtr cursor);

		/// <summary>
		/// React to mouse click begin.
		/// </summary>
		public override void OnClickBegin (Urho.IntVector2 position, Urho.IntVector2 screenPosition, int button, int buttons, int qualifiers, Cursor cursor)
		{
			Runtime.ValidateRefCounted (this);
			Button_OnClickBegin (handle, ref position, ref screenPosition, button, buttons, qualifiers, (object)cursor == null ? IntPtr.Zero : cursor.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_OnClickEnd (IntPtr handle, ref Urho.IntVector2 position, ref Urho.IntVector2 screenPosition, int button, int buttons, int qualifiers, IntPtr cursor, IntPtr beginElement);

		/// <summary>
		/// React to mouse click end.
		/// </summary>
		public override void OnClickEnd (Urho.IntVector2 position, Urho.IntVector2 screenPosition, int button, int buttons, int qualifiers, Cursor cursor, UIElement beginElement)
		{
			Runtime.ValidateRefCounted (this);
			Button_OnClickEnd (handle, ref position, ref screenPosition, button, buttons, qualifiers, (object)cursor == null ? IntPtr.Zero : cursor.Handle, (object)beginElement == null ? IntPtr.Zero : beginElement.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_OnKey (IntPtr handle, int key, int buttons, int qualifiers);

		/// <summary>
		/// React to a key press.
		/// </summary>
		public override void OnKey (int key, int buttons, int qualifiers)
		{
			Runtime.ValidateRefCounted (this);
			Button_OnKey (handle, key, buttons, qualifiers);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetPressedOffset (IntPtr handle, ref Urho.IntVector2 offset);

		/// <summary>
		/// Set offset to image rectangle used when pressed.
		/// </summary>
		private void SetPressedOffset (Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetPressedOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetPressedOffset0 (IntPtr handle, int x, int y);

		/// <summary>
		/// Set offset to image rectangle used when pressed.
		/// </summary>
		public void SetPressedOffset (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetPressedOffset0 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetDisabledOffset (IntPtr handle, ref Urho.IntVector2 offset);

		/// <summary>
		/// Set offset to image rectangle used when disabled.
		/// </summary>
		private void SetDisabledOffset (Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetDisabledOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetDisabledOffset1 (IntPtr handle, int x, int y);

		/// <summary>
		/// Set offset to image rectangle used when disabled.
		/// </summary>
		public void SetDisabledOffset (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetDisabledOffset1 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetPressedChildOffset (IntPtr handle, ref Urho.IntVector2 offset);

		/// <summary>
		/// Set offset of child elements when pressed.
		/// </summary>
		private void SetPressedChildOffset (Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetPressedChildOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetPressedChildOffset2 (IntPtr handle, int x, int y);

		/// <summary>
		/// Set offset of child elements when pressed.
		/// </summary>
		public void SetPressedChildOffset (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetPressedChildOffset2 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetRepeat (IntPtr handle, float delay, float rate);

		/// <summary>
		/// Set repeat properties. Rate 0 (default) disables repeat.
		/// </summary>
		public void SetRepeat (float delay, float rate)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetRepeat (handle, delay, rate);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetRepeatDelay (IntPtr handle, float delay);

		/// <summary>
		/// Set repeat delay.
		/// </summary>
		private void SetRepeatDelay (float delay)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetRepeatDelay (handle, delay);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Button_SetRepeatRate (IntPtr handle, float rate);

		/// <summary>
		/// Set repeat rate.
		/// </summary>
		private void SetRepeatRate (float rate)
		{
			Runtime.ValidateRefCounted (this);
			Button_SetRepeatRate (handle, rate);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Button_GetPressedOffset (IntPtr handle);

		/// <summary>
		/// Return pressed image offset.
		/// </summary>
		private Urho.IntVector2 GetPressedOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Button_GetPressedOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Button_GetDisabledOffset (IntPtr handle);

		/// <summary>
		/// Return disabled image offset.
		/// </summary>
		private Urho.IntVector2 GetDisabledOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Button_GetDisabledOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Button_GetPressedChildOffset (IntPtr handle);

		/// <summary>
		/// Return offset of child elements when pressed.
		/// </summary>
		private Urho.IntVector2 GetPressedChildOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Button_GetPressedChildOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Button_GetRepeatDelay (IntPtr handle);

		/// <summary>
		/// Return repeat delay.
		/// </summary>
		private float GetRepeatDelay ()
		{
			Runtime.ValidateRefCounted (this);
			return Button_GetRepeatDelay (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Button_GetRepeatRate (IntPtr handle);

		/// <summary>
		/// Return repeat rate.
		/// </summary>
		private float GetRepeatRate ()
		{
			Runtime.ValidateRefCounted (this);
			return Button_GetRepeatRate (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Button_IsPressed (IntPtr handle);

		/// <summary>
		/// Return whether is currently pressed.
		/// </summary>
		public bool IsPressed ()
		{
			Runtime.ValidateRefCounted (this);
			return Button_IsPressed (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return pressed image offset.
		/// Or
		/// Set offset to image rectangle used when pressed.
		/// </summary>
		public Urho.IntVector2 PressedOffset {
			get {
				return GetPressedOffset ();
			}
			set {
				SetPressedOffset (value);
			}
		}

		/// <summary>
		/// Return disabled image offset.
		/// Or
		/// Set offset to image rectangle used when disabled.
		/// </summary>
		public Urho.IntVector2 DisabledOffset {
			get {
				return GetDisabledOffset ();
			}
			set {
				SetDisabledOffset (value);
			}
		}

		/// <summary>
		/// Return offset of child elements when pressed.
		/// Or
		/// Set offset of child elements when pressed.
		/// </summary>
		public Urho.IntVector2 PressedChildOffset {
			get {
				return GetPressedChildOffset ();
			}
			set {
				SetPressedChildOffset (value);
			}
		}

		/// <summary>
		/// Return repeat delay.
		/// Or
		/// Set repeat delay.
		/// </summary>
		public float RepeatDelay {
			get {
				return GetRepeatDelay ();
			}
			set {
				SetRepeatDelay (value);
			}
		}

		/// <summary>
		/// Return repeat rate.
		/// Or
		/// Set repeat rate.
		/// </summary>
		public float RepeatRate {
			get {
				return GetRepeatRate ();
			}
			set {
				SetRepeatRate (value);
			}
		}
	}
}
