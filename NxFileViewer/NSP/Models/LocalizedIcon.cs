﻿using Emignatik.NxFileViewer.NxFormats.NACP.Structs;

namespace Emignatik.NxFileViewer.NSP.Models
{
    public class LocalizedIcon
    {
        public string IconFilePath { get; set; }

        public NacpLanguage Language { get; set; }
    }
}