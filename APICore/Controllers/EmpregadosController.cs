using APICore.Interface;
using APICore.Models;
using APICore.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpregadosController : ControllerBase
    {
        IEmpregadosService _empregadosService;
        ITokenService _tokenService;
        public EmpregadosController(IEmpregadosService service, ITokenService tokenService)
        {
            _empregadosService = service;
            _tokenService = tokenService;
        }

        [HttpGet]
        [Route("GetAdmin")]
        [AllowAnonymous]
        public IActionResult GetAdmin()
        {
            try
            {
                Empregados funcionariosModel = new Empregados
                {
                    EmpregadoID = 1,
                    FirsNameEmpl = "User",
                    LastNameEmpl = "Admin",
                    CorportionEmail = "admin@admin.com",
                    Chapa = 9999,
                    Password = "123456",
                    Role = "Admin"
                };
                var model = _empregadosService.PostEmpregados(funcionariosModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authentication([FromBody] AuthLogin model)
        {
            int empUser = _empregadosService.GetIdByName(model.Usuario, model.Password);
            if (empUser <= 0)
                return NotFound(new { message = "Usuário ou senha inválidos!" });
            return _tokenService.GenerateToken(model);
        }

        [HttpGet]
        [Route("[action]")]
        [Authorize]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var funcionarios = _empregadosService.GetListaEmpregados();
                if (funcionarios == null)
                    return NotFound();
                return Ok(funcionarios);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("[action]/id")]
        [Authorize(Roles = "Funcionario,Lider")]
        public IActionResult GetEmployeesById(int id)
        {
            try
            {
                var funcionarios = _empregadosService.GetEmpregadosById(id);
                if (funcionarios == null)
                    return NotFound();
                return Ok(funcionarios);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Authorize(Roles = "Lider,Admin")]
        public IActionResult SaveEmployees(Empregados funcionariosModel)
        {
            try
            {
                var model = _empregadosService.PostEmpregados(funcionariosModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Authorize(Roles = "Lider,Admin")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var model = _empregadosService.DeleteEmpregado(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
