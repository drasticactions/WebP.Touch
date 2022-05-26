using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace WebP.Touch
{
	[BaseType (typeof(NSObject))]
	[Internal]
	[Protocol]
	internal interface WebPDecoder
	{
        [Export ("imageWithWebP:error:")]
        UIImage ImageWithWebP (string filePath, out NSError error);

        [Export ("imageWithWebPData:error:")]
        UIImage ImageWithWebPData (NSData imgData, out NSError error);

        [Export("getVersion")]
        int GetVersion();
	}
}
