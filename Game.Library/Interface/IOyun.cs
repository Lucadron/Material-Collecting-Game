using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Game.Library.Enum;

namespace Game.Library.Interface
{
    public interface IOyun
    {
        bool IsPlaying { get; }
        TimeSpan PassingTime { get; }

        void Start();
        void Stop();
        void Pause();
        void MoveCollector(Direction direction);
    }
}
