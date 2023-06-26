using System;
using System.Globalization;


namespace Resolvendo004
{
    class Alunos
    {
        public string Aluno;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            return " = "
                + NotaFinal().ToString("f2", CultureInfo.InvariantCulture);
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }

            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }

}

   
