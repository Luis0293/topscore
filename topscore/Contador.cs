﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topscore
{
    class Contador
    {
        private string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private int _topscore;
        private int _pontos;
        private int _tempo = 60;

        public string Score()
        {
            if (_tempo > 0)
            {
                _pontos += 1;
            }

            return _pontos.ToString();
        }

        public string Time()
        {
            if(_tempo > 0)
            {
                _tempo -= 1;
            }

            return _tempo.ToString();
        }

        public string ResetP()
        {
            _pontos = 0;
            return _pontos.ToString();
        }

        public string ResetT()
        {
            _tempo = 60;
            return _tempo.ToString();
        }
    }
}
