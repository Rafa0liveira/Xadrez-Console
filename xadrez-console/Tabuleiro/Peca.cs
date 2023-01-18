using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro {
    internal class Peca {
        public Posicao posicao { get;set; }
        public Cor cor {get;protected set;}
        public int qteMovimentos {get;protected set;}

        public Tabuleiro Tab { get;protected set; }
        }
    }
}
