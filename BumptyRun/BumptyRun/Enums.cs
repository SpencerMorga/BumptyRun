using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BumptyRun
{
    static class Enums
    {

        /*
TOON LINK FRAMES 

Standing (bouncing)
5, 140, 33, 45
43, 140, 34, 45
5, 140, 35, 45
130, 140, 33, 45

Crouch
5, 233, 33, 45
42, 233, 35, 45
84, 233, 38, 45
126, 233, 38, 45

Jump
I WILL DO THIs WHEN I NEED TO JUMP OKAY 

Upward Slash
8, 476, 44, 37
59, 475, 45, 36
117, 473, 71, 38
196, 463, 63, 48
264, 462, 64, 49
335, 46, 63, 43
404, 467, 61, 44
Downward Slash
5, 403, 43, 53
52, 409, 48, 47
106, 409, 40, 47
150, 409, 76, 47
229, 419, 74, 37
307, 420, 48, 38
Jab
3, 517, 47, 42
54, 518, 42, 41
105, 519, 46, 40
158, 518, 76, 41
240, 518, 77, 41
324, 518, 76, 41
407, 518, 74, 41
491, 520, 63, 39

C0MB0
downward slash + upward slash + jab = C0MB0

  
          */
        public enum ThingsLinkCanDo
        {
            Running, 
            Stopped,
            Idle,
            Crouch,
            // make one enum for everything
        
        
        
            DownwardSlash,
            UpwardSlash,
            Jab,
            Combo
            
            
        }
        public enum ChokingOnMyTongue2
        {
            Flapping, 
            TongueFlap
        }
        public enum SKYFLAKYNESS
        {
            Idle,
            Slash
        }

    }
}
