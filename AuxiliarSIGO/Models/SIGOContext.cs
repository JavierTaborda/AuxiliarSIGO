using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AuxiliarSIGO.Models
{
    public partial class SIGOContext : DbContext
    {
        public SIGOContext()
        {
        }

        public SIGOContext(DbContextOptions<SIGOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<Calidad> Calidads { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Cedula> Cedulas { get; set; } = null!;
        public virtual DbSet<Centr> Centrs { get; set; } = null!;
        public virtual DbSet<CentroTrabajo> CentroTrabajos { get; set; } = null!;
        public virtual DbSet<ConvertirUnidad> ConvertirUnidads { get; set; } = null!;
        public virtual DbSet<DataAuditorium> DataAuditoria { get; set; } = null!;
        public virtual DbSet<DataAutogestion> DataAutogestions { get; set; } = null!;
        public virtual DbSet<DataBomba> DataBombas { get; set; } = null!;
        public virtual DbSet<DataReporte> DataReportes { get; set; } = null!;
        public virtual DbSet<Datum> Data { get; set; } = null!;
        public virtual DbSet<Discrepancium> Discrepancia { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Eameqmst> Eameqmsts { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Equipo> Equipos { get; set; } = null!;
        public virtual DbSet<EquipoMuestreo> EquipoMuestreos { get; set; } = null!;
        public virtual DbSet<Frecuencium> Frecuencia { get; set; } = null!;
        public virtual DbSet<Idioma> Idiomas { get; set; } = null!;
        public virtual DbSet<Literal> Literals { get; set; } = null!;
        public virtual DbSet<MasterBomba> MasterBombas { get; set; } = null!;
        public virtual DbSet<MasterGeneral> MasterGenerals { get; set; } = null!;
        public virtual DbSet<MasterReporte> MasterReportes { get; set; } = null!;
        public virtual DbSet<MasterVariable> MasterVariables { get; set; } = null!;
        public virtual DbSet<MasterVariable101320> MasterVariable101320s { get; set; } = null!;
        public virtual DbSet<MasterVariable123> MasterVariable123s { get; set; } = null!;
        public virtual DbSet<MasterVariablebk> MasterVariablebks { get; set; } = null!;
        public virtual DbSet<NivelAcceso> NivelAccesos { get; set; } = null!;
        public virtual DbSet<PowerSuite> PowerSuites { get; set; } = null!;
        public virtual DbSet<Prueba> Pruebas { get; set; } = null!;
        public virtual DbSet<PuntoMuestreo> PuntoMuestreos { get; set; } = null!;
        public virtual DbSet<ReporteArea> ReporteAreas { get; set; } = null!;
        public virtual DbSet<ReporteArea1> ReporteAreas1 { get; set; } = null!;
        public virtual DbSet<Rotacion> Rotacions { get; set; } = null!;
        public virtual DbSet<RzCodCasusaPt> RzCodCasusaPts { get; set; } = null!;
        public virtual DbSet<Seccion> Seccions { get; set; } = null!;
        public virtual DbSet<SeccionMaquina> SeccionMaquinas { get; set; } = null!;
        public virtual DbSet<StatusAuto> StatusAutos { get; set; } = null!;
        public virtual DbSet<StatusAuto1> StatusAutos1 { get; set; } = null!;
        public virtual DbSet<TbEquipo> TbEquipos { get; set; } = null!;
        public virtual DbSet<TbEquiposTmp> TbEquiposTmps { get; set; } = null!;
        public virtual DbSet<TbInvPartesAr> TbInvPartesArs { get; set; } = null!;
        public virtual DbSet<TbInvPartesTmp> TbInvPartesTmps { get; set; } = null!;
        public virtual DbSet<TbParam> TbParams { get; set; } = null!;
        public virtual DbSet<TbUser> TbUsers { get; set; } = null!;
        public virtual DbSet<Temp> Temps { get; set; } = null!;
        public virtual DbSet<TipoProducto> TipoProductos { get; set; } = null!;
        public virtual DbSet<TipoReporte> TipoReportes { get; set; } = null!;
        public virtual DbSet<TipoVariable> TipoVariables { get; set; } = null!;
        public virtual DbSet<TituloReporte> TituloReportes { get; set; } = null!;
        public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<VarDif> VarDifs { get; set; } = null!;
        public virtual DbSet<VarDif1> VarDifs1 { get; set; } = null!;
        public virtual DbSet<Variable> Variables { get; set; } = null!;
        public virtual DbSet<VariableRegional> VariableRegionals { get; set; } = null!;
        public virtual DbSet<VariablesAutoMaster> VariablesAutoMasters { get; set; } = null!;
        public virtual DbSet<VariablesAutoMaster1> VariablesAutoMasters1 { get; set; } = null!;
        public virtual DbSet<VistaDiarioDiscrepanciaTurno> VistaDiarioDiscrepanciaTurnos { get; set; } = null!;
        public virtual DbSet<VwGrafDiscreMensual> VwGrafDiscreMensuals { get; set; } = null!;
        public virtual DbSet<VwReportDiario> VwReportDiarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=Dctdtdb01;UID=usrSigoRead;PWD=v3S19o534d*;Initial Catalog=SIGO;TrustServerCertificate=True;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.ToTable("AREA", "SIGO");

                entity.Property(e => e.IdArea).HasColumnName("ID_AREA");

                entity.Property(e => e.CodArea)
                    .HasMaxLength(3)
                    .HasColumnName("COD_AREA")
                    .IsFixedLength();

                entity.Property(e => e.NombreArea)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_AREA");
            });

            modelBuilder.Entity<Calidad>(entity =>
            {
                entity.ToTable("CALIDAD", "SIGO");

                entity.Property(e => e.CalidadId).HasColumnName("CALIDAD_ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.Sord)
                    .HasMaxLength(10)
                    .HasColumnName("SORD")
                    .IsFixedLength();

                entity.Property(e => e.TipoProducId).HasColumnName("TIPO_PRODUC_ID");

                entity.Property(e => e.Wrk)
                    .HasMaxLength(10)
                    .HasColumnName("WRK")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CATEGORIA");

                entity.Property(e => e.CategoriaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGORIA_ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.DescripcionAlterna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_ALTERNA");

                entity.Property(e => e.Posicion).HasColumnName("POSICION");
            });

            modelBuilder.Entity<Cedula>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cedulas");

                entity.Property(e => e.Cedulas)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cedulas");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Centr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CENTR", "Cmm");

                entity.Property(e => e.Cecctr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CECCTR");

                entity.Property(e => e.Cedesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CEDESC");

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");
            });

            modelBuilder.Entity<CentroTrabajo>(entity =>
            {
                entity.ToTable("CENTRO_TRABAJO", "SIGO");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.CodCentroTrabajo).HasColumnName("COD_CENTRO_TRABAJO");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.NombreCentroTrabajo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_CENTRO_TRABAJO");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<ConvertirUnidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONVERTIR_UNIDAD");

                entity.Property(e => e.ConversionUnidadId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONVERSION_UNIDAD_ID");

                entity.Property(e => e.Factor).HasColumnName("FACTOR");

                entity.Property(e => e.UnidadDestino).HasColumnName("UNIDAD_DESTINO");

                entity.Property(e => e.UnidadaBase).HasColumnName("UNIDADA_BASE");
            });

            modelBuilder.Entity<DataAuditorium>(entity =>
            {
                entity.HasKey(e => e.DataAuditoriaId);

                entity.ToTable("DATA_AUDITORIA", "SIGO");

                entity.Property(e => e.DataAuditoriaId).HasColumnName("DATA_AUDITORIA_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.Incumplimiento).HasColumnName("INCUMPLIMIENTO");

                entity.Property(e => e.MaqParada).HasColumnName("MAQ_PARADA");

                entity.Property(e => e.MasterGeneralId).HasColumnName("MASTER_GENERAL_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");

                entity.Property(e => e.ValorCampo).HasColumnName("VALOR_CAMPO");

                entity.Property(e => e.ValorIndicador).HasColumnName("VALOR_INDICADOR");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<DataAutogestion>(entity =>
            {
                entity.HasKey(e => e.DataId)
                    .HasName("PK_DATA1");

                entity.ToTable("DATA_AUTOGESTION", "SIGO");

                entity.Property(e => e.DataId).HasColumnName("DATA_ID");

                entity.Property(e => e.Bolean).HasColumnName("BOLEAN");

                entity.Property(e => e.CalidadId)
                    .HasMaxLength(30)
                    .HasColumnName("CALIDAD_ID")
                    .IsFixedLength();

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Formulario).HasColumnName("FORMULARIO");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(2)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.Incumplimiento).HasColumnName("INCUMPLIMIENTO");

                entity.Property(e => e.MaqParada).HasColumnName("MAQ_PARADA");

                entity.Property(e => e.MasterVariableId).HasColumnName("MASTER_VARIABLE_ID");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.Procesada).HasColumnName("PROCESADA");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.Turno).HasColumnName("TURNO");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");

                entity.Property(e => e.Valor).HasColumnName("VALOR");
            });

            modelBuilder.Entity<DataBomba>(entity =>
            {
                entity.HasKey(e => e.DataBombasId);

                entity.ToTable("DATA_BOMBAS", "SIGO");

                entity.Property(e => e.DataBombasId).HasColumnName("DATA_BOMBAS_ID");

                entity.Property(e => e.Alarma)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ALARMA");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Flujo).HasColumnName("FLUJO");

                entity.Property(e => e.Fugas)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("FUGAS");

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.Incumplimiento).HasColumnName("INCUMPLIMIENTO");

                entity.Property(e => e.MaqParada).HasColumnName("MAQ_PARADA");

                entity.Property(e => e.MasterBombasId).HasColumnName("MASTER_BOMBAS_ID");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Operativa)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OPERATIVA");

                entity.Property(e => e.Trabaja)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TRABAJA");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");
            });

            modelBuilder.Entity<DataReporte>(entity =>
            {
                entity.HasKey(e => e.DataReportesId);

                entity.ToTable("DATA_REPORTES", "SIGO");

                entity.Property(e => e.DataReportesId).HasColumnName("DATA_REPORTES_ID");

                entity.Property(e => e.CalidadId).HasColumnName("CALIDAD_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(5)
                    .HasColumnName("GRUPO");

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.Incumplimiento).HasColumnName("INCUMPLIMIENTO");

                entity.Property(e => e.MaqParada).HasColumnName("MAQ_PARADA");

                entity.Property(e => e.MasterReporteId).HasColumnName("MASTER_REPORTE_ID");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.Procesada).HasColumnName("PROCESADA");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.Turno).HasColumnName("TURNO");

                entity.Property(e => e.UnidadMedidaId)
                    .HasMaxLength(20)
                    .HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");

                entity.Property(e => e.Valor).HasColumnName("VALOR");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasKey(e => e.DataId);

                entity.ToTable("DATA", "SIGO");

                entity.Property(e => e.DataId).HasColumnName("DATA_ID");

                entity.Property(e => e.Bolean).HasColumnName("BOLEAN");

                entity.Property(e => e.CalidadId)
                    .HasMaxLength(30)
                    .HasColumnName("CALIDAD_ID")
                    .IsFixedLength();

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Formulario).HasColumnName("FORMULARIO");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(2)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.Incumplimiento).HasColumnName("INCUMPLIMIENTO");

                entity.Property(e => e.MaqParada).HasColumnName("MAQ_PARADA");

                entity.Property(e => e.MasterVariableId).HasColumnName("MASTER_VARIABLE_ID");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.Procesada).HasColumnName("PROCESADA");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.Turno).HasColumnName("TURNO");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");

                entity.Property(e => e.Valor).HasColumnName("VALOR");
            });

            modelBuilder.Entity<Discrepancium>(entity =>
            {
                entity.HasKey(e => e.DiscrepanciaId)
                    .HasName("PK_SIGO.DISCREPANCIA");

                entity.ToTable("DISCREPANCIA", "SIGO");

                entity.Property(e => e.DiscrepanciaId).HasColumnName("DISCREPANCIA_ID");

                entity.Property(e => e.Accion)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("ACCION");

                entity.Property(e => e.CategoriaId).HasColumnName("CATEGORIA_ID");

                entity.Property(e => e.DataId).HasColumnName("DATA_ID");

                entity.Property(e => e.Discrepancia2).HasColumnName("DISCREPANCIA_2");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.HoraAccion)
                    .HasMaxLength(10)
                    .HasColumnName("HORA_ACCION")
                    .IsFixedLength();

                entity.Property(e => e.HoraValor).HasColumnName("HORA_VALOR");

                entity.Property(e => e.Pws).HasColumnName("PWS");

                entity.Property(e => e.PwsStatus).HasColumnName("PWS_STATUS");

                entity.Property(e => e.StatusAccion).HasColumnName("STATUS_ACCION");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");

                entity.Property(e => e.ValorPlanAccion).HasColumnName("VALOR_PLAN_ACCION");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.DivisionesId);

                entity.ToTable("DIVISION", "SIGO");

                entity.Property(e => e.DivisionesId).HasColumnName("DIVISIONES_ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Division1)
                    .HasMaxLength(10)
                    .HasColumnName("DIVISION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Eameqmst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EAMEQMST", "Cmm");

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");

                entity.Property(e => e.Eaddnl)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EADDNL");

                entity.Property(e => e.Ecstcr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ECSTCR");

                entity.Property(e => e.Edescr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EDESCR");

                entity.Property(e => e.Eqccft)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("EQCCFT");

                entity.Property(e => e.Eqco)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("EQCO");

                entity.Property(e => e.Eqdept)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EQDEPT");

                entity.Property(e => e.Eqid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EQID");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("EMPRESA", "SIGO");

                entity.Property(e => e.IdEmpresa).HasColumnName("ID_EMPRESA");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Empresa1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.Idioma).HasColumnName("IDIOMA");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.ToTable("EQUIPO", "SIGO");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.CentroCosto)
                    .HasMaxLength(10)
                    .HasColumnName("CENTRO_COSTO")
                    .IsFixedLength();

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.CodEam)
                    .HasMaxLength(10)
                    .HasColumnName("COD_EAM")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<EquipoMuestreo>(entity =>
            {
                entity.ToTable("EQUIPO_MUESTREO", "SIGO");

                entity.Property(e => e.EquipoMuestreoId).HasColumnName("EQUIPO_MUESTREO_ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");
            });

            modelBuilder.Entity<Frecuencium>(entity =>
            {
                entity.HasKey(e => e.FrecuenciaId);

                entity.ToTable("FRECUENCIA", "SIGO");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(10)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.ToTable("IDIOMA");

                entity.Property(e => e.IdiomaId).HasColumnName("IDIOMA_ID");

                entity.Property(e => e.Idioma1)
                    .HasMaxLength(10)
                    .HasColumnName("IDIOMA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Literal>(entity =>
            {
                entity.ToTable("LITERAL");

                entity.Property(e => e.LiteralId).HasColumnName("LITERAL_ID");

                entity.Property(e => e.CodLiteral)
                    .HasMaxLength(10)
                    .HasColumnName("COD_LITERAL")
                    .IsFixedLength();

                entity.Property(e => e.IdiomaId).HasColumnName("IDIOMA_ID");

                entity.Property(e => e.Literal1)
                    .HasMaxLength(50)
                    .HasColumnName("LITERAL");
            });

            modelBuilder.Entity<MasterBomba>(entity =>
            {
                entity.HasKey(e => e.MasterBombasId);

                entity.ToTable("MASTER_BOMBAS", "SIGO");

                entity.Property(e => e.MasterBombasId).HasColumnName("MASTER_BOMBAS_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.FlujoGpm).HasColumnName("FLUJO_GPM");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");
            });

            modelBuilder.Entity<MasterGeneral>(entity =>
            {
                entity.ToTable("MASTER_GENERAL", "SIGO");

                entity.Property(e => e.MasterGeneralId).HasColumnName("MASTER_GENERAL_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Desviacion).HasColumnName("DESVIACION");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.LMax).HasColumnName("L_MAX");

                entity.Property(e => e.LMin).HasColumnName("L_MIN");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.VariableId)
                    .HasMaxLength(10)
                    .HasColumnName("VARIABLE_ID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MasterReporte>(entity =>
            {
                entity.HasKey(e => e.MasterReportesId);

                entity.ToTable("MASTER_REPORTES", "SIGO");

                entity.Property(e => e.MasterReportesId).HasColumnName("MASTER_REPORTES_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.LimMax).HasColumnName("LIM_MAX");

                entity.Property(e => e.LimMin).HasColumnName("LIM_MIN");

                entity.Property(e => e.MasterVariableId).HasColumnName("MASTER_VARIABLE_ID");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<MasterVariable>(entity =>
            {
                entity.ToTable("MASTER_VARIABLE", "SIGO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Auditoria).HasColumnName("AUDITORIA");

                entity.Property(e => e.Bolean).HasColumnName("BOLEAN");

                entity.Property(e => e.CalidadId)
                    .HasMaxLength(10)
                    .HasColumnName("CALIDAD_ID")
                    .IsFixedLength();

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EncabezadoId).HasColumnName("ENCABEZADO_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.Limax).HasColumnName("LIMAX");

                entity.Property(e => e.Limin).HasColumnName("LIMIN");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.PosFormato).HasColumnName("POS_FORMATO");

                entity.Property(e => e.PosReporte).HasColumnName("POS_REPORTE");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.StatusPws).HasColumnName("STATUS_PWS");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.TipoVariableId).HasColumnName("TIPO_VARIABLE_ID");

                entity.Property(e => e.TituloReporteId).HasColumnName("TITULO_REPORTE_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<MasterVariable101320>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_VARIABLE_101320", "SIGO");

                entity.Property(e => e.Auditoria)
                    .HasMaxLength(255)
                    .HasColumnName("AUDITORIA");

                entity.Property(e => e.Bolean).HasColumnName("BOLEAN");

                entity.Property(e => e.CalidadId).HasColumnName("CALIDAD_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EncabezadoId).HasColumnName("ENCABEZADO_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Limax).HasColumnName("LIMAX");

                entity.Property(e => e.Limin).HasColumnName("LIMIN");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.PosFormato).HasColumnName("POS_FORMATO");

                entity.Property(e => e.PosReporte).HasColumnName("POS_REPORTE");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.StatusPws)
                    .HasMaxLength(255)
                    .HasColumnName("STATUS_PWS");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.TipoVariableId).HasColumnName("TIPO_VARIABLE_ID");

                entity.Property(e => e.TituloReporteId)
                    .HasMaxLength(255)
                    .HasColumnName("TITULO_REPORTE_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<MasterVariable123>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_VARIABLE123", "SIGO");

                entity.Property(e => e.Auditoria)
                    .HasMaxLength(255)
                    .HasColumnName("AUDITORIA");

                entity.Property(e => e.Bolean).HasColumnName("BOLEAN");

                entity.Property(e => e.CalidadId).HasColumnName("CALIDAD_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EncabezadoId).HasColumnName("ENCABEZADO_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Limax).HasColumnName("LIMAX");

                entity.Property(e => e.Limin).HasColumnName("LIMIN");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.PosFormato).HasColumnName("POS_FORMATO");

                entity.Property(e => e.PosReporte).HasColumnName("POS_REPORTE");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.StatusPws)
                    .HasMaxLength(255)
                    .HasColumnName("STATUS_PWS");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.TipoVariableId).HasColumnName("TIPO_VARIABLE_ID");

                entity.Property(e => e.TituloReporteId)
                    .HasMaxLength(255)
                    .HasColumnName("TITULO_REPORTE_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<MasterVariablebk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASTER_VARIABLEbk", "SIGO");

                entity.Property(e => e.Auditoria)
                    .HasMaxLength(255)
                    .HasColumnName("AUDITORIA");

                entity.Property(e => e.Bolean).HasColumnName("BOLEAN");

                entity.Property(e => e.CalidadId).HasColumnName("CALIDAD_ID");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Discrepancia).HasColumnName("DISCREPANCIA");

                entity.Property(e => e.EncabezadoId).HasColumnName("ENCABEZADO_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.FrecuenciaId).HasColumnName("FRECUENCIA_ID");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Limax).HasColumnName("LIMAX");

                entity.Property(e => e.Limin).HasColumnName("LIMIN");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.NombreVariable)
                    .HasMaxLength(255)
                    .HasColumnName("NOMBRE_VARIABLE");

                entity.Property(e => e.PosFormato).HasColumnName("POS_FORMATO");

                entity.Property(e => e.PosReporte).HasColumnName("POS_REPORTE");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.StatusPws)
                    .HasMaxLength(255)
                    .HasColumnName("STATUS_PWS");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.TipoVariableId).HasColumnName("TIPO_VARIABLE_ID");

                entity.Property(e => e.TituloReporteId)
                    .HasMaxLength(255)
                    .HasColumnName("TITULO_REPORTE_ID");

                entity.Property(e => e.UnidadMedidaId).HasColumnName("UNIDAD_MEDIDA_ID");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<NivelAcceso>(entity =>
            {
                entity.HasKey(e => e.AccesoId);

                entity.ToTable("NIVEL_ACCESO", "SIGO");

                entity.Property(e => e.AccesoId).HasColumnName("ACCESO_ID");

                entity.Property(e => e.Administrador).HasColumnName("ADMINISTRADOR");

                entity.Property(e => e.Asentamiento).HasColumnName("ASENTAMIENTO");

                entity.Property(e => e.Auditoria).HasColumnName("AUDITORIA");

                entity.Property(e => e.AuditoriaBombas).HasColumnName("AUDITORIA_BOMBAS");

                entity.Property(e => e.Descrpcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRPCION");

                entity.Property(e => e.PerfilTrasversal).HasColumnName("PERFIL_TRASVERSAL");

                entity.Property(e => e.PlanDeAccion).HasColumnName("PLAN DE ACCION");

                entity.Property(e => e.Procesos).HasColumnName("PROCESOS");

                entity.Property(e => e.ReporteGerencial).HasColumnName("REPORTE_GERENCIAL");

                entity.Property(e => e.ReporteRegional).HasColumnName("REPORTE_REGIONAL");

                entity.Property(e => e.ReportesVestimentas).HasColumnName("REPORTES_VESTIMENTAS");
            });

            modelBuilder.Entity<PowerSuite>(entity =>
            {
                entity.ToTable("POWER_SUITE", "SIGO");

                entity.Property(e => e.PowersuiteId).HasColumnName("POWERSUITE_ID");

                entity.Property(e => e.DiscrepanciaId).HasColumnName("DISCREPANCIA_ID");

                entity.Property(e => e.FechaArranque).HasColumnName("FECHA_ARRANQUE");

                entity.Property(e => e.FechaEstimada).HasColumnName("FECHA_ESTIMADA");

                entity.Property(e => e.FechaParada).HasColumnName("FECHA_PARADA");

                entity.Property(e => e.HoraArranque).HasColumnName("HORA_ARRANQUE");

                entity.Property(e => e.HoraParada).HasColumnName("HORA_PARADA");

                entity.Property(e => e.MasterVariableId).HasColumnName("MASTER_VARIABLE_ID");

                entity.Property(e => e.NumeroPws)
                    .HasMaxLength(10)
                    .HasColumnName("NUMERO_PWS")
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(400)
                    .HasColumnName("OBSERVACION");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");
            });

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("prueba");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.CodEam)
                    .HasMaxLength(10)
                    .HasColumnName("COD_EAM")
                    .IsFixedLength();

                entity.Property(e => e.DataId).HasColumnName("DATA_ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Expresion)
                    .HasMaxLength(20)
                    .HasColumnName("EXPRESION")
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(2)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.Ht1).HasColumnName("HT1");

                entity.Property(e => e.Ht2).HasColumnName("HT2");

                entity.Property(e => e.Ht3).HasColumnName("HT3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.NombreVariable)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VARIABLE");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.Turno).HasColumnName("TURNO");

                entity.Property(e => e.Vct1).HasColumnName("VCT1");

                entity.Property(e => e.Vct2).HasColumnName("VCT2");

                entity.Property(e => e.Vct3).HasColumnName("VCT3");

                entity.Property(e => e.Vt1).HasColumnName("VT1");

                entity.Property(e => e.Vt2).HasColumnName("VT2");

                entity.Property(e => e.Vt3).HasColumnName("VT3");
            });

            modelBuilder.Entity<PuntoMuestreo>(entity =>
            {
                entity.ToTable("PUNTO_MUESTREO", "SIGO");

                entity.Property(e => e.PuntoMuestreoId).HasColumnName("PUNTO_MUESTREO_ID");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("CODIGO")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.PosicionFormulario).HasColumnName("POSICION_FORMULARIO");
            });

            modelBuilder.Entity<ReporteArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReporteArea");

                entity.Property(e => e.AreaId).HasColumnName("areaId");

                entity.Property(e => e.ReportAreaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reportAreaID");

                entity.Property(e => e.TipoReporteId).HasColumnName("TipoReporteID");
            });

            modelBuilder.Entity<ReporteArea1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReporteArea", "SIGO");

                entity.Property(e => e.AreaId).HasColumnName("areaId");

                entity.Property(e => e.ReportAreaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reportAreaID");

                entity.Property(e => e.TipoReporteId).HasColumnName("TipoReporteID");
            });

            modelBuilder.Entity<Rotacion>(entity =>
            {
                entity.ToTable("ROTACION");

                entity.Property(e => e.RotacionId).HasColumnName("ROTACION_ID");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Libre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LIBRE")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.T1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.T2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.T3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RzCodCasusaPt>(entity =>
            {
                entity.HasKey(e => e.CodRzPtId);

                entity.ToTable("rz_cod_casusa_pt");

                entity.Property(e => e.CodRzPtId).HasColumnName("cod_rz_pt_id");

                entity.Property(e => e.Cod)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Seccion>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("SECCION", "SIGO");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_SECCION");

                entity.Property(e => e.CodSeccion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("COD_SECCION");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.NombreSeccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_SECCION");
            });

            modelBuilder.Entity<SeccionMaquina>(entity =>
            {
                entity.ToTable("SECCION_MAQUINA", "SIGO");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<StatusAuto>(entity =>
            {
                entity.ToTable("statusAuto");

                entity.Property(e => e.StatusAutoId).HasColumnName("statusAuto_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<StatusAuto1>(entity =>
            {
                entity.HasKey(e => e.StatusAutoId);

                entity.ToTable("statusAuto", "SIGO");

                entity.Property(e => e.StatusAutoId).HasColumnName("statusAuto_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<TbEquipo>(entity =>
            {
                entity.HasKey(e => e.IdReg);

                entity.ToTable("tb_equipos", "EAM");

                entity.Property(e => e.Eaddnl)
                    .HasMaxLength(25)
                    .HasColumnName("EADDNL");

                entity.Property(e => e.Ecstcr)
                    .HasMaxLength(10)
                    .HasColumnName("ECSTCR");

                entity.Property(e => e.Edescr)
                    .HasMaxLength(25)
                    .HasColumnName("EDESCR");

                entity.Property(e => e.Ekey1)
                    .HasMaxLength(12)
                    .HasColumnName("EKEY1");

                entity.Property(e => e.Ekey2)
                    .HasMaxLength(10)
                    .HasColumnName("EKEY2");

                entity.Property(e => e.Elcid)
                    .HasMaxLength(6)
                    .HasColumnName("ELCID");

                entity.Property(e => e.Emodel)
                    .HasMaxLength(15)
                    .HasColumnName("EMODEL");

                entity.Property(e => e.Eprevs)
                    .HasMaxLength(10)
                    .HasColumnName("EPREVS");

                entity.Property(e => e.Eqcsco)
                    .HasMaxLength(2)
                    .HasColumnName("EQCSCO");

                entity.Property(e => e.Eqcslc)
                    .HasMaxLength(6)
                    .HasColumnName("EQCSLC");

                entity.Property(e => e.Eqcust)
                    .HasMaxLength(20)
                    .HasColumnName("EQCUST");

                entity.Property(e => e.Eqfixa)
                    .HasMaxLength(15)
                    .HasColumnName("EQFIXA");

                entity.Property(e => e.Eqid)
                    .HasMaxLength(10)
                    .HasColumnName("EQID");

                entity.Property(e => e.Eserno)
                    .HasMaxLength(20)
                    .HasColumnName("ESERNO");
            });

            modelBuilder.Entity<TbEquiposTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_equipos_tmp", "EAM");

                entity.Property(e => e.Eaddnl)
                    .HasMaxLength(25)
                    .HasColumnName("EADDNL");

                entity.Property(e => e.Ecstcr)
                    .HasMaxLength(10)
                    .HasColumnName("ECSTCR");

                entity.Property(e => e.Edescr)
                    .HasMaxLength(25)
                    .HasColumnName("EDESCR");

                entity.Property(e => e.Ekey1)
                    .HasMaxLength(12)
                    .HasColumnName("EKEY1");

                entity.Property(e => e.Ekey2)
                    .HasMaxLength(10)
                    .HasColumnName("EKEY2");

                entity.Property(e => e.Elcid)
                    .HasMaxLength(6)
                    .HasColumnName("ELCID");

                entity.Property(e => e.Emodel)
                    .HasMaxLength(15)
                    .HasColumnName("EMODEL");

                entity.Property(e => e.Eprevs)
                    .HasMaxLength(10)
                    .HasColumnName("EPREVS");

                entity.Property(e => e.Eqcsco)
                    .HasMaxLength(2)
                    .HasColumnName("EQCSCO");

                entity.Property(e => e.Eqcslc)
                    .HasMaxLength(6)
                    .HasColumnName("EQCSLC");

                entity.Property(e => e.Eqcust)
                    .HasMaxLength(20)
                    .HasColumnName("EQCUST");

                entity.Property(e => e.Eqfixa)
                    .HasMaxLength(15)
                    .HasColumnName("EQFIXA");

                entity.Property(e => e.Eqid)
                    .HasMaxLength(10)
                    .HasColumnName("EQID");

                entity.Property(e => e.Eserno)
                    .HasMaxLength(20)
                    .HasColumnName("ESERNO");
            });

            modelBuilder.Entity<TbInvPartesAr>(entity =>
            {
                entity.HasKey(e => e.IdReg);

                entity.ToTable("tb_Inv_Partes_AR", "EAM");

                entity.HasIndex(e => new { e.IdPais, e.Ptloc, e.Ptpart, e.Ptcntl, e.Pttext, e.Teseq }, "IX_tb_Inv_Partes_AR");

                entity.Property(e => e.Ptbin1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PTBIN1");

                entity.Property(e => e.Ptbin2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PTBIN2");

                entity.Property(e => e.Ptcmpy).HasColumnName("PTCMPY");

                entity.Property(e => e.Ptcntl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PTCNTL");

                entity.Property(e => e.Ptdesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PTDESC");

                entity.Property(e => e.Ptloc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PTLOC");

                entity.Property(e => e.Ptpart)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PTPART");

                entity.Property(e => e.Pttext).HasColumnName("PTTEXT");

                entity.Property(e => e.Teseq).HasColumnName("TESEQ");

                entity.Property(e => e.Tetext)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TETEXT");
            });

            modelBuilder.Entity<TbInvPartesTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Inv_Partes_Tmp", "EAM");

                entity.Property(e => e.Ptbin1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PTBIN1");

                entity.Property(e => e.Ptbin2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PTBIN2");

                entity.Property(e => e.Ptcmpy).HasColumnName("PTCMPY");

                entity.Property(e => e.Ptcntl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PTCNTL");

                entity.Property(e => e.Ptdesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PTDESC");

                entity.Property(e => e.Ptloc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PTLOC");

                entity.Property(e => e.Ptpart)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PTPART");

                entity.Property(e => e.Pttext)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("PTTEXT");

                entity.Property(e => e.Teseq)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("TESEQ");

                entity.Property(e => e.Tetext)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TETEXT");
            });

            modelBuilder.Entity<TbParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_param", "EAM");

                entity.Property(e => e.Estacion)
                    .HasMaxLength(2)
                    .HasColumnName("estacion");

                entity.Property(e => e.ISerie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("iSerie");

                entity.Property(e => e.IdPais).HasColumnName("idPais");

                entity.Property(e => e.LibL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParComPeso).HasColumnName("parComPeso");

                entity.Property(e => e.ParComZebra).HasColumnName("parComZebra");

                entity.Property(e => e.ParComm1)
                    .HasMaxLength(12)
                    .HasColumnName("parComm1");

                entity.Property(e => e.ParComm2)
                    .HasMaxLength(12)
                    .HasColumnName("parComm2");

                entity.Property(e => e.ParComm3)
                    .HasMaxLength(12)
                    .HasColumnName("parComm3");

                entity.Property(e => e.ParComm4)
                    .HasMaxLength(12)
                    .HasColumnName("parComm4");

                entity.Property(e => e.ParModoPeso).HasColumnName("parModoPeso");

                entity.Property(e => e.ParUpdate).HasColumnName("parUpdate");

                entity.Property(e => e.SLoc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sLoc");
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_users", "EAM");

                entity.Property(e => e.Clave).HasMaxLength(10);

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.Nombre).HasMaxLength(30);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP", "SIGO");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Variable)
                    .HasMaxLength(255)
                    .HasColumnName("VARIABLE");
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.HasKey(e => e.TipoProducId);

                entity.ToTable("TIPO_PRODUCTO", "SIGO");

                entity.Property(e => e.TipoProducId).HasColumnName("TIPO_PRODUC_ID");

                entity.Property(e => e.TipoProducto1)
                    .HasMaxLength(30)
                    .HasColumnName("TIPO_PRODUCTO");
            });

            modelBuilder.Entity<TipoReporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TIPO_REPORTE", "SIGO");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.TipoReporteId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TIPO_REPORTE_ID");
            });

            modelBuilder.Entity<TipoVariable>(entity =>
            {
                entity.ToTable("TIPO_VARIABLE", "SIGO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<TituloReporte>(entity =>
            {
                entity.HasKey(e => e.IdTitulo);

                entity.ToTable("TITULO_REPORTE", "SIGO");

                entity.Property(e => e.IdTitulo).HasColumnName("ID_TITULO");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.NombreTitulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_TITULO");

                entity.Property(e => e.Posicion).HasColumnName("POSICION");
            });

            modelBuilder.Entity<UnidadMedidum>(entity =>
            {
                entity.HasKey(e => e.UnidadId);

                entity.ToTable("UNIDAD_MEDIDA", "SIGO");

                entity.Property(e => e.UnidadId).HasColumnName("UNIDAD_ID");

                entity.Property(e => e.Expresion)
                    .HasMaxLength(20)
                    .HasColumnName("EXPRESION")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIOS", "SIGO");

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.CargoId).HasColumnName("CARGO_ID");

                entity.Property(e => e.Clave)
                    .HasMaxLength(10)
                    .HasColumnName("CLAVE")
                    .IsFixedLength();

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.EquipoId).HasColumnName("EQUIPO_ID");

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .HasColumnName("LOGIN")
                    .IsFixedLength();

                entity.Property(e => e.NivelaccesoId).HasColumnName("NIVELACCESO_ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.StatusClave).HasColumnName("STATUS_CLAVE");
            });

            modelBuilder.Entity<VarDif>(entity =>
            {
                entity.HasKey(e => e.VarResultId);

                entity.ToTable("varDif");

                entity.Property(e => e.VarResultId)
                    .ValueGeneratedNever()
                    .HasColumnName("varResultID");

                entity.Property(e => e.DifVarCalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("difVarCalID");

                entity.Property(e => e.PaisId).HasColumnName("paisID");

                entity.Property(e => e.VarOper1Id).HasColumnName("varOper1ID");

                entity.Property(e => e.VarOper2Id).HasColumnName("varOper2ID");
            });

            modelBuilder.Entity<VarDif1>(entity =>
            {
                entity.HasKey(e => e.VarResultId);

                entity.ToTable("varDif", "SIGO");

                entity.Property(e => e.VarResultId)
                    .ValueGeneratedNever()
                    .HasColumnName("varResultID");

                entity.Property(e => e.DifVarCalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("difVarCalID");

                entity.Property(e => e.PaisId).HasColumnName("paisID");

                entity.Property(e => e.VarOper1Id).HasColumnName("varOper1ID");

                entity.Property(e => e.VarOper2Id).HasColumnName("varOper2ID");
            });

            modelBuilder.Entity<Variable>(entity =>
            {
                entity.HasKey(e => e.IdVariable);

                entity.ToTable("VARIABLE", "SIGO");

                entity.Property(e => e.IdVariable).HasColumnName("ID_VARIABLE");

                entity.Property(e => e.Agrupado).HasColumnName("AGRUPADO");

                entity.Property(e => e.AreaId).HasColumnName("AREA_ID");

                entity.Property(e => e.CodRegional)
                    .HasMaxLength(15)
                    .HasColumnName("COD_REGIONAL")
                    .IsFixedLength();

                entity.Property(e => e.NombreVariable)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VARIABLE");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.TipoVariableId).HasColumnName("TIPO_VARIABLE_ID");

                entity.Property(e => e.TituloReporteId).HasColumnName("TITULO_REPORTE_ID");
            });

            modelBuilder.Entity<VariableRegional>(entity =>
            {
                entity.ToTable("VARIABLE_REGIONAL", "SIGO");

                entity.Property(e => e.VariableRegionalId).HasColumnName("VARIABLE_REGIONAL_ID");

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.LiteralVariable)
                    .HasMaxLength(100)
                    .HasColumnName("LITERAL_VARIABLE");

                entity.Property(e => e.VariableId).HasColumnName("VARIABLE_ID");
            });

            modelBuilder.Entity<VariablesAutoMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("variablesAutoMaster");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Vautid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VAUTID");

                entity.Property(e => e.Vautsigo).HasColumnName("VAUTSIGO");

                entity.Property(e => e.Vautww)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VAUTWW");
            });

            modelBuilder.Entity<VariablesAutoMaster1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("variablesAutoMaster", "SIGO");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Vautid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VAUTID");

                entity.Property(e => e.Vautsigo).HasColumnName("VAUTSIGO");

                entity.Property(e => e.Vautww)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VAUTWW");
            });

            modelBuilder.Entity<VistaDiarioDiscrepanciaTurno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VISTA_DIARIO_DISCREPANCIA_TURNO");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.CodEam)
                    .HasMaxLength(10)
                    .HasColumnName("COD_EAM")
                    .IsFixedLength();

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.D3).HasColumnName("d3");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Expresion)
                    .HasMaxLength(20)
                    .HasColumnName("EXPRESION")
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Hora).HasColumnName("HORA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreVariable)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VARIABLE");

                entity.Property(e => e.Turno1).HasColumnName("TURNO_1");

                entity.Property(e => e.Turno2).HasColumnName("TURNO_2");

                entity.Property(e => e.Turno3).HasColumnName("TURNO_3");
            });

            modelBuilder.Entity<VwGrafDiscreMensual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_GRAF_DISCRE_MENSUAL");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.Dia).HasColumnName("dia");

                entity.Property(e => e.Fecha).HasColumnName("FECHA");
            });

            modelBuilder.Entity<VwReportDiario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_REPORT_DIARIO");

                entity.Property(e => e.CentroTrabajoId).HasColumnName("CENTRO_TRABAJO_ID");

                entity.Property(e => e.CodEam)
                    .HasMaxLength(10)
                    .HasColumnName("COD_EAM")
                    .IsFixedLength();

                entity.Property(e => e.DataId).HasColumnName("DATA_ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength();

                entity.Property(e => e.Expresion)
                    .HasMaxLength(20)
                    .HasColumnName("EXPRESION")
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnName("FECHA");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(2)
                    .HasColumnName("GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.NombreVariable)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VARIABLE");

                entity.Property(e => e.SeccionMaquinaId).HasColumnName("SECCION_MAQUINA_ID");

                entity.Property(e => e.TipoReporteId).HasColumnName("TIPO_REPORTE_ID");

                entity.Property(e => e.Turno).HasColumnName("TURNO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
