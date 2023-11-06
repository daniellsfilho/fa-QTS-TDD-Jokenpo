namespace fa_QTS_tdd_jokenpo
{
    public class TestesJokenpo
    {
        [Fact(DisplayName = "Pedra x Pedra deve dar empate")]
        public void TestePedraXPedra()
        {
            EfetuaJogada efetuaJogada = new EfetuaJogada();

            string resultado = efetuaJogada.EfetuarJogada("PEDRA", "PEDRA");
            
            Assert.Contains("EMPATOU", resultado);
        }

        [Fact(DisplayName = "Pedra x Tesoura deve ser vitória da pedra")]
        public void TestePedraXTesoura()
        {
            EfetuaJogada efetuaJogada = new EfetuaJogada();

            string resultado1 = efetuaJogada.EfetuarJogada("PEDRA", "TESOURA");
            string resultado2 = efetuaJogada.EfetuarJogada("TESOURA", "PEDRA");

            Assert.Contains("PEDRA VENCEU", resultado1);
            Assert.Contains("PEDRA VENCEU", resultado2);
        }

        [Fact(DisplayName = "Tesoura x Tesoura deve dar empate")]
        public void TesteTesouraXTesoura()
        {
            EfetuaJogada efetuaJogada = new EfetuaJogada();

            string resultado = efetuaJogada.EfetuarJogada("TESOURA", "TESOURA");

            Assert.Contains("EMPATOU", resultado);
        }

        [Fact(DisplayName = "Tesoura x Papel deve ser vitória da tesoura")]
        public void TesteTesouraXPapel()
        {
            EfetuaJogada efetuaJogada = new EfetuaJogada();

            string resultado1 = efetuaJogada.EfetuarJogada("TESOURA", "PAPEL");
            string resultado2 = efetuaJogada.EfetuarJogada("PAPEL", "TESOURA");

            Assert.Contains("TESOURA VENCEU", resultado1);
            Assert.Contains("TESOURA VENCEU", resultado2);
        }

        [Fact(DisplayName = "Papel x Papel deve dar empate")]
        public void TestePapelXPapel()
        {
            EfetuaJogada efetuaJogada = new EfetuaJogada();

            string resultado = efetuaJogada.EfetuarJogada("PAPEL", "PAPEL");

            Assert.Contains("EMPATOU", resultado);
        }

        [Fact(DisplayName = "Papel x Pedra deve ser vitória do papel")]
        public void TestePapelXPedra()
        {
            EfetuaJogada efetuaJogada = new EfetuaJogada();

            string resultado1 = efetuaJogada.EfetuarJogada("PAPEL", "PEDRA");
            string resultado2 = efetuaJogada.EfetuarJogada("PEDRA", "PAPEL");

            Assert.Contains("PAPEL VENCEU", resultado1);
            Assert.Contains("PAPEL VENCEU", resultado2);
        }
    }
}