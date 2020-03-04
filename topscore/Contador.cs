using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topscore
{
    class Contador
    {
        private static string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private int _pontos = 0;
        private int _tempo = 10;
        private int _topscore = Int32.Parse(File.ReadAllText(_path));

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
            if (_tempo > 0)
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
            _tempo = 10;
            return _tempo.ToString();
        }

        public void ResetO(object sender)
        {
            int _x = 350;
            int _y = 175;
            Point pt = new Point(_x, _y);
            Button b = (Button)sender;
            b.Location = pt;
        }

        public string TopScore()
        {
            if (_pontos > _topscore)
            {
                _topscore = _pontos;
            }

            return _topscore.ToString();
        }

        public void Move(object sender)
        {
            if (_tempo > 0)
            {
                Random r = new Random();
                int _x = int.Parse(r.Next(700).ToString());
                int _y = int.Parse(r.Next(100).ToString()) + 100;
                Point pt = new Point(_x, _y);
                Button b = (Button)sender;
                b.Location = pt;
            } 
        }

        public void Gravar()
        {
            if (_pontos > _topscore)
            {
                File.WriteAllText(_path, _pontos.ToString());
            }
            
        }

        public string Ler
        {
            get
            {
                _topscore = Int32.Parse(File.ReadAllText(_path));
                return _topscore.ToString();
            }
        }
    }
}
