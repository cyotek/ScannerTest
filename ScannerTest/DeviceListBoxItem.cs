using WIA;

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