using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game
{
    public static class JogadaUtil
    {
        public static Jogador MostrarGanhador(Jogador j1, Jogador j2)
        {

            if (j1.Jogada == JogadaEnum.PEDRA && j2.Jogada == JogadaEnum.TESOURA)
                return j1;

            if (j1.Jogada == JogadaEnum.PEDRA && j2.Jogada == JogadaEnum.PAPEL)
                return j2;

            if (j1.Jogada == JogadaEnum.TESOURA && j2.Jogada == JogadaEnum.PEDRA)
                return j2;

            if (j1.Jogada == JogadaEnum.TESOURA && j2.Jogada == JogadaEnum.PAPEL)
                return j1;

            if (j1.Jogada == JogadaEnum.PAPEL && j2.Jogada == JogadaEnum.PEDRA)
                return j1;

            if (j1.Jogada == JogadaEnum.PAPEL && j2.Jogada == JogadaEnum.TESOURA)
                return j2;

            return null;
        }
    }
}