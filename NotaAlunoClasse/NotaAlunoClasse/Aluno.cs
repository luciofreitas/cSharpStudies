using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAlunoClasse {
    internal class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        double media;

        public double Media() {
            media = Nota1 + Nota2 + Nota3;
            return media;
        }

        public bool Aprovado() {
            if (Media() >= 60) {
                return true;
            } else {
                return false;
            }
        }
        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            } else {
                return 60.0 - Media();
            }
        }
    }
}

