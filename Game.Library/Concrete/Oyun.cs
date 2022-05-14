using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Game.Library.Enum;
using Game.Library.Interface;
namespace Game.Library.Concrete
{
    public class Oyun : IOyun
    {
        public bool IsPlaying { get; private set; }

        public TimeSpan PassingTime { get; }

        public void MoveCollector(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (IsPlaying) return;
            
            IsPlaying = true;
        }

        public void Stop()
        {
            if (!IsPlaying) return;
            IsPlaying= false;
        }
    }
}
