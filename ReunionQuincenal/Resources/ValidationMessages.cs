using System.Resources;
using System.Globalization;
using BlazorStrap.Utilities;
using ReunionWeb.ReunionDiaria.DTOs;

namespace ReunionWeb.Resources
{
    public static class ValidationMessages
    {
        private static readonly ResourceManager _resourceManager =
            new ResourceManager("ReunionWeb.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);

        public static ResourceManager ResourceManager => _resourceManager;

        public static string Accion => _resourceManager.GetString("Accion", CultureInfo.CurrentUICulture);
        public static string Acciones => _resourceManager.GetString("Acciones", CultureInfo.CurrentUICulture);
        public static string Aceptar => _resourceManager.GetString("Aceptar", CultureInfo.CurrentUICulture);
        public static string ADiscrepancia => _resourceManager.GetString("ADiscrepancia", CultureInfo.CurrentUICulture);
        public static string Advertencia => _resourceManager.GetString("Advertencia", CultureInfo.CurrentUICulture);
        public static string Area => _resourceManager.GetString("Area", CultureInfo.CurrentUICulture);
        public static string Asistencia => _resourceManager.GetString("Asistencia", CultureInfo.CurrentUICulture);
        public static string Asistentes => _resourceManager.GetString("Asistentes", CultureInfo.CurrentUICulture);
        public static string Asuntos => _resourceManager.GetString("Asuntos", CultureInfo.CurrentUICulture);
        public static string Atencion => _resourceManager.GetString("Atencion", CultureInfo.CurrentUICulture);
        public static string Atras => _resourceManager.GetString("Atras", CultureInfo.CurrentUICulture);
        public static string Bloque => _resourceManager.GetString("Bloque", CultureInfo.CurrentUICulture);
        public static string Borrar => _resourceManager.GetString("Borrar", CultureInfo.CurrentUICulture);
        public static string Buscar => _resourceManager.GetString("Buscar", CultureInfo.CurrentUICulture);
        public static string Calendario => _resourceManager.GetString("Calendario", CultureInfo.CurrentUICulture);
        public static string CambiosDeEstados => _resourceManager.GetString("CambiosDeEstados", CultureInfo.CurrentUICulture);
        public static string CambiosDeFechaTrabajo => _resourceManager.GetString("CambiosDeFechaTrabajo", CultureInfo.CurrentUICulture);
        public static string Centro => _resourceManager.GetString("Centro", CultureInfo.CurrentUICulture);
        public static string Cerrado => _resourceManager.GetString("Cerrado", CultureInfo.CurrentUICulture);
        public static string Codigo => _resourceManager.GetString("Codigo", CultureInfo.CurrentUICulture);
        public static string CodigoDeEquipo => _resourceManager.GetString("CodigoDeEquipo", CultureInfo.CurrentUICulture);
        public static string Consolidacion => _resourceManager.GetString("Consolidacion", CultureInfo.CurrentUICulture);
        public static string ConsolidacionDeDiscrepancia => _resourceManager.GetString("ConsolidacionDeDiscrepancia", CultureInfo.CurrentUICulture);
        public static string Consultar => _resourceManager.GetString("Consultar", CultureInfo.CurrentUICulture);
        public static string Correcto => _resourceManager.GetString("Correcto", CultureInfo.CurrentUICulture);
        public static string Desde => _resourceManager.GetString("Desde", CultureInfo.CurrentUICulture);
        public static string DetallesCalidad => _resourceManager.GetString("DetallesCalidad", CultureInfo.CurrentUICulture);
        public static string DetallesDeCalidad => _resourceManager.GetString("DetallesDeCalidad", CultureInfo.CurrentUICulture);
        public static string Discrepancia => _resourceManager.GetString("Discrepancia", CultureInfo.CurrentUICulture);
        public static string Discrepancias => _resourceManager.GetString("Discrepancias", CultureInfo.CurrentUICulture);
        public static string Division => _resourceManager.GetString("Division", CultureInfo.CurrentUICulture);
        public static string EDato => _resourceManager.GetString("EDato", CultureInfo.CurrentUICulture);
        public static string EditarDiscrepancia => _resourceManager.GetString("EditarDiscrepancia", CultureInfo.CurrentUICulture);
        public static string EnCurso => _resourceManager.GetString("EnCurso", CultureInfo.CurrentUICulture);
        public static string Error => _resourceManager.GetString("Error", CultureInfo.CurrentUICulture);
        public static string ErrorConexion => _resourceManager.GetString("ErrorConexion", CultureInfo.CurrentUICulture);
        public static string ErrorConexionM => _resourceManager.GetString("ErrorConexionM", CultureInfo.CurrentUICulture);
        public static string ErrorInesp => _resourceManager.GetString("ErrorInesp", CultureInfo.CurrentUICulture);
        public static string ErrorInser => _resourceManager.GetString("ErrorInser", CultureInfo.CurrentUICulture);
        public static string Estado => _resourceManager.GetString("Estado", CultureInfo.CurrentUICulture);
        public static string Exito => _resourceManager.GetString("Exito", CultureInfo.CurrentUICulture);
        public static string FReunion => _resourceManager.GetString("FReunion", CultureInfo.CurrentUICulture);
        public static string FTrabajo => _resourceManager.GetString("FTrabajo", CultureInfo.CurrentUICulture);
        public static string FechaDeReunion => _resourceManager.GetString("FechaDeReunion", CultureInfo.CurrentUICulture);
        public static string FechaDelCambio => _resourceManager.GetString("FechaDelCambio", CultureInfo.CurrentUICulture);
        public static string Filtrar => _resourceManager.GetString("Filtrar", CultureInfo.CurrentUICulture);
        public static string FiltroFechaDeReunion => _resourceManager.GetString("FiltroFechaDeReunion", CultureInfo.CurrentUICulture);
        public static string FiltroFechaDeTrabajo => _resourceManager.GetString("FiltroFechaDeTrabajo", CultureInfo.CurrentUICulture);
        public static string Guardar => _resourceManager.GetString("Guardar", CultureInfo.CurrentUICulture);
        public static string Hasta => _resourceManager.GetString("Hasta", CultureInfo.CurrentUICulture);
        public static string hay_registros_vencidos => _resourceManager.GetString("hay_registros_vencidos", CultureInfo.CurrentUICulture);
        public static string Historicos => _resourceManager.GetString("Historicos", CultureInfo.CurrentUICulture);
        public static string Imprimir => _resourceManager.GetString("Imprimir", CultureInfo.CurrentUICulture);
        public static string Linea => _resourceManager.GetString("Linea", CultureInfo.CurrentUICulture);
        public static string Listo => _resourceManager.GetString("Listo", CultureInfo.CurrentUICulture);
        public static string LlDisp => _resourceManager.GetString("LlDisp", CultureInfo.CurrentUICulture);
        public static string NEquipo => _resourceManager.GetString("NEquipo", CultureInfo.CurrentUICulture);
        public static string NFDatos => _resourceManager.GetString("NFDatos", CultureInfo.CurrentUICulture);
        public static string NPA1 => _resourceManager.GetString("NPA1", CultureInfo.CurrentUICulture);
        public static string NPA2 => _resourceManager.GetString("NPA2", CultureInfo.CurrentUICulture);
        public static string NSDatos => _resourceManager.GetString("NSDatos", CultureInfo.CurrentUICulture);
        public static string NoCargadoP => _resourceManager.GetString("NoCargadoP", CultureInfo.CurrentUICulture);
        public static string NoConforme => _resourceManager.GetString("NoConforme", CultureInfo.CurrentUICulture);
        public static string NoHayDatos => _resourceManager.GetString("NoHayDatos", CultureInfo.CurrentUICulture);
        public static string NoHayDatos2 => _resourceManager.GetString("NoHayDatos2", CultureInfo.CurrentUICulture);
        public static string NoHayDescrip => _resourceManager.GetString("NoHayDescrip", CultureInfo.CurrentUICulture);
        public static string NoHayEquipos => _resourceManager.GetString("NoHayEquipos", CultureInfo.CurrentUICulture);
        public static string NoHayRegistros => _resourceManager.GetString("NoHayRegistros", CultureInfo.CurrentUICulture);
        public static string NoHayRegistros2 => _resourceManager.GetString("NoHayRegistros2", CultureInfo.CurrentUICulture);
        public static string NombreDelEquipo => _resourceManager.GetString("NombreDelEquipo", CultureInfo.CurrentUICulture);
        public static string NuevaFechaDeTrabajo => _resourceManager.GetString("NuevaFechaDeTrabajo", CultureInfo.CurrentUICulture);
        public static string Nuevo => _resourceManager.GetString("Nuevo", CultureInfo.CurrentUICulture);
        public static string ODT => _resourceManager.GetString("ODT", CultureInfo.CurrentUICulture);
        public static string ObservacionesDeCalidad => _resourceManager.GetString("ObservacionesDeCalidad", CultureInfo.CurrentUICulture);
        public static string Ordenar => _resourceManager.GetString("Ordenar", CultureInfo.CurrentUICulture);
        public static string OrgDelProducto => _resourceManager.GetString("OrgDelProducto", CultureInfo.CurrentUICulture);
        public static string Pendiente => _resourceManager.GetString("Pendiente", CultureInfo.CurrentUICulture);
        public static string Personal => _resourceManager.GetString("Personal", CultureInfo.CurrentUICulture);
        public static string PlanDeAccion => _resourceManager.GetString("PlanDeAccion", CultureInfo.CurrentUICulture);
        public static string Presencia => _resourceManager.GetString("Presencia", CultureInfo.CurrentUICulture);
        public static string RExitoso => _resourceManager.GetString("RExitoso", CultureInfo.CurrentUICulture);
        public static string RHorario => _resourceManager.GetString("RHorario", CultureInfo.CurrentUICulture);
        public static string Reload => _resourceManager.GetString("Reload", CultureInfo.CurrentUICulture);
        public static string RequiredPassword => _resourceManager.GetString("RequiredPassword", CultureInfo.CurrentUICulture);
        public static string RequiredUserName => _resourceManager.GetString("RequiredUserName", CultureInfo.CurrentUICulture);
        public static string Responsable => _resourceManager.GetString("Responsable", CultureInfo.CurrentUICulture);
        public static string Reunion => _resourceManager.GetString("Reunion", CultureInfo.CurrentUICulture);
        public static string SArea => _resourceManager.GetString("SArea", CultureInfo.CurrentUICulture);
        public static string SCentro => _resourceManager.GetString("SCentro", CultureInfo.CurrentUICulture);
        public static string SDivision => _resourceManager.GetString("SDivision", CultureInfo.CurrentUICulture);
        public static string SEstado => _resourceManager.GetString("SEstado", CultureInfo.CurrentUICulture);
        public static string SSuplente => _resourceManager.GetString("SSuplente", CultureInfo.CurrentUICulture);
        public static string SVCentro => _resourceManager.GetString("SVCentro", CultureInfo.CurrentUICulture);
        public static string SVDivision => _resourceManager.GetString("SVDivision", CultureInfo.CurrentUICulture);
        public static string SVLista => _resourceManager.GetString("SVLista", CultureInfo.CurrentUICulture);
        public static string Seleccione => _resourceManager.GetString("Seleccione", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnCentro => _resourceManager.GetString("SeleccioneUnCentro", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaDivision => _resourceManager.GetString("SeleccioneUnaDivision", CultureInfo.CurrentUICulture);
        public static string SeleccioneUnaEmpresa => _resourceManager.GetString("SeleccioneUnaEmpresa", CultureInfo.CurrentUICulture);
        public static string StatusNuevo => _resourceManager.GetString("StatusNuevo", CultureInfo.CurrentUICulture);
        public static string Suplencia => _resourceManager.GetString("Suplencia", CultureInfo.CurrentUICulture);
        public static string TCargos => _resourceManager.GetString("TCargos", CultureInfo.CurrentUICulture);
        public static string Todo => _resourceManager.GetString("Todo", CultureInfo.CurrentUICulture);
        public static string Todos => _resourceManager.GetString("Todos", CultureInfo.CurrentUICulture);
        public static string TotalPendiente => _resourceManager.GetString("TotalPendiente", CultureInfo.CurrentUICulture);
        public static string Trazabilidad => _resourceManager.GetString("Trazabilidad", CultureInfo.CurrentUICulture);
        public static string Usuario => _resourceManager.GetString("Usuario", CultureInfo.CurrentUICulture);
        public static string PorcentajeDeAsistencia => _resourceManager.GetString("PorcentajeDeAsistencia", CultureInfo.CurrentUICulture);
        public static string FechaInicial => _resourceManager.GetString("FechaInicial", CultureInfo.CurrentUICulture);
        public static string FechaFinal => _resourceManager.GetString("FechaFinal", CultureInfo.CurrentUICulture);
        public static string Empresa => _resourceManager.GetString("Empresa", CultureInfo.CurrentUICulture);
        public static string ExcluirLosDiasNoLaborables => _resourceManager.GetString("ExcluirLosDiasNoLaborables", CultureInfo.CurrentUICulture);
        public static string DiasNoLaborables => _resourceManager.GetString("DiasNoLaborables", CultureInfo.CurrentUICulture);
        public static string FiltrarPorCargo => _resourceManager.GetString("FiltrarPorCargo", CultureInfo.CurrentUICulture);
        public static string BuscarCargo => _resourceManager.GetString("BuscarCargo", CultureInfo.CurrentUICulture);
        public static string BuscarCargo2 => _resourceManager.GetString("BuscarCargo", CultureInfo.CurrentUICulture);
        public static string PorcentajeGlobal => _resourceManager.GetString("PorcentajeGlobal", CultureInfo.CurrentUICulture);
        public static string NoExisteEseCargo => _resourceManager.GetString("NoExisteEseCargo", CultureInfo.CurrentUICulture);
        public static string LimpiarFiltros => _resourceManager.GetString("LimpiarFiltros", CultureInfo.CurrentUICulture);
        public static string ReunionesProgramadas => _resourceManager.GetString("ReunionesProgramadas", CultureInfo.CurrentUICulture);
        public static string ReunionesAsistidas => _resourceManager.GetString("ReunionesAsistidas", CultureInfo.CurrentUICulture);
        public static string PorcentajeAsistencia => _resourceManager.GetString("PorcentajeAsistencia", CultureInfo.CurrentUICulture);
        public static string Cargo => _resourceManager.GetString("Cargo", CultureInfo.CurrentUICulture);
        public static string SeleccioneDML => _resourceManager.GetString("SeleccioneDML", CultureInfo.CurrentUICulture);
        public static string AgregarFecha => _resourceManager.GetString("AgregarFecha", CultureInfo.CurrentUICulture);
        public static string FechasSeleccionadas => _resourceManager.GetString("FechasSeleccionadas", CultureInfo.CurrentUICulture);
        public static string Cancelar => _resourceManager.GetString("Cancelar", CultureInfo.CurrentUICulture);
        public static string NoHayFiltros => _resourceManager.GetString("NoHayFiltros", CultureInfo.CurrentUICulture);
        public static string IniciarSesion => _resourceManager.GetString("IniciarSesion", CultureInfo.CurrentUICulture);
        public static string CerrarSesion => _resourceManager.GetString("CerrarSesion", CultureInfo.CurrentUICulture);
        public static string Hola => _resourceManager.GetString("Hola", CultureInfo.CurrentUICulture);
        public static string Vencidos => _resourceManager.GetString("Vencidos", CultureInfo.CurrentUICulture);
        public static string ProximaParada => _resourceManager.GetString("ProximaParada", CultureInfo.CurrentUICulture);
        public static string FaltaRepuesto => _resourceManager.GetString("FaltaRepuesto", CultureInfo.CurrentUICulture);
        public static string FaltaDePersonal => _resourceManager.GetString("FaltaDePersonal", CultureInfo.CurrentUICulture);
        public static string EquipoNoDisponible => _resourceManager.GetString("EquipoNoDisponible", CultureInfo.CurrentUICulture);
        public static string ParadaMayor => _resourceManager.GetString("ParadaMayor", CultureInfo.CurrentUICulture);
        public static string Tiempo => _resourceManager.GetString("Tiempo", CultureInfo.CurrentUICulture);
        public static string Requisicion => _resourceManager.GetString("Requisicion", CultureInfo.CurrentUICulture);
        public static string FechaDeTrabajo => _resourceManager.GetString("FechaDeTrabajo", CultureInfo.CurrentUICulture);
        public static string ProximaFecha => _resourceManager.GetString("ProximaFecha", CultureInfo.CurrentUICulture);
        public static string Descripcion => _resourceManager.GetString("Descripcion", CultureInfo.CurrentUICulture);
        public static string Revisar => _resourceManager.GetString("Revisar", CultureInfo.CurrentUICulture);
        public static string CambiosDeFechaDeTrabajoRestantes => _resourceManager.GetString("CambiosDeFechaDeTrabajoRestantes", CultureInfo.CurrentUICulture);
        public static string Agregar => _resourceManager.GetString("Agregar", CultureInfo.CurrentUICulture);
        public static string SeleccioneBuscar => _resourceManager.GetString("SeleccioneBuscar", CultureInfo.CurrentUICulture);
        public static string VencidasTurno => _resourceManager.GetString("VencidasTurno", CultureInfo.CurrentUICulture);
        public static string PendientesLibro => _resourceManager.GetString("PendientesLibro", CultureInfo.CurrentUICulture);
        public static string KsfReunionDiaria => _resourceManager.GetString("KsfReunionDiaria", CultureInfo.CurrentUICulture);
        public static string NoRechazada => _resourceManager.GetString("NoRechazada", CultureInfo.CurrentUICulture);
        public static string DiscrepanciaRechazada => _resourceManager.GetString("DiscrepanciaRechazada", CultureInfo.CurrentUICulture);
        public static string NoAgregada => _resourceManager.GetString("NoAgregada", CultureInfo.CurrentUICulture);
        public static string ReunionQuincenalAgregada => _resourceManager.GetString("ReunionQuincenalAgregada", CultureInfo.CurrentUICulture);
        public static string VerifiqueCampos => _resourceManager.GetString("VerifiqueCampos", CultureInfo.CurrentUICulture);
        public static string Dia => _resourceManager.GetString("Dia", CultureInfo.CurrentUICulture);
        public static string Semana => _resourceManager.GetString("Semana", CultureInfo.CurrentUICulture);
        public static string Mes => _resourceManager.GetString("Mes", CultureInfo.CurrentUICulture);
        public static string Planificacion => _resourceManager.GetString("Planificacion", CultureInfo.CurrentUICulture);
        public static string Año => _resourceManager.GetString("Año", CultureInfo.CurrentUICulture);
        public static string Hoy => _resourceManager.GetString("Hoy", CultureInfo.CurrentUICulture);
        public static string Limite => _resourceManager.GetString("Limite", CultureInfo.CurrentUICulture);
        public static string FalloR => _resourceManager.GetString("FalloR", CultureInfo.CurrentUICulture);
        public static string ErrorP => _resourceManager.GetString("ErrorP", CultureInfo.CurrentUICulture);
        public static string ERevisar => _resourceManager.GetString("ERevisar", CultureInfo.CurrentUICulture);
        public static string FechaMenor => _resourceManager.GetString("FechaMenor", CultureInfo.CurrentUICulture);
        public static string VencidasDiaria => _resourceManager.GetString("VencidasDiaria", CultureInfo.CurrentUICulture);
        public static string PendientesDiaria => _resourceManager.GetString("PendientesDiaria", CultureInfo.CurrentUICulture);
        public static string ReunionQuincenal => _resourceManager.GetString("ReunionQuincenal", CultureInfo.CurrentUICulture);
        public static string PendienteFaltaRepuesto => _resourceManager.GetString("PendienteFaltaRepuesto", CultureInfo.CurrentUICulture);
        public static string FormatoDeReunion => _resourceManager.GetString("FormatoDeReunion", CultureInfo.CurrentUICulture);
        public static string Horas => _resourceManager.GetString("Horas", CultureInfo.CurrentUICulture);


        public static string MapResponsableKey(string nombre)
        {
            return nombre switch
            {
                "Mtto. Mecánico" => "Mtto_Mecanico",
                "Mtto. Eléctrico/Electrónico" => "Mtto_ElectricoElectronico",
                "Seguridad" => "Seguridad",
                "Calidad" => "Calidad",
                "Operaciones" => "Operaciones",
                "Por Definir" => "Por_Definir",
                "Compras" => "Compras",
                "Mtto. Instrumentación" => "Mtto_Instrumentacion",
                "Mtto. Infraestructura" => "Mtto_Infraestructura",
                "Efluentes" => "Efluentes",
                _ => nombre
            };
        }
        public static string MapStatusKey(string status)
        {
            return status switch
            {
                "Listo" => "Listo",
                "Cerrado" => "Cerrado",
                "No Conforme" => "NoConforme",
                "Pendiente/Responsable" => "PendienteResponsable",
                "Pendiente" => "Pendiente",
                "Revisar" => "Revisar",
                _ => status // fallback por si no hay traducción
            };
        }

        public static string TraducirKsf(int idPais, int idKsf, List<KsfDTO> ksfs)
        {
            var ksf = ksfs.FirstOrDefault(x => x.Idksf == idKsf);
            if (ksf == null) return string.Empty;

            return idPais == 5 ? ksf.KsfEnglish : ksf.KsfNombre;
        }

        public static string TraducirKsfManual(string ksfOriginal, int idPais)
{
    if (string.IsNullOrWhiteSpace(ksfOriginal))
        return string.Empty;

    // Diccionario de traducciones manuales
    var traducciones = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "Producción", "Production" },
        { "Mantenimiento", "Maintenance" },
        { "Calidad", "Quality" },
        { "Seguridad", "Security" },
        { "Auditoría", "Audit" },
        { "Preventivo", "Preventive" },
        { "RRHH", "HR" },
        { "Ambiente", "Ambience" },
        { "Reunión Diaria", "Daily Meeting" }
    };

    // Si el idioma es inglés (idPais == 5), traducir
    if (idPais == 5 && traducciones.ContainsKey(ksfOriginal))
        return traducciones[ksfOriginal];

    // Si no se requiere traducción o no se encuentra, devolver el original
    return ksfOriginal;
}


    }   

}





