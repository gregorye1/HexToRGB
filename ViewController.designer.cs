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
        UIKit.UILabel blueValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Convert { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel greenValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField hexValueTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel redValue { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (blueValue != null) {
                blueValue.Dispose ();
                blueValue = null;
            }

            if (Convert != null) {
                Convert.Dispose ();
                Convert = null;
            }

            if (greenValue != null) {
                greenValue.Dispose ();
                greenValue = null;
            }

            if (hexValueTextField != null) {
                hexValueTextField.Dispose ();
                hexValueTextField = null;
            }

            if (redValue != null) {
                redValue.Dispose ();
                redValue = null;
            }
        }
    }
}