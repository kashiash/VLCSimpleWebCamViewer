using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraRecorder
{
    public class KeysConfig
    {
        public Keys PlayPauseKey { get; set; } = Keys.Space;
        public Keys FullscreenKey { get; set; } = Keys.F11;
        public Keys SkipBackwardKey { get; set; } = Keys.J;
        public Keys SkipForwardKey { get; set; } = Keys.L;
        public Keys NextFrameKey { get; set; } = Keys.N;
        public Keys TakeSnapshotKey { get; set; } = Keys.S;
        public Keys StartRecordingKey { get; set; } = Keys.R;
        public Keys StopRecordingKey { get; set; } = Keys.T;
    }
}
