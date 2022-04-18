using APICore.Models;
using APICore.ViewModel;
using System.Collections.Generic;

namespace APICore.Interface
{
    public interface IEmpregadosService
    {
        List<Empregados> GetListaEmpregados();
        Empregados GetEmpregadosById(int empId);
        ResponseModel PostEmpregados(Empregados empModel);
        ResponseModel DeleteEmpregado(int empId);
        public int GetIdByName(string nome, string Password);
    }
}
