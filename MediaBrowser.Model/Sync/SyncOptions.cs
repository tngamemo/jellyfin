﻿
namespace MediaBrowser.Model.Sync
{
    public class SyncOptions
    {
        public string TemporaryPath { get; set; }
        public long UploadSpeedLimitBytes { get; set; }
    }
}
