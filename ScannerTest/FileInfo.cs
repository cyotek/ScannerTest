using System.IO;

// Loading the color palette from a BBM/LBM image file using C
// http://cyotek.com/blog/loading-the-color-palette-from-a-bbm-lbm-image-file-using-csharp
// Copyright © 2014 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace Cyotek.Demo.ExifOrientation
{
  internal class FileInfo
  {
    #region Constructors

    public FileInfo(string fullPath)
    {
      this.FullPath = fullPath;
    }

    #endregion

    #region Properties

    public string FullPath { get; set; }

    #endregion

    #region Methods

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// A string that represents the current object.
    /// </returns>
    public override string ToString()
    {
      return Path.GetFileName(this.FullPath) ?? base.ToString();
    }

    #endregion
  }
}
