package xamarin.forms.platform.android;


public class BaseCellView
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.BaseCellView, Xamarin.Forms.Platform.Android, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null", BaseCellView.class, __md_methods);
	}


	public BaseCellView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == BaseCellView.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.BaseCellView, Xamarin.Forms.Platform.Android, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public BaseCellView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == BaseCellView.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.BaseCellView, Xamarin.Forms.Platform.Android, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public BaseCellView (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == BaseCellView.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.BaseCellView, Xamarin.Forms.Platform.Android, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
