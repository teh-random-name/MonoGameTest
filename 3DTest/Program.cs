﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DTest {
    class Program {
        static void Main(string[] args) {
            using (var game = new _3DTestGame()){
                game.Run();
            }
        }
    }
}
