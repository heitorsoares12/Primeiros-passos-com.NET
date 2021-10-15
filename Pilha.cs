using System;

namespace EstruturaDoPrograma
{
    public class Pilha
    {
        Posicao primeiro;

        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if(primeiro == null)
            {
                throw new InvalidOperationException("A pilha esta vazia!");
            }

            object resultador = primeiro.item;
            primeiro = primeiro.proximo;
            return resultador;
        }

        class Posicao
        {
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}