// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HextoRGB
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel blueHexValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton convert { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel greenHexValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField hexValueTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel redHexValue { get; set; }

        [Action ("Convert_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Convert_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (blueHexValue != null) {
                blueHexValue.Dispose ();
                blueHexValue = null;
            }

            if (convert != null) {
                convert.Dispose ();
                convert = null;
            }

            if (greenHexValue != null) {
                greenHexValue.Dispose ();
                greenHexValue = null;
            }

            if (hexValueTextField != null) {
                hexValueTextField.Dispose ();
                hexValueTextField = null;
            }

            if (redHexValue != null) {
                redHexValue.Dispose ();
                redHexValue = null;
            }
        }
    }
}