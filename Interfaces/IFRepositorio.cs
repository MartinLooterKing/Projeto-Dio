using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IFRepositorio<F>
    {
        List<F> Lista();
        F RetornaPorId(int id);        
        void Insere(F entidade);        
        void Exclui(int id);        
        void Atualiza(int id, F entidade);
        int ProximoId();
    }
}