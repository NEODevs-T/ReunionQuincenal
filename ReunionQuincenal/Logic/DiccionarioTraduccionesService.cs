using System.Globalization;
using ReunionWeb.Services;
using ReunionWeb.Interface;
using ReunionWeb.Resources;

namespace ReunionWeb.Services
{
    public class DiccionarioTraduccionesService : IDiccionarioTraduccionesService
    {
        private readonly ITranslationService _translator;
        private readonly IRespoReuData _respoReuData;

        public Dictionary<string, string> Traducciones { get; private set; } = new();

        public DiccionarioTraduccionesService(ITranslationService translator, IRespoReuData respoReuData)
        {
            _translator = translator;
            _respoReuData = respoReuData;
        }

        public async Task CargarTraduccionesAsync()
        {
            var claves = new[]
            {
                "AExitoso", "Accion", "Acciones", "Aceptar", "Activar",
                "Activo", "ADiscrepancia", "Advertencia", "Agregar", "AgregarEquipos", "AgregarFecha",
                "AgregarFechaProgramada", "Area", "Asistencia", "Asistentes", "Asuntos",
                "Atencion", "Atras", "Año", "Bloque", "Borrar",
                "Buscar", "BuscarCargo", "BuscarCargo2", "C_Equipo", "Calendario",
                "CambiosDeEstados", "CambiosDeFechaDeTrabajoRestantes", "CambiosDeFechaTrabajo", "CamposNecesarios", "Cancelar",
                "Cargo", "Centro", "Cerrado", "CerrarSesion", "Codigo",
                "CodigosDeEquipos", "CodigoDeEquipo", "CodigoEAM", "ColocarFecha", "Consolidacion", "ConsolidacionDeDiscrepancia",
                "Consultar", "ConsultarEquipos", "ConsultarFechaProgramada", "Correcto", "Desactivar",
                "Descripcion", "Desde", "DetallesCalidad", "DetallesDeCalidad", "Dia",
                "DiasNoLaborables", "Discrepancia", "DiscrepanciaRechazada", "Discrepancias", "Division",
                "EDato", "ERevisar", "Editar", "EditarDiscrepancia", "Empresa",
                "EnCurso", "Equipo", "EquipoNoDisponible", "Error", "ErrorConexion",
                "ErrorConexionM", "ErrorInesp", "ErrorInser", "ErrorP", "Estado",
                "ExcluirLosDiasNoLaborables", "Exito", "FReunion","FTrabajo", "FalloR",
                "FaltaDePersonal", "FaltaRepuesto", "FechaDeReunion", "FechaDelCambio", "FechaDeTrabajo",
                "FechaFinal", "FechaInicial", "FechaMenor", "FechaProgramada", "FechasProgramadas",
                "FechasSeleccionadas", "Ficha", "Filtrar", "FiltrarCodigo", "FiltrarPorCargo",
                "FiltroFechaDeReunion", "FiltroFechaDeTrabajo", "FormatoDeReunion", "Guardar", "GuardarFecha",
                "Hasta", "Historicos", "Hola", "Hoy", "Imprimir",
                "Inactivo", "IniciarSesion", "KsfReunionDiaria", "Limite", "LimpiarFiltros",
                "Linea", "Listo", "LlDisp", "MExito", "Mes",
                "NEquipo", "NFDatos", "NPA1", "NPA2", "NSDatos",
                "Nequipos", "NoAgregada", "NoCargadoP", "NoConforme", "NoExisteEseCargo",
                "NoHayDatos", "NoHayDatos2", "NoResponsable", "NoHayDescrip", "NoHayEquipos", "NoHayFecha",
                "NoHayFiltros", "NoHayRegistros", "NoHayRegistros2", "NoRechazada", "Nombre",
                "NombreDelEquipo", "NuevaFechaDeTrabajo", "Nuevo", "ODT", "ObservacionesDeCalidad",
                "Ordenar", "OrgDelProducto", "ParadaMayor", "Pendiente", "PendientesDiaria", "PendienteFaltaRepuesto", "PendientesLibro",
                "Personal", "PlanDeAccion", "Planificacion", "PorcentajeAsistencia", "PorcentajeDeAsistencia",
                "PorcentajeGlobal", "Presencia", "ProximaFecha", "ProximaParada", "RExitoso",
                "RHorario", "Reload", "RequiredPassword", "RequiredUserName", "Requisicion",
                "Responsable", "Reunion", "ReunionDiariaAgregada", "ReunionesAsistidas", "ReunionQuincenal", "ReunionQuincenalAgregada", 
                "ReunionesProgramadas","Revisar", "SArea", "SCentro", "SDivision", "SEstado",
                "SSuplente", "SVCentro", "SVDivision", "SVLista", "SegundaFechaN",
                "Seleccione", "SeleccioneBuscar", "SeleccioneDML", "SeleccioneUnCentro", "SeleccioneUnaDivision",
                "SeleccioneUnaEmpresa", "Semana", "StatusNuevo", "Suplencia", "TCargos",
                "Tiempo", "Todo", "Todos", "TodosCampos", "TotalPendiente",
                "Trazabilidad", "Usuario", "VencidasDiaria", "VencidasTurno", "Vencidos", "VerifiqueCampos", "Horas",
                "hay_registros_vencidos"
            };

            foreach (var clave in claves)
            {
                var traduccion = _translator.Traducir(clave);
                Traducciones[clave] = traduccion;
            }

            var listaResponsbale = await _respoReuData.GetResReu();
            if (listaResponsbale != null)
            {
                foreach (var d in listaResponsbale)
                {
                    var respo = ValidationMessages.MapResponsableKey(d.Rrnombre);
                    if (!Traducciones.ContainsKey(respo))
                    {
                        Traducciones[respo] = _translator.Traducir(respo);
                    }
                }
            }

            await Task.CompletedTask;
        }
    }
}
