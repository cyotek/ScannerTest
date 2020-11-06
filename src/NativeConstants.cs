// An introduction to using Windows Image Acquisition (WIA) via C#
// https://www.cyotek.com/blog/an-introduction-to-using-windows-image-acquisition-wia-via-csharp

// Copyright © 2019-2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Cyotek.Demo.ScannerTest
{
  internal static class NativeConstants
  {
    #region Internal Fields

    internal const int WIA_S_NO_DEVICE_AVAILABLE = -2145320939 /* 0x80210015 */;

    #endregion Internal Fields
  }
}