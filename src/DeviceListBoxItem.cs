using WIA;

// An introduction to using Windows Image Acquisition (WIA) via C#
// https://www.cyotek.com/blog/an-introduction-to-using-windows-image-acquisition-wia-via-csharp

// Copyright © 2019-2020 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the MIT License.
// See LICENSE.TXT for the full text

// Found this example useful?
// https://www.paypal.me/cyotek

namespace Cyotek.Demo.ScannerTest
{
  internal sealed class DeviceListBoxItem
  {
    #region Private Fields

    private string _deviceId;

    private string _name;

    #endregion Private Fields

    #region Public Constructors

    public DeviceListBoxItem(IDeviceInfo device)
    {
      _deviceId = device.DeviceID;
      _name = (string)device.Properties["Name"].get_Value();
    }

    #endregion Public Constructors

    #region Public Properties

    public string DeviceId
    {
      get { return _deviceId; }
      set { _deviceId = value; }
    }

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    #endregion Public Properties

    #region Public Methods

    public override string ToString()
    {
      return _name;
    }

    #endregion Public Methods
  }
}