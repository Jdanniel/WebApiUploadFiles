using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApiUpload.Models;

namespace WebApiUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        //private ELAVONTESTContext context_ = new ELAVONTESTContext();
        private readonly ELAVONTESTContext context_;
        private readonly IConfiguration configuracion;
        private readonly string appname;
        private readonly Random random = new Random();

        public FilesController(IConfiguration iconfig, ELAVONTESTContext context)
        {
            configuracion = iconfig;
            appname = configuracion.GetValue<string>("MySettings:appnametest");
            this.context_ = context;
        }

        [HttpPost]
        [Route("ODT")]
        public async Task<IActionResult> PostOdt(List<IFormFile> archivos, [FromForm] string noar, [FromForm] int idUsuario)
        {
            if (archivos == null || archivos.Count == 0) return BadRequest("Favor de ingresar los archivos");
            if (noar == null || noar == "") return BadRequest("Favor de ingresar el no de ar");
            var idar = (context_.BdAr.Where(n => n.NoAr == noar).Select(i => i.IdAr)).SingleOrDefault();
            if (idar == 0) return BadRequest("El ar no existe");

            string dia = DateTime.Now.Day.ToString();
            int mes = DateTime.Now.Month;
            string anno = DateTime.Now.Year.ToString();
            string mesm = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes).ToUpper();

            var desccliente = (context_.CClientes.Where(i => i.IdCliente == 4).Select(d => d.DescCliente)).SingleOrDefault().Replace(" ", "_");

            try {
                foreach (IFormFile archivo in archivos)
                {
                    FileInfo fi = new FileInfo(archivo.FileName);

                    string newName = "_" + dia + mesm + anno + RandomString(6) + "_" + idar + fi.Extension;

                    if (!Directory.Exists("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno))
                    {
                        Directory.CreateDirectory("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno);
                    }

                    if (!Directory.Exists("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno + "//" + desccliente))
                    {
                        Directory.CreateDirectory("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno + "//" + desccliente);
                    }

                    if (!Directory.Exists("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno + "//" + desccliente + "//" + mesm))
                    {
                        Directory.CreateDirectory("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno + "//" + desccliente + "//" + mesm);
                    }

                    var path = Path.Combine("C://inetpub//wwwroot//" + appname + "//DOCS/BITACORA_AR//UPLOADER//ARCHIVOS//" + anno + "//" + desccliente + "//" + mesm, newName);
                    var pathToSave = @"/UPLOADER/ARCHIVOS/" + anno + "/" + desccliente + "/" + mesm;

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await archivo.CopyToAsync(stream);
                    }

                    var idextension = (context_.CTipoArchivo.Where(x => x.Extension == fi.Extension.Replace(".", ""))).Select(x => x.IdTipoArchivo).SingleOrDefault();
                    BdArArchivosVarios varios = new BdArArchivosVarios()
                    {
                        IdAr = idar,
                        NombreArchivoSistema = newName,
                        NombreArchivoUsuario = fi.Name,
                        Ruta = pathToSave,
                        IdTipoArchivo = idextension,
                        IdUsuarioAlta = idUsuario,
                        FechaAlta = DateTime.Now,
                        Status = "ACTIVO"
                    };
                    context_.BdArArchivosVarios.Add(varios);
                    await context_.SaveChangesAsync();

                    BdAuditoriaProcesosInternos auditoria = new BdAuditoriaProcesosInternos()
                    {
                        Proceso = "CARGA DE ARCHIVOS VIA API",
                        ErrorNumber = idar,
                        ErrorMessage = "Se cargo correctamente el archivo "+newName+" para la ODT " + noar,
                        FecAlta = DateTime.Now
                    };
                    context_.BdAuditoriaProcesosInternos.Add(auditoria);
                    await context_.SaveChangesAsync();
                }

                return Ok("Carga completada");
            }
            catch (Exception ex)
            {
                BdAuditoriaProcesosInternos auditoria = new BdAuditoriaProcesosInternos()
                {
                    Proceso = "CARGA DE ARCHIVOS VIA API",
                    ErrorNumber = idar,
                    ErrorMessage = ex.ToString()+ "// Ocurrio un error al cargar un archivo" + noar,
                    FecAlta = DateTime.Now
                };
                context_.BdAuditoriaProcesosInternos.Add(auditoria);
                await context_.SaveChangesAsync();

                return BadRequest(ex.ToString());
            }
        }
        public string RandomString(int length)
        {
            const string chars = "A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z50123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}