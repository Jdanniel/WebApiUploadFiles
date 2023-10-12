using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiUpload.Interfaces;
using WebApiUpload.Models;
using WebApiUpload.Wrappers;

namespace WebApiUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private GetnetUatContext context_ = new GetnetUatContext();
        private readonly IRandomServices _randomServices;
        //private readonly ELAVONContext context_;
        private readonly IConfiguration configuracion;
        private readonly string appname;
        private readonly IAwsServices _awsServices;

        public FilesController(IConfiguration iconfig, GetnetUatContext context, IRandomServices randomServices, IAwsServices awsServices)
        {
            configuracion = iconfig;
            appname = configuracion.GetValue<string>("MySettings:appnametest");
            this.context_ = context;
            _randomServices = randomServices;
            _awsServices = awsServices;
        }

        [HttpPost("ODT")]
        public async Task<IActionResult> PostOdt(List<IFormFile> archivos, [FromForm] string noar, [FromForm] int idUsuario)
        {
            if (archivos == null || archivos.Count == 0) return BadRequest("Favor de ingresar los archivos");
            if (noar == null || noar == "") return BadRequest("Favor de ingresar el no de ar");
            var idar = (context_.BdArs.Where(n => n.NoAr == noar).Select(i => i.IdAr)).SingleOrDefault();
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

                    string newName = "_" + dia + mesm + anno + _randomServices.String(6) + "_" + idar + fi.Extension;

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

                    var idextension = (context_.CTipoArchivos.Where(x => x.Extension == fi.Extension.Replace(".", ""))).Select(x => x.IdTipoArchivo).SingleOrDefault();
                    BdArArchivosVario varios = new BdArArchivosVario()
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

                    BdAuditoriaProcesosInterno auditoria = new BdAuditoriaProcesosInterno()
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
                BdAuditoriaProcesosInterno auditoria = new BdAuditoriaProcesosInterno()
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

        [HttpPost("ODTbyIdAr")]
        public async Task<IActionResult> PostOdtbyIdAr(List<IFormFile> archivos, [FromForm] int idar, [FromForm] int idUsuario)
        {
            if (archivos == null || archivos.Count == 0) return BadRequest("Favor de ingresar los archivos");
            var noar = (context_.BdArs.Where(n => n.IdAr == idar).Select(i => i.NoAr)).SingleOrDefault();
            if (idar == 0) return BadRequest("El ar no existe");

            string dia = DateTime.Now.Day.ToString();
            int mes = DateTime.Now.Month;
            string anno = DateTime.Now.Year.ToString();
            string mesm = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes).ToUpper();

            var desccliente = (context_.CClientes.Where(i => i.IdCliente == 4).Select(d => d.DescCliente)).SingleOrDefault().Replace(" ", "_");

            try
            {
                foreach (IFormFile archivo in archivos)
                {
                    FileInfo fi = new FileInfo(archivo.FileName);

                    string newName = "_" + dia + mesm + anno + _randomServices.String(6) + "_" + idar + fi.Extension;

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

                    var idextension = (context_.CTipoArchivos.Where(x => x.Extension == fi.Extension.Replace(".", ""))).Select(x => x.IdTipoArchivo).SingleOrDefault();
                    BdArArchivosVario varios = new BdArArchivosVario()
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

                    BdAuditoriaProcesosInterno auditoria = new BdAuditoriaProcesosInterno()
                    {
                        Proceso = "CARGA DE ARCHIVOS VIA API",
                        ErrorNumber = idar,
                        ErrorMessage = "Se cargo correctamente el archivo " + newName + " para la ODT " + noar,
                        FecAlta = DateTime.Now
                    };
                    context_.BdAuditoriaProcesosInternos.Add(auditoria);
                    await context_.SaveChangesAsync();
                }

                return Ok("Carga completada");
            }
            catch (Exception ex)
            {
                BdAuditoriaProcesosInterno auditoria = new BdAuditoriaProcesosInterno()
                {
                    Proceso = "CARGA DE ARCHIVOS VIA API",
                    ErrorNumber = idar,
                    ErrorMessage = ex.ToString() + "// Ocurrio un error al cargar un archivo" + noar,
                    FecAlta = DateTime.Now
                };
                context_.BdAuditoriaProcesosInternos.Add(auditoria);
                await context_.SaveChangesAsync();

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("photosAplicacion")]
        public async Task<IActionResult> photosAplicacion(IFormFile archivos, [FromForm] string noar, [FromForm] int idUsuario, [FromForm] int EvidenceTypeId)
        {
            if (archivos == null) return BadRequest("Favor de ingresar los archivos");
            if (noar == null || noar == "") return BadRequest("Favor de ingresar el no de ar");
            BdAr ar = await context_.BdArs.Where(x => x.NoAr == noar).FirstOrDefaultAsync();
            if (ar == null) return BadRequest("El ar no existe");
            CTipoArchivo tipoArchivo = await context_.CTipoArchivos.Where(x => x.Extension == Path.GetExtension(archivos.FileName).Replace(".","")).FirstOrDefaultAsync();

            if(tipoArchivo == null)
            {
                return BadRequest("Formato incorrecto");
            }

            int[] StatusAr = { 6, 7, 8 };

            CevidenceType evidenceTypes = await context_.CevidenceTypes.Where(x => x.EvidenceTypeId == EvidenceTypeId).FirstOrDefaultAsync();

            if (StatusAr.Contains(ar.IdStatusAr.GetValueOrDefault()) && evidenceTypes.EvidenceDesc.Trim().ToUpper() != "OTRO")
            {
                return BadRequest("El Servicio no esta en el estatus correcto");
            }

            if (evidenceTypes.EvidenceNumber != -1)
            {
                BdArArchivosVario arArchivosVarios = await context_.BdArArchivosVarios.Where(x => x.EvidenceTypeId == EvidenceTypeId && x.IdAr == ar.IdAr).FirstOrDefaultAsync();

                if (arArchivosVarios != null)
                {
                    context_.BdArArchivosVarios.Remove(arArchivosVarios);
                    await context_.SaveChangesAsync();
                    await _awsServices.Delete(arArchivosVarios.Ruta + arArchivosVarios.NombreArchivoSistema);
                }
            }

            string dia = DateTime.Now.Day.ToString();
            int mes = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string anno = DateTime.Now.Year.ToString();
            string mesm = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes).ToUpper();
            var desccliente = (context_.CClientes.Where(i => i.IdCliente == 4).Select(d => d.DescCliente)).SingleOrDefault().Replace(" ", "_");

            string pathFile = $@"{desccliente}/{year}/{mesm}/";

            try
            {
                FileInfo fi = new FileInfo(archivos.FileName);

                string newName = "_" + dia + mesm + anno + _randomServices.String(6) + "_" + ar.IdAr + fi.Extension;

                await _awsServices.Upload(archivos, pathFile + newName);
                
                BdArArchivosVario varios = new BdArArchivosVario()
                {
                    IdAr = ar.IdAr,
                    NombreArchivoSistema = newName,
                    NombreArchivoUsuario = fi.Name,
                    Ruta = pathFile+newName,
                    IdTipoArchivo = tipoArchivo.IdTipoArchivo,
                    IdUsuarioAlta = idUsuario,
                    FechaAlta = DateTime.Now,
                    Status = "ACTIVO",
                    EvidenceTypeId = EvidenceTypeId
                };
                context_.BdArArchivosVarios.Add(varios);
                await context_.SaveChangesAsync();

                BdAuditoriaProcesosInterno auditoria = new BdAuditoriaProcesosInterno()
                {
                    Proceso = "CARGA DE ARCHIVOS VIA API",
                    ErrorNumber = ar.IdAr,
                    ErrorMessage = "Se cargo correctamente el archivo " + newName + " para la ODT " + noar,
                    FecAlta = DateTime.Now
                };
                context_.BdAuditoriaProcesosInternos.Add(auditoria);
                await context_.SaveChangesAsync();

                var total = context_.BdArArchivosVarios.Where(x => x.IdAr == ar.IdAr).Count();
                return Ok(total);
            }
            catch (Exception ex)
            {
                BdAuditoriaProcesosInterno auditoria = new BdAuditoriaProcesosInterno()
                {
                    Proceso = "CARGA DE ARCHIVOS VIA API",
                    ErrorNumber = ar.IdAr,
                    ErrorMessage = ex.ToString() + "// Ocurrio un error al cargar un archivo" + noar,
                    FecAlta = DateTime.Now
                };
                context_.BdAuditoriaProcesosInternos.Add(auditoria);
                await context_.SaveChangesAsync();

                return BadRequest(ex.ToString());
            }
        }
    }
}