#import <CoreGraphics/CoreGraphics.h>
#import "UnityAppController.h"
#import "UI/UnityView.h"

//Based on https://bitbucket.org/p12tic/iossafeareasplugin/src/default/Assets/Plugins/iOS/SafeAreaImpl.mm
extern "C" void GetSafeArea(float *x, float *y, float *width, float *height) {
	UIView* view = GetAppController().unityView;
	CGSize size = view.bounds.size;
	CGRect rect = CGRectMake(0, 0, size.width, size.height);
	
	UIEdgeInsets insets = UIEdgeInsetsMake(0, 0, 0, 0);
	if (@available(iOS 11, *)) {
		insets = [view safeAreaInsets];
	}
	
	rect.origin.x += insets.left;
	rect.origin.y += insets.bottom;
	rect.size.width -= insets.left + insets.right;
	rect.size.height -= insets.top + insets.bottom;
	
	float scale = view.contentScaleFactor;
	rect.origin.x *= scale;
	rect.origin.y *= scale;
	rect.size.width *= scale;
	rect.size.height *= scale;
	
	*x = rect.origin.x;
	*y = rect.origin.y;
	*width = rect.size.width;
	*height = rect.size.height;
}