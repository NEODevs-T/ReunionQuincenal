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

        public static string Accion => _resourceManager.GetString(nameof(Accion), CultureInfo.CurrentUICulture)!;
        public static string Acciones => _resourceManager.GetString(nameof(Acciones), CultureInfo.CurrentUICulture)!;
        public static string Aceptar => _resourceManager.GetString(nameof(Aceptar), CultureInfo.CurrentUICulture)!;
        public static string ADiscrepancia => _resourceManager.GetString(nameof(ADiscrepancia), CultureInfo.CurrentUICulture)!;
        public static string Advertencia => _resourceManager.GetString(nameof(Advertencia), CultureInfo.CurrentUICulture)!;
        public static string Area => _resourceManager.GetString(nameof(Area), CultureInfo.CurrentUICulture)!;
        public static string Asistencia => _resourceManager.GetString(nameof(Asistencia), CultureInfo.CurrentUICulture)!;
        public static string Asistentes => _resourceManager.GetString(nameof(Asistentes), CultureInfo.CurrentUICulture)!;
        public static string Asuntos => _resourceManager.GetString(nameof(Asuntos), CultureInfo.CurrentUICulture)!;
        public static string Atencion => _resourceManager.GetString(nameof(Atencion), CultureInfo.CurrentUICulture)!;
        public static string Atras => _resourceManager.GetString(nameof(Atras), CultureInfo.CurrentUICulture)!;
        public static string Bloque => _resourceManager.GetString(nameof(Bloque), CultureInfo.CurrentUICulture)!;
        public static string Borrar => _resourceManager.GetString(nameof(Borrar), CultureInfo.CurrentUICulture)!;
        public static string Buscar => _resourceManager.GetString(nameof(Buscar), CultureInfo.CurrentUICulture)!;
        public static string Calendario => _resourceManager.GetString(nameof(Calendario), CultureInfo.CurrentUICulture)!;
        public static string CambiosDeEstados => _resourceManager.GetString(nameof(CambiosDeEstados), CultureInfo.CurrentUICulture)!;
        public static string CambiosDeFechaTrabajo => _resourceManager.GetString(nameof(CambiosDeFechaTrabajo), CultureInfo.CurrentUICulture)!;
        public static string Centro => _resourceManager.GetString(nameof(Centro), CultureInfo.CurrentUICulture)!;
        public static string Cerrado => _resourceManager.GetString(nameof(Cerrado), CultureInfo.CurrentUICulture)!;
        public static string Codigo => _resourceManager.GetString(nameof(Codigo), CultureInfo.CurrentUICulture)!;
        public static string CodigoDeEquipo => _resourceManager.GetString(nameof(CodigoDeEquipo), CultureInfo.CurrentUICulture)!;
        public static string Consolidacion => _resourceManager.GetString(nameof(Consolidacion), CultureInfo.CurrentUICulture)!;
        public static string ConsolidacionDeDiscrepancia => _resourceManager.GetString(nameof(ConsolidacionDeDiscrepancia), CultureInfo.CurrentUICulture)!;
        public static string Consultar => _resourceManager.GetString(nameof(Consultar), CultureInfo.CurrentUICulture)!;
        public static string Correcto => _resourceManager.GetString(nameof(Correcto), CultureInfo.CurrentUICulture)!;
        public static string Desde => _resourceManager.GetString(nameof(Desde), CultureInfo.CurrentUICulture)!;
        public static string DetallesCalidad => _resourceManager.GetString(nameof(DetallesCalidad), CultureInfo.CurrentUICulture)!;
        public static string DetallesDeCalidad => _resourceManager.GetString(nameof(DetallesDeCalidad), CultureInfo.CurrentUICulture)!;
        public static string Discrepancia => _resourceManager.GetString(nameof(Discrepancia), CultureInfo.CurrentUICulture)!;
        public static string Discrepancias => _resourceManager.GetString(nameof(Discrepancias), CultureInfo.CurrentUICulture)!;
        public static string Division => _resourceManager.GetString(nameof(Division), CultureInfo.CurrentUICulture)!;
        public static string EDato => _resourceManager.GetString(nameof(EDato), CultureInfo.CurrentUICulture)!;
        public static string EditarDiscrepancia => _resourceManager.GetString(nameof(EditarDiscrepancia), CultureInfo.CurrentUICulture)!;
        public static string EnCurso => _resourceManager.GetString(nameof(EnCurso), CultureInfo.CurrentUICulture)!;
        public static string Error => _resourceManager.GetString(nameof(Error), CultureInfo.CurrentUICulture)!;
        public static string ErrorConexion => _resourceManager.GetString(nameof(ErrorConexion), CultureInfo.CurrentUICulture)!;
        public static string ErrorConexionM => _resourceManager.GetString(nameof(ErrorConexionM), CultureInfo.CurrentUICulture)!;
        public static string ErrorInesp => _resourceManager.GetString(nameof(ErrorInesp), CultureInfo.CurrentUICulture)!;
        public static string ErrorInser => _resourceManager.GetString(nameof(ErrorInser), CultureInfo.CurrentUICulture)!;
        public static string Estado => _resourceManager.GetString(nameof(Estado), CultureInfo.CurrentUICulture)!;
        public static string Exito => _resourceManager.GetString(nameof(Exito), CultureInfo.CurrentUICulture)!;
        public static string FReunion => _resourceManager.GetString(nameof(FReunion), CultureInfo.CurrentUICulture)!;
        public static string FTrabajo => _resourceManager.GetString(nameof(FTrabajo), CultureInfo.CurrentUICulture)!;
        public static string FechaDeReunion => _resourceManager.GetString(nameof(FechaDeReunion), CultureInfo.CurrentUICulture)!;
        public static string FechaDelCambio => _resourceManager.GetString(nameof(FechaDelCambio), CultureInfo.CurrentUICulture)!;
        public static string Filtrar => _resourceManager.GetString(nameof(Filtrar), CultureInfo.CurrentUICulture)!;
        public static string FiltroFechaDeReunion => _resourceManager.GetString(nameof(FiltroFechaDeReunion), CultureInfo.CurrentUICulture)!;
        public static string FiltroFechaDeTrabajo => _resourceManager.GetString(nameof(FiltroFechaDeTrabajo), CultureInfo.CurrentUICulture)!;
        public static string Guardar => _resourceManager.GetString(nameof(Guardar), CultureInfo.CurrentUICulture)!;
        public static string Hasta => _resourceManager.GetString(nameof(Hasta), CultureInfo.CurrentUICulture)!;
        public static string hay_registros_vencidos => _resourceManager.GetString(nameof(hay_registros_vencidos), CultureInfo.CurrentUICulture)!;
        public static string Historicos => _resourceManager.GetString(nameof(Historicos), CultureInfo.CurrentUICulture)!;
        public static string Imprimir => _resourceManager.GetString(nameof(Imprimir), CultureInfo.CurrentUICulture)!;
        public static string Linea => _resourceManager.GetString(nameof(Linea), CultureInfo.CurrentUICulture)!;
        public static string Listo => _resourceManager.GetString(nameof(Listo), CultureInfo.CurrentUICulture)!;
        public static string LlDisp => _resourceManager.GetString(nameof(LlDisp), CultureInfo.CurrentUICulture)!;
        public static string NEquipo => _resourceManager.GetString(nameof(NEquipo), CultureInfo.CurrentUICulture)!;
        public static string NFDatos => _resourceManager.GetString(nameof(NFDatos), CultureInfo.CurrentUICulture)!;
        public static string NPA1 => _resourceManager.GetString(nameof(NPA1), CultureInfo.CurrentUICulture)!;
        public static string NPA2 => _resourceManager.GetString(nameof(NPA2), CultureInfo.CurrentUICulture)!;
        public static string NSDatos => _resourceManager.GetString(nameof(NSDatos), CultureInfo.CurrentUICulture)!;
        public static string NoCargadoP => _resourceManager.GetString(nameof(NoCargadoP), CultureInfo.CurrentUICulture)!;
        public static string NoConforme => _resourceManager.GetString(nameof(NoConforme), CultureInfo.CurrentUICulture)!;
        public static string NoHayDatos => _resourceManager.GetString(nameof(NoHayDatos), CultureInfo.CurrentUICulture)!;
        public static string NoHayDatos2 => _resourceManager.GetString(nameof(NoHayDatos2), CultureInfo.CurrentUICulture)!;
        public static string NoHayDescrip => _resourceManager.GetString(nameof(NoHayDescrip), CultureInfo.CurrentUICulture)!;
        public static string NoHayEquipos => _resourceManager.GetString(nameof(NoHayEquipos), CultureInfo.CurrentUICulture)!;
        public static string NoHayRegistros => _resourceManager.GetString(nameof(NoHayRegistros), CultureInfo.CurrentUICulture)!;
        public static string NoHayRegistros2 => _resourceManager.GetString(nameof(NoHayRegistros2), CultureInfo.CurrentUICulture)!;
        public static string NombreDelEquipo => _resourceManager.GetString(nameof(NombreDelEquipo), CultureInfo.CurrentUICulture)!;
        public static string NuevaFechaDeTrabajo => _resourceManager.GetString(nameof(NuevaFechaDeTrabajo), CultureInfo.CurrentUICulture)!;
        public static string Nuevo => _resourceManager.GetString(nameof(Nuevo), CultureInfo.CurrentUICulture)!;
        public static string ODT => _resourceManager.GetString(nameof(ODT), CultureInfo.CurrentUICulture)!;
        public static string ObservacionesDeCalidad => _resourceManager.GetString(nameof(ObservacionesDeCalidad), CultureInfo.CurrentUICulture)!;
        public static string Ordenar => _resourceManager.GetString(nameof(Ordenar), CultureInfo.CurrentUICulture)!;
        public static string OrgDelProducto => _resourceManager.GetString(nameof(OrgDelProducto), CultureInfo.CurrentUICulture)!;
        public static string Pendiente => _resourceManager.GetString(nameof(Pendiente), CultureInfo.CurrentUICulture)!;
        public static string Personal => _resourceManager.GetString(nameof(Personal), CultureInfo.CurrentUICulture)!;
        public static string PlanDeAccion => _resourceManager.GetString(nameof(PlanDeAccion), CultureInfo.CurrentUICulture)!;
        public static string Presencia => _resourceManager.GetString(nameof(Presencia), CultureInfo.CurrentUICulture)!;
        public static string RExitoso => _resourceManager.GetString(nameof(RExitoso), CultureInfo.CurrentUICulture)!;
        public static string RHorario => _resourceManager.GetString(nameof(RHorario), CultureInfo.CurrentUICulture)!;
        public static string Reload => _resourceManager.GetString(nameof(Reload), CultureInfo.CurrentUICulture)!;
        public static string RequiredPassword => _resourceManager.GetString(nameof(RequiredPassword), CultureInfo.CurrentUICulture)!;
        public static string RequiredUserName => _resourceManager.GetString(nameof(RequiredUserName), CultureInfo.CurrentUICulture)!;
        public static string Responsable => _resourceManager.GetString(nameof(Responsable), CultureInfo.CurrentUICulture)!;
        public static string Reunion => _resourceManager.GetString(nameof(Reunion), CultureInfo.CurrentUICulture)!;
        public static string SArea => _resourceManager.GetString(nameof(SArea), CultureInfo.CurrentUICulture)!;
        public static string SCentro => _resourceManager.GetString(nameof(SCentro), CultureInfo.CurrentUICulture)!;
        public static string SDivision => _resourceManager.GetString(nameof(SDivision), CultureInfo.CurrentUICulture)!;
        public static string SEstado => _resourceManager.GetString(nameof(SEstado), CultureInfo.CurrentUICulture)!;
        public static string SSuplente => _resourceManager.GetString(nameof(SSuplente), CultureInfo.CurrentUICulture)!;
        public static string SVCentro => _resourceManager.GetString(nameof(SVCentro), CultureInfo.CurrentUICulture)!;
        public static string SVDivision => _resourceManager.GetString(nameof(SVDivision), CultureInfo.CurrentUICulture)!;
        public static string SVLista => _resourceManager.GetString(nameof(SVLista), CultureInfo.CurrentUICulture)!;
        public static string Seleccione => _resourceManager.GetString(nameof(Seleccione), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnCentro => _resourceManager.GetString(nameof(SeleccioneUnCentro), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnaDivision => _resourceManager.GetString(nameof(SeleccioneUnaDivision), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneUnaEmpresa => _resourceManager.GetString(nameof(SeleccioneUnaEmpresa), CultureInfo.CurrentUICulture)!;
        public static string StatusNuevo => _resourceManager.GetString(nameof(StatusNuevo), CultureInfo.CurrentUICulture)!;
        public static string Suplencia => _resourceManager.GetString(nameof(Suplencia), CultureInfo.CurrentUICulture)!;
        public static string TCargos => _resourceManager.GetString(nameof(TCargos), CultureInfo.CurrentUICulture)!;
        public static string Todo => _resourceManager.GetString(nameof(Todo), CultureInfo.CurrentUICulture)!;
        public static string Todos => _resourceManager.GetString(nameof(Todos), CultureInfo.CurrentUICulture)!;
        public static string TotalPendiente => _resourceManager.GetString(nameof(TotalPendiente), CultureInfo.CurrentUICulture)!;
        public static string Trazabilidad => _resourceManager.GetString(nameof(Trazabilidad), CultureInfo.CurrentUICulture)!;
        public static string Usuario => _resourceManager.GetString(nameof(Usuario), CultureInfo.CurrentUICulture)!;
        public static string PorcentajeDeAsistencia => _resourceManager.GetString(nameof(PorcentajeDeAsistencia), CultureInfo.CurrentUICulture)!;
        public static string FechaInicial => _resourceManager.GetString(nameof(FechaInicial), CultureInfo.CurrentUICulture)!;
        public static string FechaFinal => _resourceManager.GetString(nameof(FechaFinal), CultureInfo.CurrentUICulture)!;
        public static string Empresa => _resourceManager.GetString(nameof(Empresa), CultureInfo.CurrentUICulture)!;
        public static string ExcluirLosDiasNoLaborables => _resourceManager.GetString(nameof(ExcluirLosDiasNoLaborables), CultureInfo.CurrentUICulture)!;
        public static string DiasNoLaborables => _resourceManager.GetString(nameof(DiasNoLaborables), CultureInfo.CurrentUICulture)!;
        public static string FiltrarPorCargo => _resourceManager.GetString(nameof(FiltrarPorCargo), CultureInfo.CurrentUICulture)!;
        public static string BuscarCargo => _resourceManager.GetString(nameof(BuscarCargo), CultureInfo.CurrentUICulture)!;
        public static string BuscarCargo2 => _resourceManager.GetString(nameof(BuscarCargo), CultureInfo.CurrentUICulture)!;
        public static string PorcentajeGlobal => _resourceManager.GetString(nameof(PorcentajeGlobal), CultureInfo.CurrentUICulture)!;
        public static string NoExisteEseCargo => _resourceManager.GetString(nameof(NoExisteEseCargo), CultureInfo.CurrentUICulture)!;
        public static string LimpiarFiltros => _resourceManager.GetString(nameof(LimpiarFiltros), CultureInfo.CurrentUICulture)!;
        public static string ReunionesProgramadas => _resourceManager.GetString(nameof(ReunionesProgramadas), CultureInfo.CurrentUICulture)!;
        public static string ReunionesAsistidas => _resourceManager.GetString(nameof(ReunionesAsistidas), CultureInfo.CurrentUICulture)!;
        public static string ReunionesConSuplencias => _resourceManager.GetString(nameof(ReunionesConSuplencias), CultureInfo.CurrentUICulture)!;
        public static string PorcentajeAsistencia => _resourceManager.GetString(nameof(PorcentajeAsistencia), CultureInfo.CurrentUICulture)!;
        public static string PorcentajeSuplencia => _resourceManager.GetString(nameof(PorcentajeSuplencia), CultureInfo.CurrentUICulture)!;
        public static string Cargo => _resourceManager.GetString(nameof(Cargo), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneDML => _resourceManager.GetString(nameof(SeleccioneDML), CultureInfo.CurrentUICulture)!;
        public static string AgregarFecha => _resourceManager.GetString(nameof(AgregarFecha), CultureInfo.CurrentUICulture)!;
        public static string FechasSeleccionadas => _resourceManager.GetString(nameof(FechasSeleccionadas), CultureInfo.CurrentUICulture)!;
        public static string Cancelar => _resourceManager.GetString(nameof(Cancelar), CultureInfo.CurrentUICulture)!;
        public static string NoHayFiltros => _resourceManager.GetString(nameof(NoHayFiltros), CultureInfo.CurrentUICulture)!;
        public static string IniciarSesion => _resourceManager.GetString(nameof(IniciarSesion), CultureInfo.CurrentUICulture)!;
        public static string CerrarSesion => _resourceManager.GetString(nameof(CerrarSesion), CultureInfo.CurrentUICulture)!;
        public static string Hola => _resourceManager.GetString(nameof(Hola), CultureInfo.CurrentUICulture)!;
        public static string Vencidos => _resourceManager.GetString(nameof(Vencidos), CultureInfo.CurrentUICulture)!;
        public static string ProximaParada => _resourceManager.GetString(nameof(ProximaParada), CultureInfo.CurrentUICulture)!;
        public static string FaltaRepuesto => _resourceManager.GetString(nameof(FaltaRepuesto), CultureInfo.CurrentUICulture)!;
        public static string FaltaDePersonal => _resourceManager.GetString(nameof(FaltaDePersonal), CultureInfo.CurrentUICulture)!;
        public static string EquipoNoDisponible => _resourceManager.GetString(nameof(EquipoNoDisponible), CultureInfo.CurrentUICulture)!;
        public static string ParadaMayor => _resourceManager.GetString(nameof(ParadaMayor), CultureInfo.CurrentUICulture)!;
        public static string Tiempo => _resourceManager.GetString(nameof(Tiempo), CultureInfo.CurrentUICulture)!;
        public static string Requisicion => _resourceManager.GetString(nameof(Requisicion), CultureInfo.CurrentUICulture)!;
        public static string FechaDeTrabajo => _resourceManager.GetString(nameof(FechaDeTrabajo), CultureInfo.CurrentUICulture)!;
        public static string ProximaFecha => _resourceManager.GetString(nameof(ProximaFecha), CultureInfo.CurrentUICulture)!;
        public static string Descripcion => _resourceManager.GetString(nameof(Descripcion), CultureInfo.CurrentUICulture)!;
        public static string Revisar => _resourceManager.GetString(nameof(Revisar), CultureInfo.CurrentUICulture)!;
        public static string CambiosDeFechaDeTrabajoRestantes => _resourceManager.GetString(nameof(CambiosDeFechaDeTrabajoRestantes), CultureInfo.CurrentUICulture)!;
        public static string Agregar => _resourceManager.GetString(nameof(Agregar), CultureInfo.CurrentUICulture)!;
        public static string SeleccioneBuscar => _resourceManager.GetString(nameof(SeleccioneBuscar), CultureInfo.CurrentUICulture)!;
        public static string VencidasTurno => _resourceManager.GetString(nameof(VencidasTurno), CultureInfo.CurrentUICulture)!;
        public static string PendientesLibro => _resourceManager.GetString(nameof(PendientesLibro), CultureInfo.CurrentUICulture)!;
        public static string KsfReunionDiaria => _resourceManager.GetString(nameof(KsfReunionDiaria), CultureInfo.CurrentUICulture)!;
        public static string NoRechazada => _resourceManager.GetString(nameof(NoRechazada), CultureInfo.CurrentUICulture)!;
        public static string DiscrepanciaRechazada => _resourceManager.GetString(nameof(DiscrepanciaRechazada), CultureInfo.CurrentUICulture)!;
        public static string NoAgregada => _resourceManager.GetString(nameof(NoAgregada), CultureInfo.CurrentUICulture)!;
        public static string ReunionDiariaAgregada => _resourceManager.GetString(nameof(ReunionDiariaAgregada), CultureInfo.CurrentUICulture)!;
        public static string VerifiqueCampos => _resourceManager.GetString(nameof(VerifiqueCampos), CultureInfo.CurrentUICulture)!;
        public static string Dia => _resourceManager.GetString(nameof(Dia), CultureInfo.CurrentUICulture)!;
        public static string Semana => _resourceManager.GetString(nameof(Semana), CultureInfo.CurrentUICulture)!;
        public static string Mes => _resourceManager.GetString(nameof(Mes), CultureInfo.CurrentUICulture)!;
        public static string Planificacion => _resourceManager.GetString(nameof(Planificacion), CultureInfo.CurrentUICulture)!;
        public static string Año => _resourceManager.GetString(nameof(Año), CultureInfo.CurrentUICulture)!;
        public static string Hoy => _resourceManager.GetString(nameof(Hoy), CultureInfo.CurrentUICulture)!;
        public static string Limite => _resourceManager.GetString(nameof(Limite), CultureInfo.CurrentUICulture)!;
        public static string FalloR => _resourceManager.GetString(nameof(FalloR), CultureInfo.CurrentUICulture)!;
        public static string ErrorP => _resourceManager.GetString(nameof(ErrorP), CultureInfo.CurrentUICulture)!;
        public static string ERevisar => _resourceManager.GetString(nameof(ERevisar), CultureInfo.CurrentUICulture)!;
        public static string FechaMenor => _resourceManager.GetString(nameof(FechaMenor), CultureInfo.CurrentUICulture)!;
        public static string VencidasDiaria => _resourceManager.GetString(nameof(VencidasDiaria), CultureInfo.CurrentUICulture)!;
        public static string PendientesDiaria => _resourceManager.GetString(nameof(PendientesDiaria), CultureInfo.CurrentUICulture)!;
        public static string ReunionQuincenal => _resourceManager.GetString(nameof(ReunionQuincenal), CultureInfo.CurrentUICulture)!;
        public static string PendienteFaltaRepuesto => _resourceManager.GetString(nameof(PendienteFaltaRepuesto), CultureInfo.CurrentUICulture)!;
        public static string FormatoDeReunion => _resourceManager.GetString(nameof(FormatoDeReunion), CultureInfo.CurrentUICulture)!;
        public static string Horas => _resourceManager.GetString(nameof(Horas), CultureInfo.CurrentUICulture)!;
        public static string NoResponsable => _resourceManager.GetString(nameof(NoResponsable), CultureInfo.CurrentUICulture)!;


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
        public static string MapStatusKey(string? status)
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
    }   

}





